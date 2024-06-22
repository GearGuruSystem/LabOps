using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0090 // Use 'new(...)'
#pragma warning disable IDE0028 // Simplify collection initialization

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperSituacao : IMapperSituacao
    {
        private readonly List<SituacaoDTO> SituacoesDTOs = new List<SituacaoDTO>();

        public IEnumerable<SituacaoDTO> MapperListaSituacao(IEnumerable<Situacao> situacoes)
        {
            foreach (var item in situacoes)
            {
                SituacaoDTO situacaoDTO = new SituacaoDTO
                {
                    IDSituacao = item.IDSituacao,
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
            SituacaoDTO situacaoDTO = new SituacaoDTO
            {
                IDSituacao = situacao.IDSituacao,
                Descricao = situacao.Descricao,
                UsuarioAtualizacao = situacao.UsuarioAtualizacao,
                AtualizadoEm = situacao.AtualizadoEm
            };

            return situacaoDTO;
        }

        public Situacao MapperToEntity(SituacaoDTO situacaoDTO)
        {
            Situacao situacao = new Situacao(
                situacaoDTO.IDSituacao,
                situacaoDTO.Descricao,
                situacaoDTO.UsuarioAtualizacao,
                situacaoDTO.AtualizadoEm);
            return situacao;
        }

        public Situacao MapperToEntity(AdicionarSituacaoDTO situacaoDTO)
        {
            Situacao situacao = new Situacao(situacaoDTO.Descricao,
                situacaoDTO.UsuarioAtualizacao,
                situacaoDTO.AtualizadoEm);
            return situacao;
        }
    }
}