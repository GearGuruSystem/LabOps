using LabOps.Application.DTOs.Fabricantes;
using LabOps.Application.Interfaces.ApiControle;
using Microsoft.AspNetCore.Mvc;

namespace LabOps.WebUI.Controllers
{
    public class FabricanteController : Controller
    {
        private readonly IServicesFabricante _services;

        public FabricanteController(IServicesFabricante services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastroFabricante()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroFabricante(CriarNovo criarNovoF)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _services.CadastraFabricante(criarNovoF);
                    return RedirectToAction(nameof(HomeController.Index));
                }
                catch (Exception ex)
                {
                    TempData["MsgError"] = $"Ops, houve um erro. Detalhe do erro: {ex.Message}";
                    return RedirectToAction(nameof(Index));
                }
            }
            TempData["MsgError"] = $"Ocorreu um problema";
            return RedirectToAction(nameof(CadastroFabricante));
        }

        [HttpGet]
        public IActionResult AtualizaFabricante()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AtualizaFabricante(CriarNovo criarNovoF)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _services.CadastraFabricante(criarNovoF);
                    return RedirectToAction(nameof(HomeController.Index));
                }
                catch (Exception ex)
                {
                    TempData["MsgError"] = $"Ops, houve um erro. Detalhe do erro: {ex.Message}";
                    return RedirectToAction(nameof(Index));
                }
            }
            TempData["MsgError"] = $"Ocorreu um problema";
            return RedirectToAction(nameof(CadastroFabricante));
        }
    }
}
