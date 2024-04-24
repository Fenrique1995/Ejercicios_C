using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio03
    {
        public void ejercicio03()
        {
            string entrada;
            int numero;

            Console.Title = "Ejercicio Nro 3";

            Console.WriteLine("Ingrese un numero");
            entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("ERROR!!! INGRESE UN NUMERO");
                entrada = Console.ReadLine();
            }

            for (int i = 0; i < numero; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine($"{i} es primo.");
                }
                else
                {
                    Console.WriteLine($"{i} no es primo.");
                }
            }
        }

        private bool EsPrimo(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            int limite = (int)Math.Sqrt(num);

            for (int i = 3; i < limite; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
