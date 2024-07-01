using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public enum Puesto
    {
        Planta,
        Base,
        Terciario,
    }
    public class Trabajador : Persona
    {
        private Puesto puesto;

        public Trabajador(string nombre, string apellido, int dni, Puesto puesto)
        : base(nombre, apellido, dni)
        {
            this.puesto = puesto;
        }

        public Puesto Puesto { get { return this.puesto; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(puesto+"\n");
            return sb.ToString();
        }
    }
}
