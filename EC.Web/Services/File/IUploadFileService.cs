using EC.Web.ViewModels.Base;
using System.Collections.Generic;

namespace EC.Web.Services.File
{
    public interface IUploadFileService
    {
        List<UploadFileViewModel> GetFiles(string userName, string key);

        void AddFile(string userName, string key, string id, string fileName, long size);

        void ClearFiles(string userName, string key);

    }
}
