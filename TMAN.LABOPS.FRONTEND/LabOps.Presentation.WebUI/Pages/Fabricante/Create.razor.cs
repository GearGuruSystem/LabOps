using LabOps.Application.DTOs.Fabricante;
using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace LabOps.Presentation.WebUI.Pages.Fabricante
{
    public partial class CriaFabricantePage : ComponentBase
    {
        #region Properties

        public bool IsBusy { get; set; } = false;
        public CriarNovo InputModel { get; set; } = new();

        #endregion

        #region Services

        [Inject]
        public IServicesFabricante Services { get; set; } = null!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;

        [Inject]
        public ISnackbar Snackbar { get; set; } = null!;

        #endregion

        #region Metodos

        public async Task Banana()
        {
            IsBusy = true;

            try
            {
                var result = await Services.RegistraFabricante(InputModel);
                if (result != null)
                {
                    Snackbar.Add("Usuario cadastrado com sucesso", Severity.Success);
                    NavigationManager.NavigateTo("/Equipamentos");
                }
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                Snackbar.Add(ex.Message, Severity.Error);
            }
            finally
            {
                IsBusy = false;
            }
        }

        #endregion
    }
}
