using AutoMapper;
using LabOps.Application.DTO.DTO.Laboratorio;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperLaboratorio : Profile
    {
        public MapperLaboratorio()
        {
            CreateMap<Laboratorio, LaboratorioDTO>().ReverseMap();
        }
    }
}