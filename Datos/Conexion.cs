using System.Data.SqlClient;
namespace MiPortafolio.Datos
{
    public class Conexion
    {

        private string cadenaSql = string.Empty;

        public Conexion()
        {
            var Builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile
                ("appsettings.json").Build();
            cadenaSql = Builder.GetSection("ConnectionStrings:CadenaSql").Value;
        }
        public string getCadenaSql()
        {
            return cadenaSql;
        }
    }
}
