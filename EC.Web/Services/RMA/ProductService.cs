using EC.Web.Areas.Inventory.Data.B1;
using EC.Web.Areas.RMA.Data;
using System.Collections.Generic;
using System.Linq;

namespace EC.Web.Services.RMA
{
    public class ProductService : IProductService
    {
        private readonly B1DbContext _context;

        public ProductService(B1DbContext context)
        {
            _context = context;
        }

        public Product GetProductByPartNumber(string partNumber)
        {
            var product = (from o in _context.Oitms
                           where o.ItemName == partNumber
                           select new Product
                           {
                               PartNumber = o.ItemName,                               
                           }).FirstOrDefault();
            return product;
        }

        public List<Product> GetProductByModelNumber(string modelNumber)
        {
            return new List<Product>();
        }

        public Product GetProductBySerialNumber(string serialNumber)
        {
            return new Product();
        }

        public List<Product> GetProducts()
        {
            var products = (from o in _context.Oitms
                            select new Product
                            {
                                PartNumber = o.ItemName,
                            }).ToList();

            return products;
        }
    }
}
