using MiPortafolio.Models;
using MiPortafolio.Datos;
using Microsoft.AspNetCore.Mvc;

namespace MiPortafolio.Controllers
{
    public class ProyectoController : Controller
    {
        
        public IActionResult Proyecto()
        {
            
                ProyectoDatos proyectoDatos = new ProyectoDatos();
                List<ProyectoModel> proyectos = proyectoDatos.GetProyect();
                return View(proyectos);
            
        }
    }
}
