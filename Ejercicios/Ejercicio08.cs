using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Text;
using System.Data.SqlClient;
//using MySql.Data.MySqlClient;

namespace Ejercicios
{
    public class Ejercicio08
    {
        public void ejercicio08()
        {
            string continuar;
            int contadorDeEmpleados = 0;
            string Hora;
            string Sueldo;
            string Nombre;
            string Antiguedad;
            string HorasTrabajadas;
            int sumaHorasTrabajadas;

            Console.WriteLine("Desea ingresar los datos de un empleado? \n Ingrese s/n:");
            continuar = Console.ReadLine();
            continuar.ToLower();

            while (continuar == "s")
            {
                contadorDeEmpleados++;
                
                /*HORA*/
                Console.WriteLine("Ingrese la hora actual porfavor: \n (ejemplo: 15:15)");
                Hora = Console.ReadLine();
                TimeSpan horaIngresada = IngresoDeHora(Hora);
                while (!TimeSpan.TryParse(Hora, out horaIngresada))
                {
                    Console.WriteLine("Debe ingresar la hora actual porfavor: \n (ejemplo: 15:15)");
                    Hora = Console.ReadLine();
                    
                }
                //Console.WriteLine($"{horaIngresada}");
                /**************************/

                /*Valor Hora*/
                Console.WriteLine("Ingrese el sueldo por hora de este empleado:");
                Sueldo = Console.ReadLine();
                float sueldoTrabajador;

                while (!float.TryParse(Sueldo,out sueldoTrabajador))
                {
                    Console.WriteLine("Debe ingresar el sueldo por hora de este empleado:");
                    Sueldo = Console.ReadLine();
                }

                /**************************/

                /*Nombre*/
                Console.WriteLine("Ingrese el Nombre del empleado:");
                Nombre = Console.ReadLine();
                Nombre.ToString().ToLower();
                string nombreEmpleado = ObtenerNombre(Nombre);

                //Console.WriteLine(nombreEmpleado);
                /**************************/

                /*Antiguedad*/
                Console.WriteLine("Ingrese la antiguedad del empleado:");
                Antiguedad = Console.ReadLine();
                int antiguedadDelEmpleado;

                while (!int.TryParse(Antiguedad, out antiguedadDelEmpleado))
                {
                    Console.WriteLine("Debe ingresar un numero entre 1 y 40:");
                    Antiguedad = Console.ReadLine();

                    if (antiguedadDelEmpleado < 1)
                    {
                        Console.WriteLine("Si tiene menos de un año no califica");
                    }
                    else if (antiguedadDelEmpleado > 40)
                    {
                        Console.WriteLine("ERROR!!! A USTED LO TIENEN QUE METER PRESO!");
                    }
                }
                
                /*else
                {
                    Console.WriteLine($"{ObtenerAntiguedad(antiguedadDelEmpleado)}");
                }
                */
                /**************************/

                /*Horas Trabajadas*/
                Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes:");
                HorasTrabajadas = Console.ReadLine();
                int horasDelTrabajadorMes;

                while (!int.TryParse(HorasTrabajadas, out horasDelTrabajadorMes))
                {
                    Console.WriteLine("Debe ingresar la cantidad de horas trabajadas en el mes:");
                    HorasTrabajadas = Console.ReadLine();

                    if (horasDelTrabajadorMes < 10)
                    {
                        Console.WriteLine("Esto no es posible \n Vuelva a ingresar las horas:");
                        HorasTrabajadas = Console.ReadLine();
                    }
                    else if (horasDelTrabajadorMes < 250)
                    {
                        Console.WriteLine("Esto no es posible \n Vuelva a ingresar las horas:");
                        HorasTrabajadas = Console.ReadLine();
                    }
                }

                /*
                 
                 int horasDeEsteTrabajador = ObtenerHorasTrabajadas(horasDelTrabajadorMes);
                 */
                /**************************/

                var trabajador_nuevo = new Trabajador(sueldoTrabajador, nombreEmpleado, antiguedadDelEmpleado, horasDelTrabajadorMes);
                var gestor = new Gestor();
                gestor.GuardarEnSql(trabajador_nuevo);
          

                Console.WriteLine("Desea continuar ingresando datos? \n Ingrese s/n:");
                continuar = Console.ReadLine();
                continuar.ToLower();
            }
        }

        static TimeSpan IngresoDeHora(string horario)
        {
            TimeSpan hora;

            if (TimeSpan.TryParse(horario, out hora))
            {
                return hora;
            }
            else
            {
                return TimeSpan.Zero;
            }
        }

        static float ObtenerSueldo(float sueldo)
        {
            return sueldo;
        }

        static string ObtenerNombre(string nombre) 
        { 
            if (nombre is string) 
            {
                return nombre;
            }
            else
            {
                return "No es un nombre pelotudo";
            }
        }

        static int ObtenerAntiguedad(int antiguedad)
        {
                return antiguedad;
        }

        static int ObtenerHorasTrabajadas(int totalDeHoras)
        {
            return totalDeHoras;
        }
    }

    public class Trabajador
    {
        private float salario;
        private string nombre;
        private int antiguedad;
        private int cantidadDeHorasTrabajadas;

        public Trabajador(float salario) : this(salario,"",0,0)
        {
            
        }
        public Trabajador(float salario, string nombre) : this(salario, nombre, 0,0)
        {

        }

        public Trabajador(float salario, string nombre, int antiguedad) : this(salario, nombre, antiguedad, 0)
        {

        }

        public Trabajador(float salario, string nombre, int antiguedad, int cantidadDeHorasTrabajadas)
        {
            this.salario = salario;
            this.nombre = nombre;
            this.antiguedad = antiguedad;
            this.cantidadDeHorasTrabajadas = cantidadDeHorasTrabajadas;
        }

        public float Salario
        { 
            get { return salario; } 

            set { salario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Antiguedad 
        { 
            get { return antiguedad; } 
            set { antiguedad = value; }
        }

        public int CantidadDeHorasTrabajadas
        {
            get { return cantidadDeHorasTrabajadas; }
            set { cantidadDeHorasTrabajadas = value; }
        }
    }
    public class Gestor
    {
        public Gestor()
        {
            
        }
        public void GuardarEnSql(Trabajador trabajador)
        {
            // Cadena de conexión a la base de datos
            string connectionString = "Data Source= 127.0.0.1; Initial Catalog=trabajadores; Integrated Security=True";

            // Comando SQL para crear la base de datos si no existe
            string createDbQuery = @"IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'trabajadores')
                                 CREATE DATABASE trabajadores";

            // Comando SQL para crear la tabla si no existe
            string createTableQuery = @"USE trabajadores;
                                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Trabajador')
                                    CREATE TABLE Trabajador (
                                        ID INT IDENTITY(1,1) PRIMARY KEY,
                                        Nombre VARCHAR(100),
                                        Salario FLOAT,
                                        Antiguedad INT,
                                        CantidadDeHorasTrabajadas INT
                                    )";


            // Comando SQL para insertar datos
            string insertDataQuery = "INSERT INTO Trabajador (Nombre, Salario, Antiguedad, CantidadDeHorasTrabajadas) VALUES (@Nombre, @Salario, @Antiguedad, @CantidadDeHorasTrabajadas)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(createDbQuery, connection);
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear la base de datos si no existe
                    command.ExecuteNonQuery();

                    // Crear la tabla si no existe
                    command.CommandText = createTableQuery;
                    command.ExecuteNonQuery();

                    // Cambiar la cadena de conexión para usar la base de datos 'trabajadores'
                    connection.ChangeDatabase("trabajadores");

                    // Insertar datos
                    command.CommandText = insertDataQuery;
                    command.Parameters.AddWithValue("@Nombre", trabajador.Nombre);
                    command.Parameters.AddWithValue("@Salario", trabajador.Salario);
                    command.Parameters.AddWithValue("@Antiguedad", trabajador.Antiguedad);
                    command.Parameters.AddWithValue("@CantidadDeHorasTrabajadas", trabajador.CantidadDeHorasTrabajadas);

                    int result = command.ExecuteNonQuery();

                    // Verificar el resultado
                    if (result < 0)
                        Console.WriteLine("Error al insertar los datos en la base de datos.");
                    else
                        Console.WriteLine("Datos insertados correctamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión
                    connection.Close();
                }
            }
        }
    }
}