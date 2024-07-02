using AutoMapper;
using LabOps.Application.DTO.DTO.TipoEquipamento;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceTipoEquipamento : IApplicationServiceTipoEquipamento
    {
        private readonly IServiceTipoEquipamento _serviceTipoEquipamento;
        private readonly IMapper _mapper;

        public ApplicationServiceTipoEquipamento(IServiceTipoEquipamento serviceTipoEquipamento, IMapper mapper)
        {
            _serviceTipoEquipamento = serviceTipoEquipamento;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TipoEquipamentoDTO>> BuscarTodosTiposDeEquipamentos()
        {
            var tipoEquipamentos = await _serviceTipoEquipamento.BuscarTodos();
            return _mapper.Map<IEnumerable<TipoEquipamentoDTO>>(tipoEquipamentos);
        }

        public void RegistraNovoTipoEquipamento(RegistroNovoTipoEquipamentoDTO registroNovo)
        {
            var entity = _mapper.Map<TipoEquipamento>(registroNovo);
            _serviceTipoEquipamento.Adicionar(entity);
        }
    }
}