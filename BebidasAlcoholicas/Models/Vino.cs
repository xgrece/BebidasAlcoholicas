using BebidasAlcoholicas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasAlcoholicas.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public Vino(string Nombre, int Cantidad) : base(Nombre, Cantidad)
        {
        }

        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permito de vinos es dos botellas por persona");
        }

    }
}