using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EC.Web.Areas.Examples.Data.Entity;
using EC.Web.Areas.Examples.Data.ViewModel;
using EC.Web.Areas.RMA.Pages.Demo;
using EC.Web.Services.Examples;
using EC.Web.Services.File;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EC.Web.Areas.Examples.Pages
{
    [Authorize()]
    public class SampleOrderModel : PageModel
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IUploadFileService _uploadFileService;
        private readonly IExamplesRepository _exampleRepository;
        private readonly ExampleDbContext _context;
        private const string _key = "SampleOrder";

        public SampleOrderModel(IHostingEnvironment hostingEnvironment, 
            IUploadFileService uploadFileService,
            IExamplesRepository examplesRepository,
            ExampleDbContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _uploadFileService = uploadFileService;
            _context = context;
            _exampleRepository = examplesRepository;
            Orders = new List<OrderViewModel>();
        }

        public List<OrderViewModel> Orders { get; set; }

        public void OnGet()
        {            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderViewModel>();
                cfg.CreateMap<Customer, CustomerViewModel>();
                cfg.CreateMap<OrderItem, OrderItemViewModel>();
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<OrderAttachment, OrderAttachmentViewModel>();
            });

            IMapper mapper = config.CreateMapper();

            var orders = _context.Orders.Include(x => x.Items).Include(x => x.Customer).ToList();
            
            foreach(var order in orders)
            {
                var orderVM = mapper.Map<Order, OrderViewModel>(order);
                foreach(var itemVM in orderVM.Items)
                {                    
                    var productVM = mapper.Map<Product, ProductViewModel>(_context.Products.FirstOrDefault(x => x.Id == itemVM.ProductId));
                    itemVM.Product = productVM;
                }
                Orders.Add(orderVM);
            }
        }

        public ActionResult OnPostSaveOrder([FromBody] OrderViewModel data)
        {
            var result = "Error! Order is not completed.";

            //save to db
            // populate order
            
            var order = new Order
            {
                CustomerId = data.CustomerId,
                OrderDate = DateTime.UtcNow,
                Items = new List<OrderItem>(),
                Attachments = new List<OrderAttachment>()
            };
            // populate order details
            foreach (var detail in data.Items)
            {
                var orderItem = new OrderItem
                {
                    ItemNo = detail.ItemNo,
                    ProductId = detail.ProductId,
                    Quantity = detail.Quantity
                };
                order.Items.Add(orderItem);
            }
            // populate attachments
            var files = _uploadFileService.GetFiles(User.Identity.Name, _key);
            var fileNames = data.Attachments.Select(x => x.FileName).ToList();
            foreach (var attachment in data.Attachments)
            {
                order.Attachments.Add(new OrderAttachment {
                    Id = attachment.Id,
                    FileName = attachment.FileName,
                    Size = attachment.Size
                });
            }
            _context.Orders.Add(order);
            _context.SaveChanges();
            // remove file stored from uploads folder which not exists in attachments
            foreach (var file in files.Where(x => !fileNames.Contains(x.FileName)))
            {
                var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                var fileName = file.Id + Path.GetExtension(file.FileName);
                if (System.IO.File.Exists(Path.Combine(uploads, fileName)))
                {
                    System.IO.File.Delete(Path.Combine(uploads, fileName));
                }
            }

            result = "Success! Order is completed.";
            //redirect to index page
            return new JsonResult(result);
        }

        public ActionResult OnPostUploadFilesAjax(List<IFormFile> files)
        {
            try
            {
                if (User.Identity == null)
                {

                }
                //UploadFiles(files);                
                List<string> fileNames = new List<string>();
                List<FileViewModel> fileUploads = new List<FileViewModel>();
                foreach (var file in files)
                {
                    var id = Guid.NewGuid().ToString().Replace("-", "");
                    fileNames.Add(file.FileName);
                    fileUploads.Add(new FileViewModel { Id = id, FileName = file.FileName, Size = file.Length });
                    UploadFile(id, file);
                    _uploadFileService.AddFile(User.Identity.Name, _key, id, file.FileName, file.Length);
                }
                return new JsonResult(fileUploads);
            }
            catch (Exception ex)
            {
                return new JsonResult(new { status = "failed", message = ex.Message });
            }
        }

        private void UploadFile(string id, IFormFile file)
        {
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");

            try
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = id + Path.GetExtension(file.FileName);
                    using (var s = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                    {
                        file.CopyToAsync(s).Wait();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}