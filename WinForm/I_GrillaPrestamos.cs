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
        ResultadoOp CrearArchivos();
        ResultadoOp AltaPrestamos(Prestamo prestamo);
        ResultadoOp RegistroPagos(Prestamo prestamo, LugarDePago lugar);
        List<Sucursal> ObtenerSucursales();
        List<Cliente> ObtenerClientes();
        List<Comercio> ObtenerComercios();
        List<LugarDePago> ObtenerLugares();
        List<Pago> ObtenerRegistrosPagos(Prestamo prestamo);
    }
}
