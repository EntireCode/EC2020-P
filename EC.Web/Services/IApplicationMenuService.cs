using EC.Web.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EC.Web.Services
{
    public interface IApplicationMenuService
    {
        Task<List<ApplicationMenu>> GetApplicationMenusAsync();

        Task<List<ApplicationMenu>> GetAssignedApplicationMenusAsync(List<string> roleNames);
    }
}
