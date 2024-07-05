using LabOps.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabOps.WebUI.Controllers
{
    public class EquipamentoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dadosFicticios = new List<EquipamentosModel>
            {
                new() {
                    Id = 1,
                    Nome = "XENTRY",
                    Inventario = "554010020345",
                    Hostname = "M154DS10020345",
                    FabricanteNome = "PANASONIC",
                    TipoEquipamentoDescricao = "TABLET",
                    SituacaoDescricao = "ATIVO"
                },
                new() {
                    Id = 2,
                    Nome = "XDXD9203",
                    Inventario = "J0050505",
                    Hostname = "M154DS10050505",
                    FabricanteNome = "DELL",
                    TipoEquipamentoDescricao = "MONITOR",
                    SituacaoDescricao = "RESERVADO"
                },
                new() {
                    Id = 3,
                    Nome = "OPTIPLEX 6666",
                    Inventario = "J0022222",
                    Hostname = "M154DSX0022222",
                    FabricanteNome = "DELL",
                    TipoEquipamentoDescricao = "DESKTOP",
                    SituacaoDescricao = "ATIVO"
                }
            };
            return View(dadosFicticios);
        }
    }
}
