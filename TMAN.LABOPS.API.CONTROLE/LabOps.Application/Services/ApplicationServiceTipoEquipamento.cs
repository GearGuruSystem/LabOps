using AutoMapper;
using LabOps.Application.DTO.DTO.TipoEquipamento;
using LabOps.Application.DTO.Response;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290

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

        public async Task<Response<IEnumerable<TipoEquipamentoDTO>>> BuscarTodosTiposDeEquipamentos()
        {
            var data = _mapper.Map<IEnumerable<TipoEquipamentoDTO>>(await _serviceTipoEquipamento.BuscarTodos());
            return new Response<IEnumerable<TipoEquipamentoDTO>>(data, data.Count(), "Ok");
        }

        public void RegistraNovoTipoEquipamento(RegistroNovoTipoEquipamentoDTO registroNovo)
        {
            var entity = _mapper.Map<TipoEquipamento>(registroNovo);
            _serviceTipoEquipamento.Adicionar(entity);
        }
    }
}