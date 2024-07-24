using AutoMapper;
using LabOps.Application.DTO.DTO.EquipamentoCaracteristica;
using LabOps.Domain.Entities;

namespace LabOps.Infra.CrossCutting.Adapter.Map
{
    public class MapperEquipamentoCaracteristica : Profile
    {
        public MapperEquipamentoCaracteristica()
        {
            CreateMap<EquipamentoCaracteristica, EquipamentoCaracteristicaDTO>()
                .ForMember(dest => dest.CaracteristicaValorDTO, opts => opts.MapFrom(src => src.CaracteristicaValor))
                .ForMember(dest => dest.CaracteristicaTipoDTO, opts => opts.MapFrom(src => src.CaracteristicaTipo))
                .ReverseMap();
        }
    }
}