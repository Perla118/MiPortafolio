using MiPortafolio.Models;
using System.Data.SqlClient;
using System.Data;

namespace MiPortafolio.Datos
{
    public class ConocimientosDatos
    {
        public List<ConocimientosModel> Listar()
        {
            List<ConocimientosModel> oLista = new List<ConocimientosModel>();
            var cn = new Conexion();
            using (var conexion = new SqlConnection(cn.getCadenaSql()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Select * from Conocimientos", conexion);
                cmd.CommandType = CommandType.Text;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new ConocimientosModel()
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Conocimiento = dr["Conocimiento"].ToString(),
                        });
                    }
                }
            }
            return oLista;
        }
    }
}
