using AutoMapper;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Usuarios;
using LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiAutenticacao;
using LabOps.WebUI.Models.Usuarios;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IServiceAuth _services;
        private readonly IMapper _mapper;

        public LoginController(IServiceAuth services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
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
                    await _services.LoginUsuario(_mapper.Map<UsuarioLoginDTO>(loginModel));
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
    }
}
