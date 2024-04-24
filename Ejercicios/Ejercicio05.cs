using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    public class Ejercicio05
    {
        public void ejercicio05()
        {
            Console.Title = "Ejercicio Nro 5";
            string entrada;
            int numero;
            int contador = 0;

            Console.WriteLine("Ingrese un numero mayor a 6:");
            entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out numero) || numero < 6)
            {
                Console.WriteLine("ERROR!!! Debe ingresar un numero mayor a 6:");
                entrada = Console.ReadLine();
            }
            for (int i = 1; i <= numero; i++)
            {
                if (EsCentroNumerico(i))
                {
                    if (i >= 6)
                    {
                        Console.WriteLine($"Este numero es un centro numerico {i}");
                        contador++; 
                    }
                    
                }
            }
            Console.WriteLine($"Esta es la cantidad de centros numericos que hay {contador}");
        }

        static bool EsCentroNumerico (int num)
        {
            int sumDerecha = 0;
            int sumIzquierda = 0;

            for (int i = 1; i < num; i++)
            {
                sumIzquierda += i;
            }
            
            int j = num + 1;

            while (sumDerecha < sumIzquierda)
            {
                sumDerecha += j;
                j++;
            }

            if (sumDerecha == sumIzquierda) return true;

            return false;
        }
    }
}
