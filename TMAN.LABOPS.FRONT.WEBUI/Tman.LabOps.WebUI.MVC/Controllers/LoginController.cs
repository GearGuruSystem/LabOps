using Microsoft.AspNetCore.Mvc;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Usuarios;

#pragma warning disable IDE0290 // Use primary constructor

namespace Tman.LabOps.WebUI.MVC.Controllers
{
    //ToDo: Falta terminar API Auth e configurar controller para login
    public class LoginController : Controller
    {
        public LoginController()
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UsuarioLoginDTO login)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    return RedirectToAction(nameof(HomeController.Index));
                }
                catch (Exception ex)
                {
                    TempData["MsgError"] = $"Ops, houve um erro. Detalhe do erro: {ex.Message}";
                    return RedirectToAction(nameof(Index));
                }
            }
            TempData["MsgError"] = $"Ops, houve um erro. Tente novamente.";
            return View(nameof(Index));
        }

        [HttpPost]
        public IActionResult EsqueciSenha()
        {
            return NotFound();
        }

        [HttpPost]
        public IActionResult SolicitarAcesso(UsuarioLoginDTO login)
        {
            return NotFound();
        }

        [HttpGet]
        public IActionResult Sair()
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
