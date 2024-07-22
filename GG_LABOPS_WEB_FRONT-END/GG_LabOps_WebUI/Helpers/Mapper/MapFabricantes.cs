using AutoMapper;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Fabricantes;
using LabOps.WebUI.Models.Fabricantes;

namespace LabOps.WebUI.Helpers.Mapper
{
    public class MapFabricantes : Profile
    {
        public MapFabricantes()
        {
            CreateMap<FabricanteDTO, FabricanteModel>().ReverseMap();
            CreateMap<CadastroFabricanteModel, CriarNovoFDTO>().ReverseMap();
        }
    }
}
