using Microsoft.AspNetCore.Mvc;

namespace eProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var data = 10;
            return View();
        }
    }
}
