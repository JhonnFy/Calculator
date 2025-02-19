using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace CapaDatos
{
    public class DatabaseHelper
    {

        //Paso De Parametros Db
        public void ConnectToDatabase(int Num1, int Num2, string Operador, double Resultado)
        {
            // Recupera la cadena de conexión desde el archivo app.config
            string connectionString = ConfigurationManager.ConnectionStrings["AuditCalculatorConnectionString"].ConnectionString;

            // Verificar que la cadena de conexión no esté vacía
            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("La cadena de conexión no está configurada correctamente.");
                return;
            }

            // Objeto 
            using (SqlConnection obj_connection = new SqlConnection(connectionString))
            {
                //Insert Into AuditCalculator
                string query = "INSERT INTO TransactionAudit(Num1, Num2, Operador, Resultado) Values (@Num1, @Num2, @Operador, @Resultado)";

                // Agregar los parámetros con sus tipos específicos
                SqlCommand cmd = new SqlCommand(query, obj_connection);
                cmd.Parameters.Add("@Num1", SqlDbType.Int).Value = Num1;
                cmd.Parameters.Add("@Num2", SqlDbType.Int).Value = Num2;
                cmd.Parameters.Add("@Operador", SqlDbType.VarChar).Value = Operador;
                cmd.Parameters.Add("@Resultado", SqlDbType.Float).Value = Resultado;

                try
                {
                    // Abrir la conexión
                    obj_connection.Open();
                    // Ejecutar la consulta SQL
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Run Connection OK");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Not found Connections "  + ex.Message);
                }
                finally
                {
                    // Cerrar LA Conexión
                    if (obj_connection.State == System.Data.ConnectionState.Open)
                    {
                        obj_connection.Close();
                    }
                }
            }
        }
    }
}