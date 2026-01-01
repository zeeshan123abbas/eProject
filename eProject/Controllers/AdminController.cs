using Microsoft.AspNetCore.Mvc;

namespace eProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
