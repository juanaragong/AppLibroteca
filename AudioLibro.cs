using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibroteca
{
    internal class AudioLibro:Libro
    {
        int tiempoDuracion;

        public AudioLibro(string nombre,string autor,double precio, string editorial,int tiempoDuracion):
            base(nombre,autor,precio,editorial)
        {
            this.TiempoDuracion = tiempoDuracion;
        }

        public int TiempoDuracion { get => tiempoDuracion; set => tiempoDuracion = value; }
    }
}
