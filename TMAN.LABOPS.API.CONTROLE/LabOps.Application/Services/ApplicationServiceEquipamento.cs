using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceEquipamento : IApplicationServiceEquipamento
    {
        private readonly IServiceEquipamento serviceEquipamento;
        private readonly IMapperEquipamento mapperEquipamento;

        public ApplicationServiceEquipamento(IServiceEquipamento serviceEquipamento, IMapperEquipamento mapperEquipamento)
        {
            this.serviceEquipamento = serviceEquipamento;
            this.mapperEquipamento = mapperEquipamento;
        }

        public async Task<IEnumerable<EquipamentoDTO>> BuscaTodosEquipamentos()
        {
            var objEquipamento = await serviceEquipamento.BuscarTodos();
            return mapperEquipamento.MapperListaEquipamentos(objEquipamento);
        }

        public async Task<IEnumerable<EquipamentoDTO>> BuscaTodosPorPagina(int pageNumber, int pageSize)
        {
            var objEquipamento = await serviceEquipamento.BuscarTodosPorPagina(pageNumber, pageSize);
            return mapperEquipamento.MapperListaEquipamentos(objEquipamento);
        }

        public async Task<EquipamentoDTO> BuscaEquipamentoPeloId(int id)
        {
            var objEquipamento = await serviceEquipamento.BuscarPorId(id);
            return mapperEquipamento.MapperToDTO(objEquipamento);
        }

        public void RegistraEquipamento(EquipamentoDTO obj)
        {
            var objEquipamento = mapperEquipamento.MapperToEntity(obj);
            serviceEquipamento.Adicionar(objEquipamento);
        }

        public void AtualizaEquipamento(EquipamentoDTO obj)
        {
            var objEquipamento = mapperEquipamento.MapperToEntity(obj);
            serviceEquipamento.Atualizar(objEquipamento);
        }

        public void RemoveEquipamento(EquipamentoDTO obj)
        {
            var objEquipamento = mapperEquipamento.MapperToEntity(obj);
            serviceEquipamento.Remover(objEquipamento);
        }
    }
}