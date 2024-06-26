using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0028 // Simplify collection initialization

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperSituacao : IMapperSituacao
    {
        private readonly List<SituacaoDTO> SituacoesDTOs = new();

        public IEnumerable<SituacaoDTO> MapperListaSituacao(IEnumerable<Situacao> situacoes)
        {
            foreach (var item in situacoes)
            {
                var situacaoDTO = new SituacaoDTO
                {
                    IDSituacao = item.Id,
                    Descricao = item.Descricao,
                    UsuarioAtualizacao = item.UsuarioAtualizacao,
                    AtualizadoEm = item.AtualizadoEm
                };
                SituacoesDTOs.Add(situacaoDTO);
            }
            return SituacoesDTOs;
        }

        public SituacaoDTO MapperToDTO(Situacao situacao)
        {
            var situacaoDTO = new SituacaoDTO
            {
                IDSituacao = situacao.Id,
                Descricao = situacao.Descricao,
                UsuarioAtualizacao = situacao.UsuarioAtualizacao,
                AtualizadoEm = situacao.AtualizadoEm
            };
            return situacaoDTO;
        }

        public Situacao MapperToEntity(SituacaoDTO situacaoDTO)
        {
            var situacao = new Situacao(
                situacaoDTO.IDSituacao,
                situacaoDTO.Descricao,
                situacaoDTO.UsuarioAtualizacao);
            return situacao;
        }

        public Situacao MapperToEntity(AdicionarSituacaoDTO situacaoDTO)
        {
            var situacao = new Situacao(situacaoDTO.Descricao,
                situacaoDTO.UsuarioAtualizacao);
            return situacao;
        }
    }
}