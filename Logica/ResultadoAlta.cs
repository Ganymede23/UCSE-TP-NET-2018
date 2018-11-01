using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ResultadoAlta
    {
        public bool Resultado { get; set; }
        public string Mensaje { get; set; }

        public ResultadoAlta(bool resultado)
        {
            Resultado = resultado;
        }

        public ResultadoAlta(bool resultado, string mensaje)
        {
            Resultado = resultado;
            Mensaje = mensaje;
        }
    }
}
