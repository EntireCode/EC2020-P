using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace EC.Web.Helpers.Extensions
{
    public static class RDBFacadeExtensions
    {
        public static RelationalDataReader ExecuteSqlQuery(this DatabaseFacade databaseFacade, string sql, params object[] parameters)
        {
            var concurrencyDetector = databaseFacade.GetService<IConcurrencyDetector>();

            using (concurrencyDetector.EnterCriticalSection())
            {
                var rawSqlCommand = databaseFacade
                    .GetService<IRawSqlCommandBuilder>()
                    .Build(sql, parameters);

                return rawSqlCommand
                    .RelationalCommand
                    .ExecuteReader(
                        databaseFacade.GetService<IRelationalConnection>(),
                        parameterValues: rawSqlCommand.ParameterValues);
            }
        }

        public static async Task<RelationalDataReader> ExecuteSqlQueryAsync(this DatabaseFacade databaseFacade,
                                                             string sql,
                                                             CancellationToken cancellationToken = default(CancellationToken),
                                                             params object[] parameters)
        {

            var concurrencyDetector = databaseFacade.GetService<IConcurrencyDetector>();

            using (concurrencyDetector.EnterCriticalSection())
            {
                var rawSqlCommand = databaseFacade
                    .GetService<IRawSqlCommandBuilder>()
                    .Build(sql, parameters);

                return await rawSqlCommand
                    .RelationalCommand
                    .ExecuteReaderAsync(
                        databaseFacade.GetService<IRelationalConnection>(),
                        parameterValues: rawSqlCommand.ParameterValues,
                        cancellationToken: cancellationToken);
            }
        }

        public static List<T> RawSqlQuery<T>(this DatabaseFacade databaseFacade, string query, Func<DbDataReader, T> map)
        {
            using (var command = databaseFacade.GetService<IRelationalConnection>().DbConnection.CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                databaseFacade.GetService<IRelationalConnection>().Open();
                using (var result = command.ExecuteReader())
                {
                    var entities = new List<T>();
                    while(result.Read())
                    {
                        entities.Add(map(result));
                    }
                    return entities;
                }
            }
        }
    }
}
