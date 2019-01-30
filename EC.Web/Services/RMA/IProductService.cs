using EC.Web.Areas.RMA.Data;
using System.Collections.Generic;

namespace EC.Web.Services.RMA
{
    public interface IProductService
    {
        Product GetProductByPartNumber(string partNumber);
        List<Product> GetProductByModelNumber(string modelNumber);
        Product GetProductBySerialNumber(string serialNumber);
        List<Product> GetProducts();
    }
}
