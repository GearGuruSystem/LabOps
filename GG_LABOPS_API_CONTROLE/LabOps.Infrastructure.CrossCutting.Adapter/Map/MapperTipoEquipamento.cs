using LabOps.Application.DTO.DTO;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0090 // Use 'new(...)'

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperTipoEquipamento : IMapperTipoEquipamento
    {
        private readonly List<TipoEquipamentoDTO> tipoEquipamentos;

        public IEnumerable<TipoEquipamentoDTO> MapperListaTipoEquipamentos(IEnumerable<TipoEquipamento> tipoEquipamento)
        {
            foreach (var item in tipoEquipamento)
            {
                TipoEquipamentoDTO tipoEquipamentoDTO = new TipoEquipamentoDTO
                {
                    IDTipoEquipamento = item.IDTipoEquipamento,
                    Descricao = item.Descricao,
                    UsuarioAtualizacao = item.UsuarioAtualizacao,
                    AtualizadoEm = item.AtualizadoEm
                };
                tipoEquipamentos.Add(tipoEquipamentoDTO);
            }
            return tipoEquipamentos;
        }

        public TipoEquipamento MapperToEntity(TipoEquipamentoDTO tipoEquipamentoDTO)
        {
            TipoEquipamento tipoEquipamento = new TipoEquipamento(
                tipoEquipamentoDTO.IDTipoEquipamento,
                tipoEquipamentoDTO.Descricao,
                tipoEquipamentoDTO.UsuarioAtualizacao,
                tipoEquipamentoDTO.AtualizadoEm);
            return tipoEquipamento;
        }

        public TipoEquipamentoDTO MapperToDTO(TipoEquipamento tipoEquipamento)
        {
            TipoEquipamentoDTO tipoEquipamentoDTO = new TipoEquipamentoDTO
            {
                IDTipoEquipamento = tipoEquipamento.IDTipoEquipamento,
                Descricao = tipoEquipamento.Descricao,
                UsuarioAtualizacao = tipoEquipamento.UsuarioAtualizacao,
                AtualizadoEm = tipoEquipamento.AtualizadoEm
            };
            return tipoEquipamentoDTO;
        }
    }
}
