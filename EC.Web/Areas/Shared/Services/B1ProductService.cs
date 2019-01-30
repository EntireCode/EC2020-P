using EC.Web.Areas.Inventory.Data.B1;
using EC.Web.Areas.Shared.Data.ViewModels;
using EC.Web.Helpers.Extensions;
using System;
using System.Collections.Generic;

namespace EC.Web.Areas.Shared.Services
{
    public interface IB1ProductService
    {
        List<B1ProductViewModel> Get();
    }

    public class B1ProductService : IB1ProductService
    {
        private readonly B1DbContext _context;

        public B1ProductService(B1DbContext context)
        {
            _context = context;
        }

        public List<B1ProductViewModel> Get()
        {
            var result = _context.Database.RawSqlQuery<B1ProductViewModel>(
                "select ItemCode as PartNumber, ItemName as ProductDescription, FrgnName as CustomerPartNumber from OITM where validFor = 'Y'",
                x => new B1ProductViewModel
                {
                    ItemCode = (string)x[0],
                    ItemName = (string)x[1],
                    FrgnName = x[2] is DBNull ? "" : (string)x[2]
                });
            return result;
        }
    }
}
