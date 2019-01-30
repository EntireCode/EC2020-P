using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.Services.Alert;
using EC.Web.Services.File;
using EC.Web.ViewModels.Base;
using EC.Web.ViewModels.Demo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EC.Web.Areas.RMA.Pages.Demo
{
    public class DemoCreateModel : PageModel
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IUploadFileService _uploadFileService;
        private const string _key = "DemoCreate";

        public DemoCreateModel(IHostingEnvironment hostingEnvironment, IUploadFileService uploadFileService)
        {
            _hostingEnvironment = hostingEnvironment;
            _uploadFileService = uploadFileService;
        }

        [BindProperty]
        public OrderViewModel Input { get; set; }

        [BindProperty]
        public IFormFile[] Files { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task OnGetAsync()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Keys.SelectMany(k => this.ModelState[k].Errors).ToList();

                return Page();
            }
            //save to db

            //redirect to index page
            return RedirectToPage("./Index").WithSuccess("", string.Format("Demo Order {0} Created.", Input.Id));
        }

        public ActionResult OnPostUploadFilesAjax(List<IFormFile> files, IUploadFileService uploadFileService)
        {
            List<AttachmentViewModel> attachments = new List<AttachmentViewModel>();

            try
            {
                //UploadFiles(files);
                //_uploadFileService.AddFiles(User.Identity.Name, _key, files);
                foreach (var file in files)
                {
                    attachments.Add(new AttachmentViewModel { FileName = file.FileName, Size = file.Length });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new { status = "failed", message = ex.Message });

            }
            ViewData["Attachments"] = attachments;
            return new PartialViewResult()
            {
                ViewName = "_AttachmentsView",
                ViewData = ViewData
            };
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
}