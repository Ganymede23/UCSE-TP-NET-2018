using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Comercio : Locales
    {
        public string RazonSocial { get; set; }

        public Comercio()
        {

        }

        public Comercio(int iD, string ciudad, string direccion, int cP, string razonSocial)
        {
            ID = iD;
            Ciudad = ciudad;
            Direccion = direccion;
            CP = cP;
            RazonSocial = razonSocial;
        }
    }
}
