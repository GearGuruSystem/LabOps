using AutoMapper;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Equipamentos;
using LabOps.WebUI.Models.Equipamentos;

namespace LabOps.WebUI.Helpers.Mapper
{
    public class MapEquipamentos : Profile
    {
        public MapEquipamentos()
        {
            CreateMap<CriarNovoEDTO, CriarNovoEModel>().ReverseMap();
            CreateMap<EquipamentoSimplesDTO, EquipamentosModel>().ReverseMap();

            CreateMap<EquipamentoDTO, EquipamentosModel>()
                .ForMember(dest => dest.FabricanteNome, opts => opts.MapFrom(src => src.FabricanteDto.Nome))
                .ForMember(dest => dest.TipoEquipamentoDescricao, opts => opts.MapFrom(src => src.TipoEquipamentoDto.Descricao))
                .ForMember(dest => dest.SituacaoDescricao, opts => opts.MapFrom(src => src.SituacaoDto.Descricao))
                .ReverseMap();

            CreateMap<EquipamentoDTO, EditarEquipamentoModel>()
                .ForMember(dest => dest.IdFabricante, opts => opts.MapFrom(src => src.FabricanteDto.Id))
                .ForMember(dest => dest.IdTipoEquipamento, opts => opts.MapFrom(src => src.SituacaoDto.Id))
                .ForMember(dest => dest.IdSituacao, opts => opts.MapFrom(src => src.SituacaoDto.Id))
                .ReverseMap();
        }
    }
}
