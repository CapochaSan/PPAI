using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PPAI.Entidades;

namespace PPAI.Acceso_a_datos
{
    internal class RepoEstado
    {
        public HashSet<Estado> GetEstados() 
        {
            HashSet<Estado> estados = new HashSet<Estado>();

            string cadenaBD = "Data Source=DESKTOP-R3TMJNQ\\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True";
            string query = "SELECT nombre FROM estado";

            using (SqlConnection connection = new SqlConnection(cadenaBD))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    String name = reader.GetString(0);
                    Estado estado = new Estado(name);

                    estados.Add(estado);
                }
                reader.Close();
                connection.Close();
            }

            return estados; 
        }
        public Estado GetEstadoId(int id)
        {
            Estado estado = null;

            string cadenaBD = "Data Source=DESKTOP-R3TMJNQ\\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True";
            string query = "SELECT nombre FROM estado WHERE estado.estadoid = "+id;

            using (SqlConnection connection = new SqlConnection(cadenaBD))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString(0);
                    estado = new Estado(name);
                    
                }
                reader.Close();
                connection.Close();
            }

            return estado;
        }
    }
}
