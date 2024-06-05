
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasAlcoholicas.Models
{
    class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string marca { get; set; }

        //Como escribir de otra forma los getter y los setter's.
        /*
         
        public string GetNombre()
        {
            return nombre;
        }

        public void SetCantidad(int cantidad)
        {
            this.Cantidad = cantidad
        }
        public void SetNombre(string nombre)
        {
            this.Nombre = nombre
        }

        */
        public Bebida(string nombre, int cantidad)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
        }

        public Bebida() { }

        public void Tomarse(int cuantoBebio)
        {
            Cantidad -= cuantoBebio;
            /*
            //En caso de poder ingresar mas de una vez el "Tomarse" evaluara si esto llega a 0 evitando numeros negativos.

            if (cuantoBebio > 0 && cuantoBebio <= Cantidad)
                Cantidad -= cuantoBebio;
            else
                Console.WriteLine("La cantidad a beber es inválida o excede la cantidad disponible.");
            */
        }
    }
}