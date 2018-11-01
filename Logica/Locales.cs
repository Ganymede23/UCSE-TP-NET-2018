using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Locales
    {
        public int ID { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public int CP { get; set; }

        public abstract bool ValidarObligatorios();
    }
}
