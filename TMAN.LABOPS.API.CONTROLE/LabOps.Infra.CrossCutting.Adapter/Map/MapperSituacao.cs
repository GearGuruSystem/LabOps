using AutoMapper;
using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Domain.Entities;

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperSituacao : Profile
    {
        public MapperSituacao()
        {
            CreateMap<Situacao, SituacaoDTO>().ReverseMap();
            CreateMap<Situacao, AdicionarSituacaoDTO>().ReverseMap();
        }
    }
}