using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EC.Web.Areas.Examples.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EC.Web.Controllers.Examples
{
    [Route("api/examples/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ExampleDbContext _context;

        public ProductsController(ExampleDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetProducts")]
        public ActionResult<List<EC.Web.Areas.Examples.Data.ViewModel.ProductViewModel>> GetProducts(string prefix)
        {
            var data = new List<EC.Web.Areas.Examples.Data.ViewModel.ProductViewModel>();
            if (!string.IsNullOrEmpty(prefix) && prefix.Length > 4)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Order, EC.Web.Areas.Examples.Data.ViewModel.OrderViewModel>();
                    cfg.CreateMap<Customer, EC.Web.Areas.Examples.Data.ViewModel.CustomerViewModel>();
                    cfg.CreateMap<OrderItem, EC.Web.Areas.Examples.Data.ViewModel.OrderItemViewModel>();
                    cfg.CreateMap<Product, EC.Web.Areas.Examples.Data.ViewModel.ProductViewModel>();
                    cfg.CreateMap<OrderAttachment, EC.Web.Areas.Examples.Data.ViewModel.OrderAttachmentViewModel>();
                });
                IMapper mapper = config.CreateMapper();                
                data = _context.Products.Where(x => x.PartNo.StartsWith(prefix)).Select(x => mapper.Map<Product, EC.Web.Areas.Examples.Data.ViewModel.ProductViewModel>(x)).ToList();
            }            
            return data;
        }
    }
}