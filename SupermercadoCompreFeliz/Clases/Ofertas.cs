using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoCompreFeliz.Clases
{
    internal class Ofertas
    {
        private int idOfertas;
        private int idProducto;
        private string fechaInicio;
        private string fechafinal;
        private float descuento;
        private float montoTotal;

        public Ofertas(int idProducto,
                       string fechaInicio,
                       string fechafinal,
                       float descuento,
                       float montoTotal,
                       int idOfertas)
        {
            this.idProducto = idProducto;
            this.fechaInicio = fechaInicio;
            this.fechafinal = fechafinal;
            this.descuento = descuento;
            this.montoTotal = montoTotal;
            this.idOfertas = idOfertas;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string Fechafinal { get => fechafinal; set => fechafinal = value; }
        public float Descuento { get => descuento; set => descuento = value; }
        public float MontoTotal { get => montoTotal; set => montoTotal = value; }
        public int IdOfertas { get => idOfertas; set => idOfertas = value; }
    }
}
