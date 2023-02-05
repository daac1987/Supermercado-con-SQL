using SupermercadoCompreFeliz.Clases;
using SupermercadoCompreFeliz.ConexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoCompreFeliz
{
    public partial class PanelEmpleados : UserControl
    {
        public PanelEmpleados()
        {
            InitializeComponent();
            mostraEmpleados();
        }
        int id;
        string nombre;
        float salario;
        string puesto;
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (CapturarTxt() == true)
            {
                //crearEmp me devueve un empleado y
                //insertarEmpleado necesita de parametro un empleado
                //DatosEmpleados datosEmpleados = new DatosEmpleados();
                DatosEmpleados.InsertarEmpleados(CrearEmp());
                mostraEmpleados();
                BorrarTxt();
            }
        }

        public Boolean CapturarTxt()
        //validar si todas la cajas de texto fueron llenas correctamente
        //devuelve falso si hay ingreso incorrecto y verdadero si todo esta bien
        //los if es para verificar que los campos no esten vacios
        {
            try
            {
                id = int.Parse(txtIdEmp.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error se espera en casilla cedula un numero: " + e.Message);
                return false;
            }
            if (textNombre.Text.Equals(""))
            {
                MessageBox.Show("Error la casilla nombre no esta llena");
                return false;
            }
            else
            {
                nombre = textNombre.Text;
            }
            try
            {
                salario = float.Parse(textSalario.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error se espera en casilla salario un numero: " + e.Message);
                return false;
            }

            if (cbPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("No selecciono genero");
                return false;
            }
            else
            {
                puesto = cbPuesto.Text;
            }
            return true;
        }

        Empleado CrearEmp()
        {
            Empleado empleado = new Empleado(id, nombre, salario, puesto);
            return empleado;
        }

        public void BorrarTxt()
        {
            txtIdEmp.Text = "";
            textNombre.Text = "";
            textSalario.Text = "";
            cbPuesto.SelectedItem = -0;
            txtPuesto.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                DatosEmpleados.BorrarEmpleados(id);
                mostraEmpleados();
                BorrarTxt();
            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }

        }

        private void mostraEmpleados()
        {
            DatosEmpleados datosEmpleados = new DatosEmpleados();
            DataTable dt = new DataTable();
            datosEmpleados.mostraEmpleados(ref dt);
            table.DataSource=dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                if (CapturarTxt() == true)
                {
                    DatosEmpleados.ModificarEmpleados(CrearEmp());
                    mostraEmpleados();
                    BorrarTxt();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEmp.Text = table.SelectedCells[0].Value.ToString();
            textNombre.Text = table.SelectedCells[1].Value.ToString();
            textSalario.Text = table.SelectedCells[2].Value.ToString();
            txtPuesto.Text = table.SelectedCells[3].Value.ToString();
        }
    }
}
