using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace WinForm
{
    interface I_ExaminarPrestamo
    {
        ResultadoOp RegistroPagos(Prestamo prestamo, LugarDePago lugar);
        List<LugarDePago> ObtenerLugares();
        void ActualizarGrillaPagos(Prestamo prestamo);
    }
}
