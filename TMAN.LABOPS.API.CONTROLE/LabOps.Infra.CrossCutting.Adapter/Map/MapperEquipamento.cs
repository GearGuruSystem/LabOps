using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0090 // Use 'new(...)'
#pragma warning disable IDE0028 // Simplify collection initialization

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperEquipamento : IMapperEquipamento
    {
        #region properties

        private readonly List<EquipamentoDTO> EquipamentoDTOs = new List<EquipamentoDTO>();

        #endregion properties

        public IEnumerable<EquipamentoDTO> MapperListaEquipamentos(IEnumerable<Equipamento> equipamentos)
        {
            foreach (var item in equipamentos)
            {
                var equipamentoDTO = new EquipamentoDTO
                {
                    Nome = item.Nome,
                    Hostname = item.Hostname,
                    Inventario = item.Inventario,
                    SerialNumber = item.SerialNumber,
                    IDSituacao = item.IdSituacao,
                    IDTipoEquipamento = item.IdTipoEquipamento,
                    IDFabricante = item.IdFabricante,
                    UsuarioInsercao = item.UsuarioInsercao,
                    AtualizadoEm = item.AtualizadoEm
                };
                EquipamentoDTOs.Add(equipamentoDTO);
            }
            return EquipamentoDTOs;
        }

        public Equipamento MapperToEntity(EquipamentoDTO equipamentoDTO)
        {
            var equipamento = new Equipamento(
                equipamentoDTO.Nome,
                equipamentoDTO.Hostname,
                equipamentoDTO.Inventario,
                equipamentoDTO.SerialNumber,
                equipamentoDTO.IDSituacao,
                equipamentoDTO.IDTipoEquipamento,
                equipamentoDTO.IDFabricante,
                equipamentoDTO.UsuarioInsercao);
            return equipamento;
        }

        public EquipamentoDTO MapperToDTO(Equipamento equipamento)
        {
            var equipamentoDTO = new EquipamentoDTO
            {
                Nome = equipamento.Nome,
                IDSituacao = equipamento.IdSituacao,
                IDTipoEquipamento = equipamento.IdTipoEquipamento,
                IDFabricante = equipamento.IdFabricante,
                UsuarioInsercao = equipamento.UsuarioInsercao,
                AtualizadoEm = equipamento.AtualizadoEm
            };
            return equipamentoDTO;
        }
    }
}