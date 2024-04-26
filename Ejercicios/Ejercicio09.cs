using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio09
    {
        

        public void ejercicio09()
        {
            int alturaIngresada;
            Console.WriteLine("Ingrese la altura deseada del Rectangulo:");
            string entrada = Console.ReadLine();
            while (!int.TryParse(entrada, out alturaIngresada))
            {
                Console.WriteLine("Debe ingresar la altura deseada del Rectangulo, que debe ser un numero:");
                entrada = Console.ReadLine();
            }

            PiramideRectangular(alturaIngresada);
        }
        static void PiramideRectangular(int altura)
        {
            string asterisco = "*";
            for (int i = 0; i < altura; i++)
            {
                Console.WriteLine(asterisco);
                for (int j = 1; j < 4; j+=2)
                {
                    asterisco += "*";
                } 
            }
        }
    }
}
