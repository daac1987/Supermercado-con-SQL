using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoCompreFeliz.Clases
{
    internal class Proveedor:Persona
    {
        private int idProducto;

        public Proveedor(int id, string name, int idProducto) : base(id, name)
        {
            this.idProducto = idProducto;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
    }
}
