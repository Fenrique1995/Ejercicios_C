using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartuchera;

namespace Eje_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            boligrafoRojo.Pintar(60, out string A);
            boligrafoRojo.Recargar();
            boligrafoRojo.Pintar(60, out string S);
            boligrafoAzul.Pintar(110, out string B);
            boligrafoAzul.Recargar();
            boligrafoAzul.Pintar(10, out string W);
            Console.ReadKey();
        }
    }
}
