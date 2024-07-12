using LabOps.Application.DTOs.Usuario;
using LabOps.Application.Interfaces.ApiAutenticacao;
using LabOps.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IServiceAuth _services;

        public LoginController(IServiceAuth services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var userDTO = ConvertInUserLoginDTO(loginModel);
                    await _services.LoginUsuario(userDTO);
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
        public IActionResult SolicitarAcesso(LoginModel loginModel)
        {
            return NotFound();
        }

        [HttpGet]
        public IActionResult Sair()
        {
            return RedirectToAction(nameof(Index));
        }

        private static UsuarioLogin ConvertInUserLoginDTO(LoginModel loginModel)
        {
            return new UsuarioLogin
            {
                ChaveUsuario = loginModel.Login,
                Senha = loginModel.Senha
            };
        }
    }
}
