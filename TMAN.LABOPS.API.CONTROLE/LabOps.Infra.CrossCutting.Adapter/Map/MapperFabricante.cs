using AutoMapper;
using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperFabricante : Profile
    {
        public MapperFabricante()
        {
            CreateMap<Fabricante, FabricanteDTO>().ReverseMap();
            CreateMap<Fabricante, CriarNovoFabricanteDTO>().ReverseMap();
            CreateMap<Fabricante, AtualizarFabricanteDTO>().ReverseMap();
        }
    }
}