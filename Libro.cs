using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AppLibroteca
{
    internal class Libro
    {

        //Clase Base
        protected string nombre;
        protected string autor;
        protected double precio;
        protected string editorial;

        public string Nombre { get; set; }
        public string Autor { get; set; }
        public double Precio { get; set; }
        public string Editorial { get; set; }

        public Libro(string nombre)
        { 
             this.nombre = nombre;
        }

        public Libro(string nombre, string autor, double precio, string editorial)
        {
            this.Nombre = nombre;
            this.Autor = autor;
            this.Precio = precio;
            this.Editorial = editorial;

        }

    }

}
