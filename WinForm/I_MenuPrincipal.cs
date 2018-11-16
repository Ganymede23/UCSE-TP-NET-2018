using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace WinForm
{
    interface I_MenuPrincipal
    {
        void CrearArchivos();

        ResultadoOp AltaClientes(Cliente cliente);
        ResultadoOp ModificacionCliente(Cliente cliente, bool eliminar);
        List<Cliente> ObtenerClientes();

        ResultadoOp AltaPrestamos(Prestamo prestamo);
        ResultadoOp ModificacionPrestamos(Prestamo Prestamo, bool eliminar);
        List<Prestamo> ObtenerPrestamos(DateTime? fechaDesde, DateTime? fechaHasta, TipoCliente? tipoCliente, string nombre);

        List<Prestamo> ObtenerRegistrosPagos();
        ResultadoOp RegistroPagos(Prestamo prestamo, LugarDePago lugar);

        ResultadoOp AltaSucursales(Sucursal sucursal);
        ResultadoOp ModificacionSucursal(Sucursal sucursal, bool eliminar);
        List<Sucursal> ObtenerSucursales();

        ResultadoOp AltaComercios(Comercio cliente);
        ResultadoOp ModificacionComercio(Comercio cliente, bool eliminar);
        List<Comercio> ObtenerComercios();

        ResultadoOp AltaLugares(LugarDePago lugar);
        ResultadoOp ModificacionLugar(LugarDePago lugar, bool eliminar);
        List<LugarDePago> ObtenerLugares();
    }
}
