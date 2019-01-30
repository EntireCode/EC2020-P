using EC.Web.Areas.Inventory.Data.B1;
using EC.Web.Areas.Shared.Data.ViewModels;
using EC.Web.Helpers.Extensions;
using System.Collections.Generic;

namespace EC.Web.Areas.Shared.Services
{
    public interface IB1UserService
    {
        List<B1UserViewModel> GetSalesPersons();

        List<B1SalesManagerViewModel> GetSalesManagers();
    }

    public class B1UserService : IB1UserService
    {
        private readonly B1DbContext _context;

        public B1UserService(B1DbContext context)
        {
            _context = context;
        }

        public List<B1UserViewModel> GetSalesPersons()
        {
            var result = _context.Database.RawSqlQuery<B1UserViewModel>(
                "select USER_CODE, E_Mail from OUSR where Locked = 'N' and E_Mail is not null",
                x => new B1UserViewModel
                {
                    User_Code = (string)x[0],
                    E_Mail = (string)x[1]
                });
            return result;
        }

        public List<B1SalesManagerViewModel> GetSalesManagers()
        {
            var result = _context.Database.RawSqlQuery<B1SalesManagerViewModel>(
                "select FldValue as SalesManagerCode, Descr as SalesManagerName from UFD1 where tableid = 'OCRD'",
                x => new B1SalesManagerViewModel
                {
                    FldValue = (string)x[0],
                    Descr = (string)x[1],
                });
            return result;
        }
    }
}
