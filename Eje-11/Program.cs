using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseValidacion;

namespace Eje_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int valorNumerico = 0;
            int mayor = 0;
            int menor = 0;
            int sumaDeValores=0;
            int promedio;
            bool bandera = true;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                entrada = Console.ReadLine();

                while (!int.TryParse(entrada, out valorNumerico))
                {
                    Console.WriteLine("Debe ingresar un valor numerico!!!");
                    entrada = Console.ReadLine();
                }

                sumaDeValores += valorNumerico;
                
                if (bandera == true)
                {
                    mayor = valorNumerico;
                    menor = valorNumerico;
                    bandera = false;
                }

                if (bandera == false)
                {
                    if (valorNumerico > mayor)
                    {
                        mayor = valorNumerico;
                    }

                    if (valorNumerico < menor)
                    {
                        menor = valorNumerico;
                    }
                }
                while (!Validacion.Validar(valorNumerico, mayor, menor))
                {
                    Console.WriteLine("Debe ingresar un valor numerico entre -100 y 100!!!");
                    entrada = Console.ReadLine();
                }
            }
            promedio = sumaDeValores / 10;
            Console.WriteLine($"Este es el mayor: {mayor}\nEste es el menor: {menor}\nEste es el promedio: {promedio}");
            Console.ReadKey();
        }      
    }
}
