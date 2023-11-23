using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PPAI.Entidades;

namespace PPAI.Acceso_a_datos
{
    public class RepoCliente
    {
        public int GetIdCliente(Cliente cliente)
        {
            int id = -1;

            string cadenaBD = "Data Source=DESKTOP-R3TMJNQ\\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True";
            string query = "SELECT clienteid FROM cliente WHERE cliente.dni = " + cliente.getDNI();

            using (SqlConnection connection = new SqlConnection(cadenaBD))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   id = reader.GetInt32(0);
                   

                }
                reader.Close();
                connection.Close();
            }

            return id;
        }
    }
}
