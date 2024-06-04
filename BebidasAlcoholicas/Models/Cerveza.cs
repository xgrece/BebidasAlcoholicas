using BebidasAlcoholicas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasAlcoholicas.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        internal string marca;

        public Cerveza(int Cantidad, string Nombre)
            : base(Nombre, Cantidad)
        {
        }

        public Cerveza(string nombre)
        {

        }

        public Cerveza()
        {
        }

        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permito de birras es cinco latas por persona");
        }

    }
}