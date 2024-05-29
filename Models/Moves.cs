using Microsoft.AspNetCore.Mvc;

namespace Dangaran_PokemonApplication.Models
{
    public class Moves : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
