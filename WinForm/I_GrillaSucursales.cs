using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace WinForm
{
    interface I_GrillaSucursales
    {
        void CrearArchivos();
        ResultadoOp AltaSucursales(Sucursal sucursal);
        ResultadoOp ModificacionSucursal(Sucursal sucursal, bool eliminar);
    }
}
