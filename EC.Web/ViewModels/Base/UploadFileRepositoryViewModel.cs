using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace EC.Web.ViewModels.Base
{
    public class UploadFileRepositoryViewModel
    {
        public string UserName { get; set; }

        public string Key { get; set; }

        public List<IFormFile> Files { get; set; }

    }
}
