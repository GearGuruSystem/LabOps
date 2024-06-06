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
        readonly List<EquipamentoDTO> EquipamentoDTOs = new List<EquipamentoDTO>();
        #endregion

        #region Metodos
        public Equipamento MapperToEntity(EquipamentoDTO equipamentoDTO)
        {
            Equipamento equipamento = new Equipamento(
                equipamentoDTO.Nome,
                equipamentoDTO.IDSituacao,
                equipamentoDTO.IDTipoEquipamento,
                equipamentoDTO.IDFabricante,
                equipamentoDTO.IDLaboratorio,
                equipamentoDTO.UsuarioInsercao,
                equipamentoDTO.AtualizadoEm);
            return equipamento;
        }


        public IEnumerable<EquipamentoDTO> MapperListaEquipamentos(IEnumerable<Equipamento> equipamentos)
        {
            foreach (var item in equipamentos)
            {
                EquipamentoDTO equipamentoDTO = new EquipamentoDTO(
                    item.Nome,
                    item.IDSituacao,
                    item.IDTipoEquipamento,
                    item.IDFabricante,
                    item.IDLaboratorio,
                    item.UsuarioInsercao,
                    item.AtualizadoEm);

                EquipamentoDTOs.Add(equipamentoDTO);
            }
            return EquipamentoDTOs;
        }

        public EquipamentoDTO MapperToDTO(Equipamento equipamento)
        {
            EquipamentoDTO equipamentoDTO = new EquipamentoDTO(
                equipamento.Nome,
                equipamento.IDSituacao,
                equipamento.IDTipoEquipamento,
                equipamento.IDFabricante,
                equipamento.IDLaboratorio,
                equipamento.UsuarioInsercao,
                equipamento.AtualizadoEm);
            return equipamentoDTO;
        }
        #endregion
    }
}
