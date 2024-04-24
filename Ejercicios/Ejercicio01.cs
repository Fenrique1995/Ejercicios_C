using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio01
    {
        public void ejercicio01()
        {
            Console.Title = "Ejercicio Nro 1";//Le pone titulo a la consola donde se hace display del console

            int min = int.MaxValue;//Inicializa la variable min al valor máximo que puede tomar un entero, para que cualquier número introducido por el usuario sea más pequeño.
            int max = int.MinValue;//Inicializa la variable max al valor mínimo posible, para que cualquier número introducido sea mayor.
            int acumulador = 0;//Esta variable acumulará la suma de todos los números introducidos.
            int numero;//Esta variable almacenará temporalmente cada número introducido por el usuario.
            int promedio;//Aquí se guardará el promedio de los números.

            for (int i = 0; i < 5; i++)//Este bucle se ejecutará 5 veces, permitiendo al usuario introducir 5 números diferentes.
            {
                Console.WriteLine("Introduce un numero");//Pide al usuario que introduzca un número.
                string entrada = Console.ReadLine();//Lee la entrada del usuario y la almacena en la variable entrada.
                while (!int.TryParse(entrada, out numero))//Continúa solicitando al usuario un número hasta que se introduzca una entrada válida (un entero). 
                {
                    Console.WriteLine("ERROR!!!! INGRESE UN NUMERO");// Si la entrada no es válida, se muestra un mensaje de error.
                    entrada = Console.ReadLine();//Se solicita nuevamente la entrada al usuario.
                }
                //Compara el numero para ver si es mayor o menor
                if (numero < min)//Si es menor al minimo
                {
                    min = numero;//Numero sera el nuevo minimo
                }
                else if (numero > max)//Si es mayor al maximo 
                {
                    max = numero;//Numero sera el maxismo
                }

                acumulador += numero;//Suma el número actual al acumulador.

                //Console.WriteLine(entrada);//Muestra el numero ingresado
            }

            Console.WriteLine("minimo: " + min);//Muestra el minimo.
            Console.WriteLine("maximo: " + max);//Muestra el maximo.

            Console.WriteLine(acumulador);//Muestra la suma total de todos los números introducidos una vez que el bucle ha terminado.

            promedio = acumulador / 5;// Calcula el promedio dividiendo el acumulador por 5.

            Console.WriteLine(promedio);// Muestra el promedio calculado.

        }

        // Console.WriteLine("{0}{1}{2}", min, max, 23);
    }
}
