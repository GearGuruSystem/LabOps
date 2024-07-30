using Microsoft.AspNetCore.Components;
using MudBlazor;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Equipamento;
using Tman.LabOps.WebUI.Application.Handlers;

namespace Tman.LabOps.WebUI.Mud.Pages.Equipamento
{
    public partial class IndexCode : ComponentBase
    {
        #region Proprieties

        public IEnumerable<EquipamentoDTO> Equipamentos { get; set; }

        #endregion Proprieties

        #region Services

        [Inject]
        public HandlersEquipment Service { get; set; } = null!;

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