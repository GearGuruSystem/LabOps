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
                .ForMember(equipDto => equipDto.FabricanteDto, opt => opt.MapFrom(equip => equip.Fabricante))
                .ForMember(equipDto => equipDto.SituacaoDto, opt => opt.MapFrom(equip => equip.Situacao))
                .ForMember(equipDto => equipDto.TipoEquipamentoDto, opt => opt.MapFrom(equip => equip.TipoEquipamento))
                .ReverseMap();
            CreateMap<Equipamento, CriarNovo>().ReverseMap();
            CreateMap<Equipamento, BuscarEquipamentos>().ReverseMap();
        }
    }
}