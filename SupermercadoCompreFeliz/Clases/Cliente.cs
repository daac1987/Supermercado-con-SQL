using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoCompreFeliz.Clases
{
    internal class Cliente:Persona
    {
        private string direccion;
        private string tipoCliente;

        public Cliente(int id, string name, string direccion, string tipoCliente) : base(id, name)
        {
            this.direccion = direccion;
            this.tipoCliente = tipoCliente;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }
    }
}
