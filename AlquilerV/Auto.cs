using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerV
{
    public class Auto : Vehiculo
    {
        public Auto()
        {

        }

        public decimal Precio(int CantidadDias)
        {
            
            return (Valorbase + Recargo) * CantidadDias;
            
        }


    }
}
