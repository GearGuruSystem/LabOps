using AutoMapper;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Usuarios;

namespace LabOps.WebUI.Helpers.Mapper
{
    public class MapUsuarios : Profile
    {
        public MapUsuarios()
        {
            CreateMap<UsuarioDTO, UsuarioLoginDTO>().ReverseMap();
        }
    }
}
