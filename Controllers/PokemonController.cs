using Microsoft.AspNetCore.Mvc;

namespace Dangaran_PokemonApplication.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
