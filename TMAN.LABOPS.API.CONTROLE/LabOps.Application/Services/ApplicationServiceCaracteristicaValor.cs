using AutoMapper;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Services
{
    public class ApplicationServiceCaracteristicaValor : IApplicationServiceCaracteristicaValor
    {
        private readonly IServiceCaracteristicaValor _service;
        private readonly IMapper _mapper;

        public ApplicationServiceCaracteristicaValor(IServiceCaracteristicaValor service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
    }
}
