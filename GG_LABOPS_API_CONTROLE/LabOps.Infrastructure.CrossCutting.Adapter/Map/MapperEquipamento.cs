using LabOps.Application.DTO.DTO;
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

        #region methods

        public Equipamento MapperToEntity(EquipamentoDTO equipamentoDTO)
        {
            Equipamento equipamento = new Equipamento()
            {
                
            };
            return equipamento;
        }


        public IEnumerable<EquipamentoDTO> MapperListaEquipamentos(IEnumerable<Equipamento> equipamentos)
        {
            foreach (var item in equipamentos)
            {
                EquipamentoDTO equipamentoDTO = new EquipamentoDTO
                {
                    
                };
                EquipamentoDTOs.Add(equipamentoDTO);
            }
            return EquipamentoDTOs;
        }

        public EquipamentoDTO MapperToDTO(Equipamento equipamento)
        {
            EquipamentoDTO equipamentoDTO = new EquipamentoDTO
            {

            };
            return equipamentoDTO;
        }
        #endregion
    }
}
