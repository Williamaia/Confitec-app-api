using AutoMapper;
using Confitec.Business.Models;
using Confitec.WebApi.ViewModels;

namespace Confitec.WebApi.Configurations
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Usuarios, UsuarioViewModel>().ReverseMap();
        }
    }
}
