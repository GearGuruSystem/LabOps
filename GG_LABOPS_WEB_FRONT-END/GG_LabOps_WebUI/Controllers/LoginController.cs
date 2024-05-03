using GG_LabOps_Domain.Interfaces;
using GG_LabOps_WebUI.Models;
using Microsoft.AspNetCore.Mvc;
#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserServices _services;
        private readonly ISessionHelper _session;

        public LoginController(IUserServices services, ISessionHelper session)
        {
            _services = services;
            _session = session;
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
            try
            {
                await _services.SearchUserByKey(loginModel.Login) ;
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController.Index));
            }
            catch (Exception ex)
            {
                TempData["MsgError"] = $"Ops, houve um erro. Detalhe do erro: {ex.Message}";
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public IActionResult Sair()
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
