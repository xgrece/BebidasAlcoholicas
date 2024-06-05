using BebidasAlcoholicas.Models;
using MySql.Data.MySqlClient;
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
        private string connectionString = "Server=127.0.0.1;Database=bebidas;User ID=root;Password=123;";

        public List<Cerveza> getCervezas()
        {
            List<Cerveza> cervezas = new List<Cerveza>();
            string query = "SELECT * FROM cerveza";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cantidad = reader.GetInt32(4);
                    string nombre = reader.GetString(1);
                    Cerveza cerveza = new Cerveza(nombre, cantidad)
                    {
                        Alcohol = reader.GetInt32(3),
                        marca = reader.GetString(2)
                    };

                    cervezas.Add(cerveza);
                }

                reader.Close();
                connection.Close();
            }

            return cervezas;
        }
    }
}
