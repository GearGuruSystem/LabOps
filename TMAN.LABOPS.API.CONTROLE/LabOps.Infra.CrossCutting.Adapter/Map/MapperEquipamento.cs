using AutoMapper;
using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperEquipamento : Profile
    {
        public MapperEquipamento()
        {
            CreateMap<Equipamento, EquipamentoDTO>()
                .ForMember(dest => dest.FabricanteDto, opt => opt.MapFrom(src => src.Fabricante))
                .ForMember(dest => dest.SituacaoDto, opt => opt.MapFrom(src => src.Situacao))
                .ForMember(dest => dest.TipoEquipamentoDto, opt => opt.MapFrom(src => src.TipoEquipamento))
                .ReverseMap();

            CreateMap<Equipamento, CriarNovo>().ReverseMap();
            CreateMap<Equipamento, BuscarEquipamentos>().ReverseMap();
        }
    }
}