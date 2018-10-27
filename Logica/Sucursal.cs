using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Sucursal : Locales
    {
        public double TasaInteres { get; set; }

        public Sucursal()
        {

        }

        public Sucursal(int iD, string ciudad, string direccion, int cP, double tasaInteres)
        {
            ID = iD;
            Ciudad = ciudad;
            Direccion = direccion;
            CP = cP;
            TasaInteres = tasaInteres;
        }
    }
}
