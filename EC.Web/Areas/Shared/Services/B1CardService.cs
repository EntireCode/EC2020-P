using EC.Web.Areas.Inventory.Data.B1;
using EC.Web.Areas.Shared.Data.ViewModels;
using EC.Web.Helpers.Extensions;
using System;
using System.Collections.Generic;

namespace EC.Web.Areas.Shared.Services
{
    public interface IB1CardService
    {
        List<B1CustomerViewModel> GetCustomers();
    }

    public class B1CardService : IB1CardService
    {
        private readonly B1DbContext _context;

        public B1CardService(B1DbContext context)
        {
            _context = context;
        }

        public List<B1CustomerViewModel> GetCustomers()
        {
            var result = _context.Database.RawSqlQuery<B1CustomerViewModel>(
               "select CardCode as Customer, CardName as CustomerName, E_Mail from OCRD WHERE CardType = 'C' and validFor ='Y'",
               x => new B1CustomerViewModel
               {
                   CardCode = (string)x[0],
                   CardName = (string)x[1],
                   E_Mail = x[2] == DBNull.Value ? null : (string)x[2]
               });
            return result;
        }        
    }
}
