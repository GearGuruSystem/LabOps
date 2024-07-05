using Microsoft.AspNetCore.Components;
using MudBlazor;
using Tman.LabOps.WebUI.Application.DTOs.TipoEquipamento;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Pages.TipoEquipamento
{
    public partial class CadastroTipoEquipamentoCode : ComponentBase
    {
        #region Proprieties

        public CriarNovoTE Model { get; set; } = new CriarNovoTE();

        public MudForm MudForm { get; set; }

        #endregion Proprieties

        #region Services

        [Inject]
        public IServiceTipoEquipamento Service { get; set; } = null;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;

        [Inject]
        public ISnackbar Snackbar { get; set; } = null!;

        #endregion Services

        #region Metodos

        public async Task OnValidSubmitAsync()
        {
            if(MudForm.IsValid)
            {
                try
                {
                    var result = Service.RegistraTipoEquipamento(Model);
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