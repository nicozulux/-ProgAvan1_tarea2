using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerV
{
    public class Furgoneta : Vehiculo
    {
       public decimal Precio(int CantidadDias)
        {
            return ((Valorbase + ConstCarga * FurgonetaPMA) * CantidadDias);
        }
    }
}
