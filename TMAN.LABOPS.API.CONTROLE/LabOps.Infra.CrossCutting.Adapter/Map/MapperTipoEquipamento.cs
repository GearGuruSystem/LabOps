using LabOps.Application.DTO.DTO;
using LabOps.Application.DTO.DTO.TipoEquipamento;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0090 // Use 'new(...)'

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperTipoEquipamento : IMapperTipoEquipamento
    {
        private readonly List<TipoEquipamentoDTO> tipoEquipamentos = new List<TipoEquipamentoDTO>();

        public IEnumerable<TipoEquipamentoDTO> MapperListaTipoEquipamentos(IEnumerable<TipoEquipamento> tipoEquipamento)
        {
            foreach (var item in tipoEquipamento)
            {
                TipoEquipamentoDTO tipoEquipamentoDTO = new TipoEquipamentoDTO
                {
                    IDTipoEquipamento = item.Id,
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
                tipoEquipamentoDTO.UsuarioAtualizacao);
            return tipoEquipamento;
        }

        public TipoEquipamento MapperToEntity(RegistroNovoTipoEquipamentoDTO tipoEquipamentoDTO)
        {
            TipoEquipamento tipoEquipamento = new TipoEquipamento(
                tipoEquipamentoDTO.Descricao,
                tipoEquipamentoDTO.UsuarioAtualizcao);
            return tipoEquipamento;
        }

        public TipoEquipamentoDTO MapperToDTO(TipoEquipamento tipoEquipamento)
        {
            TipoEquipamentoDTO tipoEquipamentoDTO = new TipoEquipamentoDTO
            {
                IDTipoEquipamento = tipoEquipamento.Id,
                Descricao = tipoEquipamento.Descricao,
                UsuarioAtualizacao = tipoEquipamento.UsuarioAtualizacao,
                AtualizadoEm = tipoEquipamento.AtualizadoEm
            };
            return tipoEquipamentoDTO;
        }
    }
}