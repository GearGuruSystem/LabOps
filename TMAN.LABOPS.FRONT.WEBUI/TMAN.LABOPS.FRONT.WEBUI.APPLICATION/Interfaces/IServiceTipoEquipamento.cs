using Tman.LabOps.WebUI.Application.DTOs.TipoEquipamento;
using Tman.LabOps.WebUI.Application.Entities;

namespace Tman.LabOps.WebUI.Application.Interfaces
{
    public interface IServiceTipoEquipamento
    {
        Task<IEnumerable<TipoEquipamento>> BuscaTodosTipoEquipamento();
        Task<TipoEquipamento> BuscaTipoEquipamentoPeloId(int id);
        Task<TipoEquipamento> RegistraTipoEquipamento(CriarNovoTE tipoEquipamento);
        void AtualizarTipoEquipamento(TipoEquipamento tipoEquipamento);
        void RemoveTipoEquipamento(TipoEquipamento tipoEquipamento);
    }
}