using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace WinForm
{
    interface I_GrillaPrestamos
    {
        void CrearArchivos();
        ResultadoOp AltaPrestamos(Prestamo prestamo);
        List<Sucursal> ObtenerSucursales();
        List<Cliente> ObtenerClientes();
        List<Comercio> ObtenerComercios();
        //List<Pago> ObtenerRegistrosPagos();
    }
}
