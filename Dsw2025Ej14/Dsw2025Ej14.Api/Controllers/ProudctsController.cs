using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.Api.Controllers
{
    public class ProudctsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
