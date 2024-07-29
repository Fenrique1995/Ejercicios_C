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

        public List<Trabajador> ConectarYLeer()
        {
            List<Trabajador> trabajadores = new List<Trabajador>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos Trabajadores.");

                    // Ejemplo de consulta SQL
                    string query = "SELECT * FROM Trabajador";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombre = reader["Nombre"].ToString();
                        string apellido = reader["Apellido"].ToString();
                        int dni = Convert.ToInt32(reader["DNI"]);
                        Puesto puesto = (Puesto)Enum.Parse(typeof(Puesto), reader["Puesto"].ToString());

                        Trabajador trabajador = new Trabajador(nombre, apellido, dni, puesto);

                        trabajadores.Add(trabajador);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }

            return trabajadores;
        }

        // Método para realizar una operación de inserción
        public void InsertarTrabajador(string nombre, string apellido, int dni, string puesto)
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



        public void BorrarTrabajador(string trabajadorStr)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Divide la cadena para obtener las partes necesarias
                    string[] partes = trabajadorStr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string nombre = partes[1];
                    string apellido = partes[3];
                    int dni = int.Parse(partes[5]);

                    string query = "DELETE FROM Trabajador WHERE Nombre = @Nombre AND Apellido = @Apellido AND DNI = @DNI";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@DNI", dni);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Trabajador borrado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo borrar el trabajador.");
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