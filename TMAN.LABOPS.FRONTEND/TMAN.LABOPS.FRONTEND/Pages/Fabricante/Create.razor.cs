using LabOps.Application.DTOs.Fabricante;
using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace TMAN.LABOPS.FRONTEND.Pages.Fabricante
{
    public partial class CriaFabricantePage : ComponentBase
    {
        #region Properties

        public bool IsBusy { get; set; } = false;
        public CriarNovo InputModel { get; set; } = new();

        #endregion

        #region Services

        [Inject]
        public IServicesFabricante Services { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        #endregion

        #region Metodos

        public async Task OnValidSubmitAsync()
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
