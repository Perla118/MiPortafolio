using Microsoft.AspNetCore.Mvc;
using MiPortafolio.Models;
using MiPortafolio.Datos;

namespace MiPortafolio.Controllers
{
    public class ConocimientosController : Controller
    {
        ConocimientosDatos conocimientosDatos = new ConocimientosDatos();
        public IActionResult Listar()
        {
            var lista = conocimientosDatos.Listar();
            return View(lista);

        }
    }
}
