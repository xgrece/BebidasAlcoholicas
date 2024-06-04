
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasAlcoholicas.Models
{
    internal class Bebida
    {
        public string nombre { get; set; }
        public int cantidad { get; set; }

        public Bebida(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

        public Bebida() { }

        public void tomarse(int cuantoBebio)
        {
            this.cantidad -= cuantoBebio;
        }
    }
}