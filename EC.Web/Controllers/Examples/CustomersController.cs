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
    public class CustomersController : ControllerBase
    {
        private readonly ExampleDbContext _context;

        public CustomersController(ExampleDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetCustomers")]
        public ActionResult<List<EC.Web.Areas.Examples.Data.ViewModel.CustomerViewModel>> GetCustomers(string prefix)
        {
            var data = new List<EC.Web.Areas.Examples.Data.ViewModel.CustomerViewModel>();
            if (!string.IsNullOrEmpty(prefix))
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
                data = _context.Customers.Where(x => x.CustomerName.StartsWith(prefix)).Select(x => mapper.Map<Customer, EC.Web.Areas.Examples.Data.ViewModel.CustomerViewModel>(x)).ToList();
            }
            return data;
        }
    }
}