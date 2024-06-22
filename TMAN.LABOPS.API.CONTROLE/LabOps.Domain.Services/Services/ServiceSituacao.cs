using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Domain.Services.Services
{
    public class ServiceSituacao : ServiceBase<Situacao>, IServiceSituacao
    {
        public readonly IRepositorySituacao repositorySituacao;

        public ServiceSituacao(IRepositorySituacao repositorySituacao)
            : base(repositorySituacao)
        {
            this.repositorySituacao = repositorySituacao;
        }

        public async Task<IEnumerable<Situacao>> BuscarSituacoesAtivas()
        {
            return await repositorySituacao.BuscarTodosComSituacaoAtiva();
        }
    }
}