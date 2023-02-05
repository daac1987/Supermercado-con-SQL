using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoCompreFeliz.Clases
{
    internal class Articulos
    {
        private int id;
        private string name;
        private string descripcion;
        private string tamaño;
        private int cantidad;
        private string categoria;


        public Articulos(int id, string name, string descripcion, string tamaño, int cantidad)
        {
            this.id = id;
            this.name = name;
            this.descripcion = descripcion;
            this.tamaño = tamaño;
            this.cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
