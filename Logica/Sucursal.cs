using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Sucursal : Locales
    {
        public decimal TasaInteres { get; set; }

        public Sucursal()
        {
            Activo = true;
        }

        public Sucursal(int iD, string ciudad, string direccion, int cP, decimal tasaInteres)
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
            if (Ciudad!="" && Direccion!="" && CP!=0 && TasaInteres!=0.0M)
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
