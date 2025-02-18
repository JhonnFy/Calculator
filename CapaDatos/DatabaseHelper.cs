using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatabaseHelper
    {
        public void ConnectToDatabase()
        {
            // Recupera la cadena de conexión desde el archivo app.config
            string connectionString = ConfigurationManager.ConnectionStrings["AuditCalculatorConnectionString"].ConnectionString;

            // Nueva conexión utilizando la cadena de conexión
            using (SqlConnection obj_connection = new SqlConnection(connectionString))
            {
                try
                {
                    obj_connection.Open();
                    Console.WriteLine("Run  Connectios");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Not found Connections "  + ex.Message);
                }
            }
        }
    }
}
