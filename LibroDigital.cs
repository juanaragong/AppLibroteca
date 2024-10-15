using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibroteca
{
    internal class LibroDigital :Libro
    {
        double pesoLibroMB;
        public LibroDigital(string nombre,string autor ,double precio,string editorial,double pesoLibroMB)
            : base(nombre, autor, precio, editorial)
        {
            this.PesoLibroMB=pesoLibroMB;
        }

        public double PesoLibroMB { get => pesoLibroMB; set => pesoLibroMB = value; }
    }
}
