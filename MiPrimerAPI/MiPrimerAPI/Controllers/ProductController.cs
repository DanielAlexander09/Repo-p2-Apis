using Microsoft.AspNetCore.Mvc;
using MiPrimerAPI.Services;

namespace MiPrimerAPI.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductService _service;
        public ProductController(ProductService service) => _service =
        service;

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetAllProducts();
            return Ok(products);
        }

    }
}
