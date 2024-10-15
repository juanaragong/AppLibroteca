using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibroteca
{
    internal class LibroImpreso:Libro
    {
        int numeroPaginas;

        public int NumeroPaginas { get; set; }

        public LibroImpreso(string nombre, string autor, double precio, string editorial,int numeroPaginas) 
            : base(nombre,autor,precio,editorial)
        {
            this.NumeroPaginas = numeroPaginas;
        }

        public LibroImpreso(string nombre, int numeroPaginas):base(nombre)
        { 
            this.numeroPaginas=numeroPaginas;
        }

    }
}
