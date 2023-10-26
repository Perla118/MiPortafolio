using MiPortafolio.Models;

namespace MiPortafolio.Datos
{
    public class ProyectoDatos
    {
        public List<ProyectoModel> GetProyect()
        {
            return new List<ProyectoModel>() {
                new ProyectoModel
                {
                      Titulo = "Calculdora",
                    Descripcion= "Replica de la calculadora de nuestro movil en cuanto a diseño y funciones basicas.",
                    Link="https://calculator-1.com/es/calculadora/",
                    ImagenURL="/imagenes/calculadora.jpg",

                },
                new ProyectoModel
                {
                    Titulo = "Apartado de aulas",
                    Descripcion= "Pagina web de apartado, para seleccionar mediante el edificio, el aula. ",
                    Link="https://apps9.itson.edu.mx/ApartadoAulas/",
                    ImagenURL="/imagenes/apartadoaulas.jpg",

                },
                new ProyectoModel
                {
                    Titulo = "Calcular triangulo",
                    Descripcion= "Aplicacion movil, para calcular mediante las medidas de un triangulo que tipo es.",
                    Link="https://www.calkoo.com/es/calculadora-de-triangulos",
                    ImagenURL="/imagenes/triangulo.jpg",
                },
            };
        }
    }
}
