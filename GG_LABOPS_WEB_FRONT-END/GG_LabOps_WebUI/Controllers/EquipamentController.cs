using Microsoft.AspNetCore.Mvc;

namespace GG_LabOps_WebUI.Controllers
{
    [Route("Equipament")]
    public class EquipamentController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
