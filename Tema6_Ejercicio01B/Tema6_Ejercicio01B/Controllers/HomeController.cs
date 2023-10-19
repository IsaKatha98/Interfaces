using Microsoft.AspNetCore.Mvc;

namespace Tema6_Ejercicio01B.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            return "Isa";
        }

        public String Apellidos()
        {
            return "Loerzer";
        }

        public IActionResult Saludo()
        {
            return View();
        }
    }
}
