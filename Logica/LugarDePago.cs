using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LugarDePago : Comercio
    {
        public bool EsSucursal { get; set; }

        public LugarDePago(int iD, string ciudad, string direccion, int cP, string razonSocial, bool esSucursal)
        {
            ID = iD;
            Ciudad = ciudad;
            Direccion = direccion;
            CP = cP;
            RazonSocial = razonSocial;
            EsSucursal = esSucursal;
            Activo = true;
        }

        public LugarDePago()
        {
            Activo = true;
        }

        public override string ToString()
        {
            return RazonSocial;
        }
    }
}
