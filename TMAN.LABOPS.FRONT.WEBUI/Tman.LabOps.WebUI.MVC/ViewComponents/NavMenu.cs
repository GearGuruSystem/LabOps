using Microsoft.AspNetCore.Mvc;

namespace Tman.LabOps.WebUI.MVC.ViewComponents
{
    public class NavMenu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
