using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ResultadoOp
    {
        public bool Resultado { get; set; }
        public string Mensaje { get; set; }

        public ResultadoOp()
        {
            Resultado=true;
        }

        public ResultadoOp(bool resultado, string mensaje)
        {
            Resultado = resultado;
            Mensaje = mensaje;
        }
    }
}
