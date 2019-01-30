//using System.Collections.Generic;
//using System.Linq;
//using EC.Web.ViewModels.Base;
//using Microsoft.AspNetCore.Http;

//namespace EC.Web.Services.File
//{
//    public class UploadFileService : IUploadFileService
//    {
//        private List<UploadFileRepositoryViewModel> UploadFiles;

//        public List<IFormFile> GetFiles(string userName, string key)
//        {
//            if (UploadFiles == null)
//                return new List<IFormFile>();
//            else
//            {
//                var uploadFile = UploadFiles.FirstOrDefault(x => x.UserName == userName && x.Key == key);
//                if (uploadFile == null)
//                    return new List<IFormFile>();
//                else
//                    return uploadFile.Files;
//            }
//        }

//        public void AddFiles(string userName, string key, List<IFormFile> files)
//        {
//            if (UploadFiles == null)
//            {
//                UploadFiles = new List<UploadFileRepositoryViewModel>();
//                UploadFiles.Add(new UploadFileRepositoryViewModel
//                {
//                    UserName = userName,
//                    Key = key,
//                    Files = files
//                });
//            }
//            else
//            {
//                var uploadFile = UploadFiles.FirstOrDefault(x => x.UserName == userName && x.Key == key);
//                if (uploadFile == null)
//                {
//                    UploadFiles.Add(new UploadFileRepositoryViewModel
//                    {
//                        UserName = userName,
//                        Key = key,
//                        Files = files
//                    });
//                }
//                else
//                {
//                    uploadFile.Files.AddRange(files);
//                }
//            }
//        }

//        public void ClearFiles(string userName, string key)
//        {
//            if (UploadFiles == null)
//                UploadFiles = new List<UploadFileRepositoryViewModel>();

//            var uploadFile = UploadFiles.FirstOrDefault(x => x.UserName == userName && x.Key == key);
//            if (uploadFile != null)
//            {
//                UploadFiles.Remove(uploadFile);
//            }
//        }

//    }
//}
