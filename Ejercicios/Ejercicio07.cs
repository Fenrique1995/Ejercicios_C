using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    public class Ejercicio07
    {
        public void ejercicio07()
        {
            DateTime cumpleaños;
            Console.WriteLine("Introduce tu fecha de nacimiento (yyyy-mm-dd):");
            string entrada = Console.ReadLine();

            while (!DateTime.TryParse(entrada, out cumpleaños))
            {
                Console.WriteLine("Formato incorrecto!!! Debes introducir tu fecha de nacimiento (yyyy-mm-dd):");
                entrada = Console.ReadLine();
            }
            Vida(entrada, cumpleaños);
        }

        static void Vida(string entrada, DateTime fecha)
        {
            if (DateTime.TryParse(entrada, out fecha))
            {
                DateTime hoyEnDia = DateTime.Today;
                TimeSpan diasVividos = hoyEnDia - fecha;

                Console.WriteLine($"Esta persona vivio {diasVividos.Days} dias");
            }
            else 
            {
                Console.WriteLine("Fecha invalida");
            }
        }
    }
}
