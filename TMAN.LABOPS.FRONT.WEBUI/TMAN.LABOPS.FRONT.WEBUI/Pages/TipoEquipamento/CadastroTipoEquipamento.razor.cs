using Microsoft.AspNetCore.Components;
using MudBlazor;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.TiposEquipamentos;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Mud.Pages.TipoEquipamento
{
    public partial class CadastroTipoEquipamentoCode : ComponentBase
    {
        #region Proprieties

        public NewTipoEquipamentoDTO Model { get; set; } = new NewTipoEquipamentoDTO();

        public MudForm MudForm { get; set; }

        #endregion Proprieties

        #region Services

        [Inject]
        public IHandlerEquipmentType Service { get; set; } = null;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;

        [Inject]
        public ISnackbar Snackbar { get; set; } = null!;

        #endregion Services

        #region Metodos

        public async Task OnValidSubmitAsync()
        {
            if (MudForm.IsValid)
            {
                try
                {
                    var result = Service.RegisterEquipmentType(Model);
                    Snackbar.Add("Tipo de equipamento cadastrado com sucesso.", Severity.Success);
                    await Task.Delay(TimeSpan.FromSeconds(5));
                    NavigationManager.NavigateTo("/");
                }
                catch (Exception ex)
                {
                    Snackbar.Add(ex.Message, Severity.Error);
                }
            }
        }

        #endregion Metodos
    }
}