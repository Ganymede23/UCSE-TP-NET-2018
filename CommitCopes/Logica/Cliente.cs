using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public enum TipoDocumento
    {
        LE=1,LC=2,DNI=3
    }
    public enum Sexo
    {
        Hombre=1,Mujer=2
    }
    public enum TipoCliente
    {
        Regular=1,VIP=2
    }
    public class Cliente
    {
        public int ID { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public int NroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public DateTime FNac { get; set; }
        public Sexo Sexo { get; set; }
        public string Domicilio { get; set; }
        public int CP { get; set; }
        public string Localidad { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public int MontoMaximo { get; set; }
        public bool Activo { get; set; }

        public Cliente(TipoDocumento tipoDocumento, int nroDocumento, string nombre, string correo, string celular, DateTime fNac, Sexo sexo, string domicilio, int cP, string localidad, TipoCliente tipoCliente, int montoMaximo)
        {
            ID = ID;
            TipoDocumento = tipoDocumento;
            NroDocumento = nroDocumento;
            Nombre = nombre;
            Correo = correo;
            Celular = celular;
            FNac = fNac;
            Sexo = sexo;
            Domicilio = domicilio;
            CP = cP;
            Localidad = Localidad;
            TipoCliente = tipoCliente;
            MontoMaximo = montoMaximo;
            Activo = true;
        }

        public Cliente()
        {
            Activo = true;
        }

        public bool ValidarObligatorios()
        {
            if (TipoDocumento != 0 && NroDocumento != 0 && Nombre!="" && Correo!="" && TipoCliente!=0 && MontoMaximo>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
