using Microsoft.AspNetCore.Components;
using MudBlazor;
using Tman.LabOps.WebUI.Application.DTOs.Equipamento;
using Tman.LabOps.WebUI.Application.Interfaces;

namespace Tman.LabOps.WebUI.Pages.Equipamento
{
    public partial class IndexCode : ComponentBase
    {
        #region Proprieties

        public IEnumerable<ViewEquipamento> Equipamentos { get; set; }

        #endregion Proprieties

        #region Services

        [Inject]
        public IServiceEquipamento Service { get; set; } = null!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = null!;

        [Inject]
        public ISnackbar Snackbar { get; set; } = null!;

        #endregion Services

        public bool _loading;

        #region Metodos

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            //_loading = true;

            //try
            //{
            //    Equipamentos = await Service.BuscaTodosEquipamentos();
            //}
            //catch (Exception ex)
            //{
            //    Snackbar.Add(ex.Message, Severity.Error);
            //}
            //finally
            //{
            //    _loading = false;
            //}
        }
    }

    #endregion
}