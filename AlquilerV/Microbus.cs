using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerV
{
    public class Microbus : Vehiculo
    {
        public decimal Precio(int CantidadDias)
        {
            return ((Valorbase * CantidadDias) + 2);
        }
    }
}
