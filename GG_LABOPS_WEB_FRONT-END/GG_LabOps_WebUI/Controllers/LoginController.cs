using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_WebUI.Models;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserServices _services;

        public LoginController(IUserServices services)
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
                    await _services.LoginUser(userDTO);
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

        private static UserLoginDTO ConvertInUserLoginDTO(LoginModel loginModel)
        {
            return new UserLoginDTO
            {
                ChaveUsuario = loginModel.Login,
                Senha = loginModel.Senha
            };
        }
    }
}
