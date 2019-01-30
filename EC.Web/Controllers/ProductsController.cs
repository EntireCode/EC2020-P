using System.Collections.Generic;
using System.Linq;
using EC.Web.Areas.RMA.Data;
using EC.Web.Services.RMA;
using Microsoft.AspNetCore.Mvc;

namespace EC.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetProducts")]
        public ActionResult<List<ProductViewModel>> GetProducts(string prefix)
        {
            var data = new List<ProductViewModel>();            
            data = _productService.GetProducts()
                .Where(x => x.PartNumber.Contains(prefix))
                .Select(x => new ProductViewModel { Code = x.PartNumber, PartNumber = x.PartNumber })
                .ToList();
            return data;
        }

        //[HttpGet]
        //[Route("GetPartNumbers")]
        //public ActionResult<List<string>> GetPartNumbers(string prefix)
        //{
        //    var data = new List<string>();
        //    if (prefix.Length > 4)
        //        data = _productService.GetProducts().Where(x => x.PartNumber.StartsWith(prefix)).Select(x => x.PartNumber).ToList();
        //    return data;
        //}

        [HttpGet]
        [Route("GetPartNumbers")]
        public ActionResult<List<ProductViewModel>> GetPartNumbers(string prefix)
        {
            var data = new List<ProductViewModel>();
            if (prefix.Length > 4)
                data = _productService.GetProducts().Where(x => x.PartNumber.StartsWith(prefix)).Select(x => new ProductViewModel { Code = x.PartNumber, PartNumber = x.PartNumber }).ToList();
            return data;
        }
    }

    public class ProductViewModel
    {
        public string Code { get; set; }
        public string PartNumber { get; set; }
    }
}