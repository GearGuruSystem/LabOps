using AutoMapper;
using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.DTO.Response;
using LabOps.Domain.Entities;

namespace LabOps.Infra.CrossCutting.Adapter.Map
{
    public class MapperReponsePaged : Profile
    {
        public MapperReponsePaged()
        {
            CreateMap<ResponsePaged<EquipamentoDTO>, ResponsePaged<Equipamento>>()
                .ForMember(dest => dest.Data, opts => opts.MapFrom(src => src.Data))
                .ReverseMap();
        }
    }
}
