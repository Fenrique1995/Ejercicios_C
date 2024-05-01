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
            if (valor <= 100 || valor >= -100)
            {
                return true;
            }
            else if (min <= 100 || min >= -100)
            {
                return true;
            }
            else if (max <= 100 || max >= -100)
            {
                return true;
            }
            return false;
        }
    }
}
