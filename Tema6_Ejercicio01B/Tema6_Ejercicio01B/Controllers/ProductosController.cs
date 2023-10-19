using Microsoft.AspNetCore.Mvc;

namespace Tema6_Ejercicio01B.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}
