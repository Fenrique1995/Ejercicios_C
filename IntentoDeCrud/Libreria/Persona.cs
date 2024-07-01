using System.Reflection.Metadata;
using System.Text;

namespace Libreria
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;

        public Persona(string nombre)
            :this(nombre,"",0)
        {
            
        }

        public Persona(string nombre, string apellido)
            : this(nombre, apellido, 0)
        {

        }
        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre { get { return nombre; } }

        public string Apellido { get {  return apellido; } }

        public int Dni { get { return dni; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nombre+"\n");
            sb.Append(Apellido+"\n");
            sb.Append(Dni+"\n");
            return sb.ToString();
        }
    }
}
