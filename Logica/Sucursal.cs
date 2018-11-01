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
            Activo = true;
        }

        public Sucursal(int iD, string ciudad, string direccion, int cP, double tasaInteres)
        {
            ID = iD;
            Ciudad = ciudad;
            Direccion = direccion;
            CP = cP;
            TasaInteres = tasaInteres;
            Activo = true;
        }

        public override bool ValidarObligatorios()
        {
            if (ID!=0 && Ciudad!="" && Direccion!="" && CP!=0 && TasaInteres!=0.0D)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
