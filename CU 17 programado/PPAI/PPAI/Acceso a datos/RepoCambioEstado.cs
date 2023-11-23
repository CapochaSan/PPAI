using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PPAI.Entidades;

namespace PPAI.Acceso_a_datos
{
    public class RepoCambioEstado
    {
        public List<CambioEstado> Get()
        {
            RepoEstado repoestado = new RepoEstado();
            List<CambioEstado> cambioEstados = new List<CambioEstado>();

            string cadenaBD = "Data Source=DESKTOP-R3TMJNQ\\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True";
            string query = "SELECT fechahorainicio, fechahorafin, estadoid FROM cambioestado";

            using (SqlConnection connection = new SqlConnection(cadenaBD))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime fechahorainicio = reader.GetDateTime(0);
                    DateTime fechahorafin= reader.GetDateTime(1);                    
                    Estado estado = repoestado.GetEstadoId(reader.GetInt32(2));
                    CambioEstado cambioEstado = new CambioEstado(fechahorainicio, estado);

                    cambioEstados.Add(cambioEstado);
                }
                reader.Close();
                connection.Close();
            }

            return cambioEstados;
        }
    }
}
