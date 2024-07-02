using AutoMapper;
using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceSituacao : IApplicationServiceSituacao
    {
        private readonly IServiceSituacao _serviceSituacao;
        private readonly IMapper _mapper;

        public ApplicationServiceSituacao(IServiceSituacao serviceSituacao, IMapper mapper)
        {
            _serviceSituacao = serviceSituacao;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SituacaoDTO>> BuscaTodasSituacaoAtiva()
        {
            var objSituacao = await _serviceSituacao.BuscarSituacoesAtivas();
            return _mapper.Map<IEnumerable<SituacaoDTO>>(objSituacao);
        }

        public void CadastraSituacao(AdicionarSituacaoDTO situacaoDTO)
        {
            var objSituacao = _mapper.Map<Situacao>(situacaoDTO);
            _serviceSituacao.Adicionar(objSituacao);
        }
    }
}