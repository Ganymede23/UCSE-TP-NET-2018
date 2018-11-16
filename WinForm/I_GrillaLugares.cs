using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace WinForm
{
    interface I_GrillaLugares
    {
        void CrearArchivos();
        ResultadoOp AltaLugares(LugarDePago lugar);
        ResultadoOp ModificacionLugar(LugarDePago lugar, bool eliminar);
    }
}
