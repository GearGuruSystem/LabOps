using LabOps.Domain.Entities;

namespace LabOps.Domain.Core.Interfaces
{
    public interface IRepositorySituacao : IRepositoryBase<Situacao>
    {
        Task<IEnumerable<Situacao>> BuscarTodosComSituacaoAtiva();
    }
}