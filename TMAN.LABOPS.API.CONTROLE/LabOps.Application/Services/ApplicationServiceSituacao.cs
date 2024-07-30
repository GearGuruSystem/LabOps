using AutoMapper;
using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Application.DTO.Response;
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

        public async Task<Response<IEnumerable<SituacaoDTO>>> BuscarTodasSituacoes()
        {
            var data = _mapper.Map<IEnumerable<SituacaoDTO>>(await _serviceSituacao.BuscarTodos());
            return new Response<IEnumerable<SituacaoDTO>> (data, data.Count(), "Ok");
        }

        public async Task<Response<IEnumerable<SituacaoDTO>>> BuscaTodasSituacaoAtiva()
        {
            var data = _mapper.Map<IEnumerable<SituacaoDTO>>(await _serviceSituacao.BuscarSituacoesAtivas());
            return new Response<IEnumerable<SituacaoDTO>>(data, data.Count(), "Ok");
        }

        public void CadastraSituacao(AdicionarSituacaoDTO situacaoDTO)
        {
            var objSituacao = _mapper.Map<Situacao>(situacaoDTO);
            _serviceSituacao.Adicionar(objSituacao);
        }
    }
}