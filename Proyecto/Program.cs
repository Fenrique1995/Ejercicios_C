using Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int numero;

            Console.Title = "Menu";

            Console.WriteLine("Ingrese un numero");
            entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("ERROR!!! INGRESE UN NUMERO");
                entrada = Console.ReadLine();
            }

            switch (numero)     
            {
                case 1:
                    var ejercicio01 = new Ejercicios.Ejercicio01();

                    ejercicio01.ejercicio01();

                    Console.WriteLine();
                    break;
                case 2:
                    var ejercicio02 = new Ejercicios.Ejercicio02();

                    ejercicio02.ejercicio02();

                    Console.WriteLine();
                    break;
                case 3:
                    var ejercicio03 = new Ejercicios.Ejercicio03();

                    ejercicio03.ejercicio03();

                    Console.WriteLine();
                    break;
                case 4:
                    var ejercicio04 = new Ejercicios.Ejercicio04();
                    
                    ejercicio04.ejercicio04();

                    Console.WriteLine(); 
                    break;
                case 5:
                    var ejercicio05 = new Ejercicios.Ejercicio05();
                    
                    ejercicio05.ejercicio05();

                    Console.WriteLine();
                    break;
                case 6:
                    var ejercicio06 = new Ejercicios.Ejercicio06();

                    ejercicio06.ejercicio06();

                    Console.WriteLine();
                    break;
                case 7:
                    var ejercicio07 = new Ejercicios.Ejercicio07();

                    ejercicio07.ejercicio07();

                    Console.WriteLine();
                    break;
                case 8:
                    var ejercicio08 = new Ejercicios.Ejercicio08();

                    ejercicio08.ejercicio08();

                    Console.WriteLine();
                    break;
                case 9:
                    var ejercicio09 = new Ejercicios.Ejercicio09();

                    ejercicio09.ejercicio09();

                    Console.WriteLine();
                    break;
                case 10:
                    var ejercicio10 = new Ejercicios.Ejercicio10();

                    ejercicio10.ejercicio10();

                    Console.WriteLine();
                    break;
            }

            Console.ReadKey();//esto es para que espere a que presiones una tecla antes de continuar
        }
    }
}
