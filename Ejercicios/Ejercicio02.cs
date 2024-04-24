using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio02
    {
        public void ejercicio02()
        {
            Console.Title = "Ejercicio Nro 2";
            string entrada;
            int numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un numero");
            entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out numero) || numero <= 0)
            {
                Console.WriteLine("ERROR!!!! INGRESE UN NUMERO MAYOR A 0");// Si la entrada no es válida, se muestra un mensaje de error.
                entrada = Console.ReadLine();//Se solicita nuevamente la entrada al usuario.
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine($"El cuadrado de el numero ingresado es {cuadrado}");
            Console.WriteLine($"El cubo de el numero ingresado es {cubo}");


        }
    }
}
