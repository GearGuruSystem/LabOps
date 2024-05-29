using GG_LabOps_Domain.Interfaces;
using GG_LabOps_WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GG_LabOps_WebUI.Controllers
{
    [Route("Equipamento")]
    public class EquipamentoController : Controller
    {
        private readonly IEquipamentoServices _equipamentoService;

        public EquipamentoController(IEquipamentoServices equipamentoService)
        {
            _equipamentoService = equipamentoService;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var equipamentos = await _equipamentoService.BuscarTodos();
            EquipamentoModel model = new EquipamentoModel
            {
                Nome = equipamentos.Nome,
                IDSituacao = equipamentos.IDSituacao,
                IDEquipamento = equipamentos.IDEquipamento,
                IDFabricante = equipamentos.IDFabricante
            };
            return View(model);
        }
    }
}
