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

        public Equipamento MapperToEntity(EquipamentoDTO equipamentoDTO)
        {
            var equipamento = new Equipamento(
                equipamentoDTO.Nome,
                equipamentoDTO.IDSituacao,
                equipamentoDTO.IDTipoEquipamento,
                equipamentoDTO.IDFabricante,
                equipamentoDTO.IDLaboratorio,
                equipamentoDTO.UsuarioInsercao);
            return equipamento;
        }

        public IEnumerable<EquipamentoDTO> MapperListaEquipamentos(IEnumerable<Equipamento> equipamentos)
        {
            foreach (var item in equipamentos)
            {
                var equipamentoDTO = new EquipamentoDTO
                {
                    Nome = item.Nome,
                    IDSituacao = item.IDSituacao,
                    IDTipoEquipamento = item.IDTipoEquipamento,
                    IDFabricante = item.IDFabricante,
                    IDLaboratorio = item.IDLaboratorio,
                    UsuarioInsercao = item.UsuarioInsercao,
                    AtualizadoEm = item.AtualizadoEm
                };
                EquipamentoDTOs.Add(equipamentoDTO);
            }
            return EquipamentoDTOs;
        }
        public EquipamentoDTO MapperToDTO(Equipamento equipamento)
        {
            var equipamentoDTO = new EquipamentoDTO
            {
                Nome = equipamento.Nome,
                IDSituacao = equipamento.IDSituacao,
                IDTipoEquipamento = equipamento.IDTipoEquipamento,
                IDFabricante = equipamento.IDFabricante,
                IDLaboratorio = equipamento.IDLaboratorio,
                UsuarioInsercao = equipamento.UsuarioInsercao,
                AtualizadoEm = equipamento.AtualizadoEm
            };
            return equipamentoDTO;
        }
    }
}