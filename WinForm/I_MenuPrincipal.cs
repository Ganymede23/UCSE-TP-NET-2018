﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace WinForm
{
    interface I_MenuPrincipal
    {
        ResultadoOp CrearArchivos();
        ResultadoOp AltaClientes(Cliente cliente);
        ResultadoOp ModificacionCliente(Cliente cliente, bool eliminar);
        List<Cliente> ObtenerClientes();

        ResultadoOp AltaComercios(Comercio cliente);
        ResultadoOp ModificacionComercio(Comercio cliente, bool eliminar);
        List<Comercio> ObtenerComercios();
    }
}
