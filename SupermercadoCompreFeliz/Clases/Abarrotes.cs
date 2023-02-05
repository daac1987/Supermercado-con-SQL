using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoCompreFeliz.Clases
{
    internal class Abarrotes:Articulos
    {
        private string categoria;

        public Abarrotes(int id, string name, string descripcion, string tamaño, int cantidad, string categoria) : base(id, name, descripcion, tamaño, cantidad)
        {
            this.categoria = categoria;
        }

        public string Categoria { get => categoria; set => categoria = value; }
    }
}
