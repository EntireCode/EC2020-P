using AutoMapper;
using EC.Web.Data;
using EC.Web.ViewModels.Admin;

namespace EC.Web.Helpers
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
           CreateMap<ApplicationUser, UserViewModel>();
        }
    }
}
