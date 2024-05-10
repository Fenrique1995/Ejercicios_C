using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Cartuchera
{
    public class Boligrafo
    {
        private static short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        } 

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "*";

            // Cambia el color del texto de la consola al color del bolígrafo
            Console.ForegroundColor = this.color;

            if (gasto <= this.tinta)
            {
                this.tinta -= gasto;

                setTinta(this.tinta);


                string asterisco = string.Concat(Enumerable.Repeat(dibujo, gasto));
                Console.WriteLine($"{asterisco}");

                // Restaura el color original de la consola
                Console.ResetColor();

                return true;
            }
            else if (gasto > this.tinta) 
            {

                string asterisco = string.Concat(Enumerable.Repeat(dibujo, this.tinta));
                Console.WriteLine($"{asterisco}");
                this.tinta = 0;
                // Restaura el color original de la consola
                Console.ResetColor();

                return true;
            }
            return false;

        }

        public void Recargar()
        {
            setTinta(100);
        }

        private void setTinta(short tinta)
        {
            if (tinta >= cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;  // Establece la tinta al máximo si el argumento es mayor que el máximo.
            }
            else if (tinta <= 0)
            {
                this.tinta = 0;  // Establece la tinta a cero si el argumento es menor o igual a cero.
            }
            else
            {
                this.tinta = tinta;  // Establece la tinta al valor proporcionado si está entre 0 y el máximo.
            }
        }
    }
}
