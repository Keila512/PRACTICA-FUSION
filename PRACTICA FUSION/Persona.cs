using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_FUSION
{
    internal class Persona
    {
       
        protected string nombre;
        protected DateTime? fechaN;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime? FechaN
        {
            get { return fechaN; }
            set { fechaN = value; }
        }
        //private int edad;

        public int Edad
        {
            get
            {
                int edad = 0;
                edad = DateTime.Now.Year - FechaN.Value.Year;
                return edad;
            }

        }

        public Persona()
        {
            nombre = string.Empty;
            fechaN = null;
        }
        public Persona(string nombre, DateTime? fechaN)
        {
            this.nombre = nombre;
            this.fechaN = fechaN;
        }
        public override string ToString()
        {
            return nombre.ToUpper() + " " + fechaN + " " + Edad;
        }
    }
}
