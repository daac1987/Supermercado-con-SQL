using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoCompreFeliz.Clases
{
    internal class Empleado:Persona
    {
        private float salario;
        private string puesto;

        public Empleado(int id, string name, float salario, string puesto) : base(id, name)
        {
            this.salario = salario;
            this.puesto = puesto;
        }

        public float Salario { get => salario; set => salario = value; }
        public string Puesto { get => puesto; set => puesto = value; }
    }
}
