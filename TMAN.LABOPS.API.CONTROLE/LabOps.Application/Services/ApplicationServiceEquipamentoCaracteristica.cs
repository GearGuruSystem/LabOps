using AutoMapper;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Services
{
    public class ApplicationServiceEquipamentoCaracteristica : IApplicationServiceEquipamentoCaracteristica
    {
        private readonly IServiceEquipamentoCaracteristica _service;
        private readonly IMapper _mapper;

        public ApplicationServiceEquipamentoCaracteristica(IServiceEquipamentoCaracteristica service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
