using AutoMapper;
using LabOps.Application.DTO.DTO.TipoEquipamento;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperTipoEquipamento : Profile
    {
        public MapperTipoEquipamento()
        {
            CreateMap<TipoEquipamento, TipoEquipamentoDTO>().ReverseMap();
            CreateMap<TipoEquipamento, RegistroNovoTipoEquipamentoDTO>().ReverseMap();
        }
    }
}