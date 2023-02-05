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
    public partial class PanelAseoPersonal : UserControl
    {
        public PanelAseoPersonal()
        {
            InitializeComponent();
            mostraAseoPersonal();
        }
        string nombre;
        string descripcion;
        string tamaño;
        int cantidad;

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (CapturarTxt() == true)
            {
                DatosAseoPersonal.InsertarAseoPersonal(CrearAseoPersonal());
                BorrarTxt();
                mostraAseoPersonal();
            }
        }

        public Boolean CapturarTxt()
        //validar si todas la cajas de texto fueron llenas correctamente
        //devuelve falso si hay ingreso incorrecto y verdadero si todo esta bien
        //los if es para verificar que los campos no esten vacios
        {
            if (textNombre.Text.Equals(""))
            {
                MessageBox.Show("Error la casilla nombre no esta llena");
                return false;
            }
            else
            {
                nombre = textNombre.Text;
            }
            if (textDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Error la casilla descripcion no esta llena");
                return false;
            }
            else
            {
                descripcion = textDescripcion.Text;
            }
            if (cbTamaño.SelectedIndex == -1)
            {
                MessageBox.Show("No selecciono tamaño");
                return false;
            }
            else
            {
                tamaño = cbTamaño.Text;
            }
            try
            {
                cantidad = int.Parse(txtCantidad.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error se espera en casilla cantidad un numero: " + e.Message);
                return false;
            }
            return true;
        }

        AseoPersonal CrearAseoPersonal()
        {
            //id va a ser auto incrementado en base de datos
            AseoPersonal aseoPersonal= new AseoPersonal(0, nombre, descripcion, tamaño, cantidad, "Aseo Personal");
            return aseoPersonal;
        }

        public void BorrarTxt()
        {
            textNombre.Text = "";
            textDescripcion.Text = "";
            txtCantidad.Text = "";
            cbTamaño.SelectedItem = -1;
            idArticulo.Text = "";
        }

        private void dataClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idArticulo.Text = table.SelectedCells[0].Value.ToString();
            textNombre.Text = table.SelectedCells[1].Value.ToString();
            textDescripcion.Text = table.SelectedCells[2].Value.ToString();
            txtCantidad.Text = table.SelectedCells[4].Value.ToString();
            cbTamaño.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                if (CapturarTxt() == true)
                {
                    AseoPersonal aseoPersonal = new AseoPersonal(id, Name, descripcion, tamaño, cantidad, "Aseo Personal");
                    DatosAseoPersonal.ModificarAseoPersonal(aseoPersonal);
                    BorrarTxt();
                    mostraAseoPersonal();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                DatosAseoPersonal.BorrarAseoPersonal(id);
                BorrarTxt();
                mostraAseoPersonal();
            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }
        }
        private void mostraAseoPersonal()
        {
            DatosAseoPersonal datosAseoPersonal = new DatosAseoPersonal();
            DataTable dt = new DataTable();
            datosAseoPersonal.mostrarAseoPersonal(ref dt);
            table.DataSource = dt;
        }
    }
}
