using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceSituacao : IApplicationServiceSituacao
    {
        private readonly IServiceSituacao serviceSituacao;
        private readonly IMapperSituacao mapperSituacao;

        public ApplicationServiceSituacao(IServiceSituacao serviceSituacao, IMapperSituacao mapperSituacao)
        {
            this.serviceSituacao = serviceSituacao;
            this.mapperSituacao = mapperSituacao;
        }

        public async Task<IEnumerable<SituacaoDTO>> BuscaTodasSituacaoAtiva()
        {
            var objSituacao = await serviceSituacao.BuscarSituacoesAtivas();
            return mapperSituacao.MapperListaSituacao(objSituacao);
        }

        public void CadastraSituacao(AdicionarSituacaoDTO situacaoDTO)
        {
            var objSituacao = mapperSituacao.MapperToEntity(situacaoDTO);
            serviceSituacao.Adicionar(objSituacao);
        }
    }
}