using Microsoft.AspNetCore.Mvc;

namespace AllUp_FrontToBack.Areas.manage.Controllers
{
    [Area("manage")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
