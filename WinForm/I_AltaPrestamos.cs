﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace WinForm
{
    interface I_AltaPrestamos
    {
        List<Prestamo> ObtenerComercios();
        List<Sucursal> ObtenerSucursales();
    }
}
