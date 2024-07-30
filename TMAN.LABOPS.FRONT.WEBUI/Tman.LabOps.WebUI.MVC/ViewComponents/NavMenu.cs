using Microsoft.AspNetCore.Mvc;

namespace LabOps.WebUI.ViewComponents
{
    public class NavMenu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
