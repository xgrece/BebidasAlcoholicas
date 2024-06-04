using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebidasAlcoholicas.Models
{
    interface IBebidaAlcoholica
    {
        int Alcohol { get; set; }

        void MaxRecomendado();
    }
}