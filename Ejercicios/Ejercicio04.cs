using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    public class Ejercicio04
    {
        public void ejercicio04()
        {
            Console.Title = "Ejercicio Nro 4";
            int contador = 0;
            int perfecto = 0;

            for (int i = 0; contador <=4 ; i++)
            {
                if (EsNumeroPerfecto(i))
                {
                    contador++;
                    perfecto = i;
                    if (perfecto > 0)
                    {
                        Console.WriteLine($"{perfecto} es perfecto");
                    }
                }    
            }
        }
        static bool EsNumeroPerfecto(int num)
        {
            int suma = 0;

            for (int divisor = 1; divisor <= num / 2; divisor++)
            {
                if (num % divisor == 0)
                {
                    suma += divisor;
                }
            }

            return suma == num;
        }
    }
}
