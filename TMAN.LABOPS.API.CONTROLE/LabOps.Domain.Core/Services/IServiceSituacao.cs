using LabOps.Domain.Entities;

namespace LabOps.Domain.Core.Services
{
    public interface IServiceSituacao : IServiceBase<Situacao>
    {
        Task<IEnumerable<Situacao>> BuscarSituacoesAtivas();
    }
}