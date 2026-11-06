using Microsoft.AspNetCore.Mvc;

namespace KProject1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
