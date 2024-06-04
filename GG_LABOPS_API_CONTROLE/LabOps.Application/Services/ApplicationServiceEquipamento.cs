using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.DTO.Requests;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceEquipamento : IApplicationServiceEquipamento
    {
        private readonly IServiceEquipamento _serviceEquipamento;
        private readonly IMapperEquipamento _mapperEquipamento;
        private readonly PagedRequest pagedRequest;
        private readonly Request request;
        

        public ApplicationServiceEquipamento(IServiceEquipamento ServiceCliente, IMapperEquipamento MapperEquipamento, 
            PagedRequest pagedRequest, Request request)
        {
            _serviceEquipamento = ServiceCliente;
            _mapperEquipamento = MapperEquipamento;
            this.pagedRequest = pagedRequest;
            this.request = request;
        }

        public async Task<IEnumerable<EquipamentoDTO>> BuscaTodosEquipamentos()
        {
            var objEquipamento = await _serviceEquipamento.BuscarTodos(pagedRequest.PageNumber, pagedRequest.PageSize);
            return _mapperEquipamento.MapperListaPaginaEquipamento(objEquipamento);
        }

        public async Task<EquipamentoDTO> BuscaEquipamentoPeloId(int id)
        {
            var objEquipamento = await _serviceEquipamento.BuscarPorId(id);
            return _mapperEquipamento.MapperToDTO(objEquipamento);
        }

        public void RegistraEquipamento(EquipamentoDTO obj)
        {
            var objEquipamento = _mapperEquipamento.MapperToEntity(obj);
            _serviceEquipamento.Adicionar(objEquipamento);
        }

        public void AtualizaEquipamento(EquipamentoDTO obj)
        {
            var objEquipamento = _mapperEquipamento.MapperToEntity(obj);
            _serviceEquipamento.Atualiza(objEquipamento);
        }

        public void RemoveEquipamento(EquipamentoDTO obj)
        {
            var objEquipamento = _mapperEquipamento.MapperToEntity(obj);
            _serviceEquipamento.Remove(objEquipamento);
        }
    }
}