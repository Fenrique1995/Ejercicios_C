using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    public class Ejercicio06
    {
        public void ejercicio06()
        {
            int primerNumero;
            int segundoNumero;
            string entradaUno;
            string entradaDos;

            Console.WriteLine("Ingrese un año");
            entradaUno = Console.ReadLine();

            while (!int.TryParse(entradaUno, out primerNumero))
            {
                Console.WriteLine("Ingrese un año");
                entradaUno = Console.ReadLine();
            }

            Console.WriteLine("Ingrese otro año");
            entradaDos = Console.ReadLine();

            while (!int.TryParse(entradaDos, out segundoNumero))
            {
                Console.WriteLine("Ingrese un año");
                entradaUno = Console.ReadLine();
            }

            EsBiciesto(primerNumero, segundoNumero);
        }

        static void EsBiciesto(int num1, int num2)
        {
            if (num1 < num2) 
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 400 == 0)
                    {
                        Console.WriteLine($"{i} Es biciesto");
                    }
                    else if (i % 100 == 0)
                    {
                        Console.WriteLine($"{i} No es biciesto");
                    } 
                    else if (i % 4 == 0)
                    {
                        Console.WriteLine($"{i} Es biciesto");
                    }
                    else
                    {
                        Console.WriteLine($"{i} No es biciesto");
                    }
                }
            } else if (num1 > num2) 
            {
                for (int i = num1; i >= num2; i--)
                {
                    if(i % 400 == 0)
                    {
                        Console.WriteLine($"{i} Es biciesto");
                    }
                    else if (i % 100 == 0)
                    {
                        Console.WriteLine($"{i} No es biciesto");
                    }
                    else if (i % 4 == 0)
                    {
                        Console.WriteLine($"{i} Es biciesto");
                    }
                    else
                    {
                        Console.WriteLine($"{i} No es biciesto");
                    }
                }
            } else if (num1 == num2) 
            {
                Console.WriteLine($"{num1} y {num2} Son el mismo año");
                if (num1 % 4 == 0) 
                {
                    Console.WriteLine($"{num1} Es biciesto");
                } 
                else if (num1 % 100 == 0)
                {
                    Console.WriteLine($"{num1} No es biciesto");
                } 
                else if (num1 % 400 == 0)
                {
                    Console.WriteLine($"{num1} Es biciesto");
                }
            }

        }
    }
}
