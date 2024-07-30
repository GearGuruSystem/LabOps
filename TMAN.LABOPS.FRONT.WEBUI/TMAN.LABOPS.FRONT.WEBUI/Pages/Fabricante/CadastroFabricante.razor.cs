using Microsoft.AspNetCore.Components;
using MudBlazor;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Fabricante;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Mud.Pages.Fabricante
{
    public partial class CadastroFabricanteCode : ComponentBase
    {
        #region Properties

        public NewFabricanteDTO Model { get; set; } = new NewFabricanteDTO();

        public MudForm MudForm { get; set; }

        #endregion Properties

        #region Services

        [Inject]
        public IHandlerManufacturer Services { get; set; } = null!;

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
                    var result = await Services.RegisterManufacturer(Model);
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