using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Services.Alert;
using EC.Web.Services.File;
using EC.Web.ViewModels.Demo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EC.Web.Areas.RMA.Pages.Demo
{
    public class IndexModel : PageModel
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IUploadFileService _uploadFileService;
        private const string _key = "DemoCreate";

        public IndexModel(IHostingEnvironment hostingEnvironment, IUploadFileService uploadFileService)
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

        public ActionResult OnPostSaveOrder(string customer, OrderDetailViewModel[] details)
        {
            var result = "Error! Order is not completed.";
            
            //save to db
            result = "Success! Order is completed.";
            //redirect to index page
            return new JsonResult(result);
        }
    }
}