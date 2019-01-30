using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC.Web.ViewModels.Base;

namespace EC.Web.Services.File
{
    public class UploadFileService : IUploadFileService
    {
        private List<UploadFileViewModel> UploadFiles;

        public void AddFile(string userName, string key, string id, string fileName, long size)
        {
            if (UploadFiles == null)
            {
                UploadFiles = new List<UploadFileViewModel>();                
            }
            
            UploadFiles.Add(new UploadFileViewModel
            {
                UserName = userName,
                Key = key,
                Id = id,
                FileName = fileName,
                Size = size
            });
                        
        }

        public void ClearFiles(string userName, string key)
        {
            if (UploadFiles == null)
                UploadFiles = new List<UploadFileViewModel>();

            UploadFiles.RemoveAll(x => x.UserName == userName && x.Key == key);
        }

        public List<UploadFileViewModel> GetFiles(string userName, string key)
        {
            if (UploadFiles == null)
                return new List<UploadFileViewModel>();
            else
            {
                var uploadFiles = UploadFiles.Where(x => x.UserName == userName && x.Key == key).ToList();
                if (uploadFiles == null)
                    return new List<UploadFileViewModel>();
                else
                    return uploadFiles;
            }
        }
    }
}
