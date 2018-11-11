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
    }
}
