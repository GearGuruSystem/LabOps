using AutoMapper;
using LabOps.Application.DTO.DTO.CaracteristicaValor;
using LabOps.Domain.Entities;

namespace LabOps.Infra.CrossCutting.Adapter.Map
{
    public class MapperCaracteristicaValor : Profile
    {
        public MapperCaracteristicaValor()
        {
            CreateMap<CaracteristicaValor, CaracteristicaValorDTO>().ReverseMap();
        }
    }
}
