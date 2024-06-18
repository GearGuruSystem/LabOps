using Microsoft.AspNetCore.Mvc;

namespace LabOps.WebUI.Controllers
{
    public class FabricanteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
