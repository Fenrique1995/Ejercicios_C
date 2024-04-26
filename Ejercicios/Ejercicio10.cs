using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio10
    {
        public void ejercicio10()
        {
            int alturaIngresada;
            Console.WriteLine("Ingrese la altura deseada del Rectangulo:");
            string entrada = Console.ReadLine();
            while (!int.TryParse(entrada, out alturaIngresada))
            {
                Console.WriteLine("Debe ingresar la altura deseada del Rectangulo, que debe ser un numero:");
                entrada = Console.ReadLine();
            }

            PiramideTriangular(alturaIngresada);
        }
        static void PiramideTriangular(int altura)
        {
            string asterisco = "*";     

            for (int i = 0; i < altura; i++)
            {
                int ventanaAncho = Console.WindowWidth; // Obtiene el ancho de la ventana de la consola
                int textoAncho = asterisco.Length; // Longitud del texto a centrar
                int espacios = (ventanaAncho - textoAncho) / 2; // Calcula el número de espacios para centrar el texto
                Console.WriteLine(new string(' ', espacios) + asterisco);
                for (int j = 1; j < 4; j += 2)
                {
                    asterisco += "*";
                }
            }
        }
    }
}
