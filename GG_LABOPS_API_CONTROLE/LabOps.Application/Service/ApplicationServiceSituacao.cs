﻿using LabOps.Application.DTO.DTO;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;
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
            var objSituacao = await serviceSituacao.BuscarTodos();
            return mapperSituacao.MapperListaFabricantes(objSituacao);
        }

        public async Task<IEnumerable<SituacaoDTO>> BuscarSituacaoPorParametro(Situacao situacaoDTO)
        {
            var objSituacao = await serviceSituacao.BuscarPorParametro(situacaoDTO);
            return mapperSituacao.MapperListaFabricantes(objSituacao);
        }

        public void CadastraSituacao(SituacaoDTO situacaoDTO)
        {
            var objSituacao = mapperSituacao.MapperToEntity(situacaoDTO);
            serviceSituacao.Adicionar(objSituacao);
        }
    }
}
