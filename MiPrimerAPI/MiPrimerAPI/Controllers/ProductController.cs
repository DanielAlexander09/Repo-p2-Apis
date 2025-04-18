using Microsoft.AspNetCore.Mvc;

namespace MiPrimerAPI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
