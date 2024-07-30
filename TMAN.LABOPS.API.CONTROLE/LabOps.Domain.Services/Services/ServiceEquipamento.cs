using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.DTO.Response;
using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Domain.Services.Services
{
    public class ServiceEquipamento : ServiceBase<Equipamento>, IServiceEquipamento
    {
        public readonly IRepositoryEquipamento repositoryEquipamento;

        public ServiceEquipamento(IRepositoryEquipamento repositoryEquipamento)
            : base(repositoryEquipamento)
        {
            this.repositoryEquipamento = repositoryEquipamento;
        }

        public new async Task<IEnumerable<Equipamento>> BuscarTodos()
        {
            return await repositoryEquipamento.BuscarTodos();
        }

        public async Task<Equipamento> BuscarComRetornoId(int id)
        {
            return await repositoryEquipamento.BuscarComRetornoId(id);
        }

        public new async Task<BuscarEquipamentos> BuscarPorId(int id)
        {
            return await repositoryEquipamento.BuscarPorId(id);
        }

        public async Task<IEnumerable<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize)
        {
            var data = await repositoryEquipamento.BuscarTodosPorPagina(pageNumber, pageSize);
            return data;
        }
    }
}