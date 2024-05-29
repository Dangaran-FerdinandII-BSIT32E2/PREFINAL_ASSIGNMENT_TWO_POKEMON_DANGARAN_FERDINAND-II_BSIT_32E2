using Microsoft.AspNetCore.Mvc;

namespace Dangaran_PokemonApplication.Models
{
    public class Pokemon : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
