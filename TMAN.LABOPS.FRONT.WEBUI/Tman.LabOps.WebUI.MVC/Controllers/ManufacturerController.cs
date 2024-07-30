using Microsoft.AspNetCore.Mvc;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Fabricante;
using Tman.LabOps.WebUI.Application.Interfaces;
using Tman.LabOps.WebUI.MVC.Controllers;

#pragma warning disable IDE0290

namespace LabOps.WebUI.Controllers
{
    [Route("Fabricante")]
    public class ManufacturerController : Controller
    {
        private readonly IHandlerManufacturer _handler;

        public ManufacturerController(IHandlerManufacturer handler)
        {
            _handler = handler;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Cadastro")]
        public IActionResult RegisterManufacturer()
        {
            return View();
        }

        [HttpPost("Cadastro")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterManufacturer(NewFabricanteDTO newManufacturer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _handler.RegisterManufacturer(newManufacturer);
                    return RedirectToAction(nameof(HomeController.Index));
                }
                catch (Exception ex)
                {
                    TempData["MsgError"] = $"Ops, houve um erro. Detalhe do erro: {ex.Message}";
                    return RedirectToAction(nameof(Index));
                }
            }
            TempData["MsgError"] = $"Verifique se os dados estão corretos";
            return RedirectToAction(nameof(RegisterManufacturer));
        }

        [HttpGet("Atualizar")]
        public IActionResult UpdateManufacturer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateManufacturer(EditFabricanteDTO editManufacturer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _handler.UpdateManufacturer(editManufacturer);
                    return RedirectToAction(nameof(HomeController.Index));
                }
                catch (Exception ex)
                {
                    TempData["MsgError"] = $"Ops, houve um erro. Detalhe do erro: {ex.Message}";
                    return RedirectToAction(nameof(Index));
                }
            }
            TempData["MsgError"] = $"Verifique se os dados estão corretos";
            return RedirectToAction(nameof(RegisterManufacturer));
        }
    }
}
