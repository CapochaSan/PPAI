using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PPAI.Entidades;

namespace PPAI.Acceso_a_datos
{
    public class RepoLlamada
    {
        public void add(Llamada llamada)
        {
            string query = "insert into llamada(descripcionoperador, detalleaccionrequerida, " +
                "duracion, clienteid) " +
                "values(@descripcion, @detalle, @duracion, @clienteid)";

            string cadenaBD = "Data Source=DESKTOP-R3TMJNQ\\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(cadenaBD))
            {
                SqlCommand command = new SqlCommand(query, connection);
                RepoCliente repoCliente = new RepoCliente();
                
                command.Parameters.AddWithValue("@descripcion", llamada.getDescripcion());
                command.Parameters.AddWithValue("@detalle", llamada.getDetallr());
                command.Parameters.AddWithValue("@duracion", llamada.getDuracion());
                command.Parameters.AddWithValue("@clienteid", repoCliente.GetIdCliente(llamada.getCliente()));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
