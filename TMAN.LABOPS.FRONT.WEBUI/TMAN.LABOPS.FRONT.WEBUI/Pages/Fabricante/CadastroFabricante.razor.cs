using Microsoft.AspNetCore.Components;
using MudBlazor;
using Tman.LabOps.WebUI.Application.DTOs.Fabricante;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Pages.Fabricante
{
    public partial class CadastroFabricanteCode : ComponentBase
    {
        #region Properties

        public CriarNovoF Model { get; set; } = new CriarNovoF();

        public MudForm MudForm { get; set; }

        #endregion Properties

        #region Services

        [Inject]
        public IServiceFabricante Services { get; set; } = null!;

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
                    var result = await Services.RegistraFabricante(Model);
                    Snackbar.Add("Usuario cadastrado com sucesso", Severity.Success);
                    await Task.Delay(TimeSpan.FromSeconds(5));
                    NavigationManager.NavigateTo("/Equipamentos");
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