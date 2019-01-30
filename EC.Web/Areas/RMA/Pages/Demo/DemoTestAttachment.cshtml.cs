using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Services.Alert;
using EC.Web.Services.File;
using EC.Web.ViewModels.Base;
using EC.Web.ViewModels.Demo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EC.Web.Areas.RMA.Pages.Demo
{
    [Authorize]
    public class DemoTestAttachmentModel : PageModel
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IUploadFileService _uploadFileService;
        private const string _key = "DemoTest";

        public DemoTestAttachmentModel(IHostingEnvironment hostingEnvironment, IUploadFileService uploadFileService)
        {
            _hostingEnvironment = hostingEnvironment;
            _uploadFileService = uploadFileService;
            Orders = new List<OrderViewModel>
            {
                new OrderViewModel
                {
                    Id = 1,
                    Customer = "Apple",
                    OrderDate = DateTime.Parse("12/1/2018"),
                    Attachments = new List<OrderAttachmentViewModel>(),
                    Details = new List<OrderDetailViewModel>
                    {
                        new OrderDetailViewModel
                        {
                            OrderId = 1,
                            ItemNo = 1,
                            PartNo = "iPad Pro 11",
                            UnitPrice = 799,
                            Quantity = 1
                        },
                        new OrderDetailViewModel
                        {
                            OrderId = 1,
                            ItemNo = 2,
                            PartNo = "iPad Pro 12.9",
                            UnitPrice = 899,
                            Quantity = 1
                        }
                    }
                },
                new OrderViewModel
                {
                    Id = 2,
                    Customer = "Google",
                    OrderDate = DateTime.Parse("12/2/2018"),
                    Attachments = new List<OrderAttachmentViewModel>(),
                    Details = new List<OrderDetailViewModel>
                    {
                        new OrderDetailViewModel
                        {
                            OrderId = 2,
                            ItemNo = 1,
                            PartNo = "Slate 12",
                            UnitPrice = 699,
                            Quantity = 1
                        }
                    }
                }
            };
        }

        [BindProperty]
        public List<OrderViewModel> Orders { get; set; }

        public void OnGet()
        {
            GetData();
        }

        private List<OrderViewModel> GetData()
        {
            return Orders;
        }

        public ActionResult OnPostSaveOrder([FromBody] Data data)
        {
            var result = "Error! Order is not completed.";

            //save to db
            // populate order
            var id = Orders.Count() + 1;
            var newOrder = new OrderViewModel
            {
                Id = id,
                Customer = data.Customer,
                OrderDate = DateTime.UtcNow,
                Details = new List<OrderDetailViewModel>(),
                Attachments = new List<OrderAttachmentViewModel>()
            };
            // populate order details
            foreach (var detail in data.details)
            {
                detail.OrderId = id;
                newOrder.Details.Add(detail);
            }
            // populate attachments
            var files = _uploadFileService.GetFiles(User.Identity.Name, _key);
            var fileNames = data.attachments.Select(x => x.FileName).ToList();
            foreach (var attachment in data.attachments)
            {
                newOrder.Attachments.Add(attachment);
            }
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

                //_uploadFileService.AddFiles(User.Identity.Name, _key, files);

                return new JsonResult(fileUploads);
                //return new JsonResult(fileNames);
                //return new JsonResult(new { status = "success", message = "123" });
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

        private void UploadFiles(List<IFormFile> files)
        {
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            
            try
            {
                foreach (var file in files)
                {
                    if (file != null && file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") +
                                        Path.GetExtension(file.FileName);
                        using (var s = new FileStream(Path.Combine(uploads, fileName),
                                                                    FileMode.Create))
                        {
                            file.CopyToAsync(s).Wait();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class FileViewModel
    {
        public string Id { get; set; }

        public string FileName { get; set; }

        public long Size { get; set; }
    }
}