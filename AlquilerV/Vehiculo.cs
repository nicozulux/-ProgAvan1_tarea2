using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerV
{
    public abstract class Vehiculo
    {
        public int Dias { get; set; }
        public const int Valorbase = 50;
        public const decimal Recargo = 1.5m;
        public const int FurgonetaPMA = 10 ;
        public const int CamionPMA = 15;
        public const int ConstCarga = 20;
    }
}
