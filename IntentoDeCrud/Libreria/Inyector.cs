using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Libreria
{
    public class Inyector
    {
        //server name: DESKTOP-DOOUSUP
        private string connectionString = "Server=DESKTOP-DOOUSUP;Database=Trabajadores;Trusted_Connection=True;";

        // Método para conectar y realizar una operación de lectura
        public void ConectarYLeer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos Trabajadores.");

                    // Ejemplo de consulta SQL
                    string query = "SELECT * FROM Trabajadores";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Asumiendo que la tabla Trabajadores tiene columnas Nombre, Apellido, DNI y Puesto
                        Console.WriteLine($"Nombre: {reader["Nombre"]}, Apellido: {reader["Apellido"]}, DNI: {reader["DNI"]}, Puesto: {reader["Puesto"]}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        // Método para realizar una operación de inserción
        public void InsertarTrabajador(string nombre, string apellido, int dni, Puesto puesto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos Trabajadores.");

                    // Ejemplo de consulta SQL para insertar
                    string query = "INSERT INTO Trabajador (Nombre, Apellido, DNI, Puesto) VALUES (@Nombre, @Apellido, @DNI, @Puesto)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Puesto", puesto);

                    int result = command.ExecuteNonQuery();

                    // Verificar si la inserción fue exitosa
                    if (result > 0)
                    {
                        Console.WriteLine("Trabajador insertado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo insertar el trabajador.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

    }
}
