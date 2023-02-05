using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoCompreFeliz.Clases
{
    internal class Compras
    {
        private int idCompra;
        private int idEmpleado;
        private int idCliente;
        private int idProducto;
        private string fecha;
        private float descuento;
        private float montoTotal;

        public Compras(int idEmpleado,
                       int idCliente,
                       int idProducto,
                       string fecha,
                       float descuento,
                       float montoTotal,
                       int idCompra)
        {
            this.idEmpleado = idEmpleado;
            this.idCliente = idCliente;
            this.idProducto = idProducto;
            this.fecha = fecha;
            this.descuento = descuento;
            this.montoTotal = montoTotal;
            this.idCompra = idCompra;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public float Descuento { get => descuento; set => descuento = value; }
        public float MontoTotal { get => montoTotal; set => montoTotal = value; }
        public int IdCompra { get => idCompra; set => idCompra = value; }
    }
}
