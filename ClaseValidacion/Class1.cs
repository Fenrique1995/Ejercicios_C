using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseValidacion
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max) 
        {
            // Verifica si cualquier valor está fuera del rango permitido.
            if (valor > 100 || valor < -100 || min > 100 || min < -100 || max > 100 || max < -100)
            {
                return false;
            }

            // Si todos los valores están dentro del rango -100 a 100, retorna true.
            return true;
        }
    }
}
