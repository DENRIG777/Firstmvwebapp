using Microsoft.AspNetCore.Mvc;

namespace Firstmvwebapp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
