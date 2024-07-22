using AutoMapper;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Fabricantes;
using LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle;
using LabOps.WebUI.Models.Fabricantes;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebUI.Controllers
{
    public class FabricanteController : Controller
    {
        private readonly IServicesFabricante _services;
        private readonly IMapper _mapper;

        public FabricanteController(IServicesFabricante services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
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
        public async Task<IActionResult> CadastroFabricante(CadastroFabricanteModel criarNovoF)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _services.CadastraFabricante(_mapper.Map<CriarNovoFDTO>(criarNovoF));
                    return RedirectToAction(nameof(HomeController.Index));
                }
                catch (Exception ex)
                {
                    TempData["MsgError"] = $"Ops, houve um erro. Detalhe do erro: {ex.Message}";
                    return RedirectToAction(nameof(Index));
                }
            }
            TempData["MsgError"] = $"Verifique se os dados estão corretos";
            return RedirectToAction(nameof(CadastroFabricante));
        }

        [HttpGet]
        public IActionResult AtualizarFabricante()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AtualizarFabricante(CriarNovoFDTO criarNovoF)
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
            TempData["MsgError"] = $"Verifique se os dados estão corretos";
            return RedirectToAction(nameof(CadastroFabricante));
        }
    }
}
