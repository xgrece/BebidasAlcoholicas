using BebidasAlcoholicas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasAlcoholicas.Models
{
    class CervezaBD
    {

        private string connectionString = "Data Source=DESKTOP-HLAD5ES;Initial Catalog=bebidas;user=root;Password=123;";

        public List<Cerveza> GetCervezas()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "select * from cerveza";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cantidad = reader.GetInt32(4);
                    string nombre = reader.GetString(1);
                    Cerveza cerveza = new Cerveza(cantidad,nombre);

                    cerveza.Alcohol = reader.GetInt32(3);
                    cerveza.marca = reader.GetString(2);

                    cervezas.Add(cerveza);
                }

                reader.Close();
                connection.Close();
            }

            return cervezas;
        }
    }
}
