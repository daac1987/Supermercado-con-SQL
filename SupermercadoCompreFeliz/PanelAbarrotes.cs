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
    public partial class PanelAbarrotes : UserControl
    {
        public PanelAbarrotes()
        {
            InitializeComponent();
            mostraAbarrotes();
        }
        string nombre;
        string descripcion;
        string tamaño;
        int cantidad;

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (CapturarTxt() == true)
            {
                DatosAbarrotes.InsertarAbarrotes(CrearAbarrotes()); 
                BorrarTxt();
                mostraAbarrotes();
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

        Abarrotes CrearAbarrotes()
        {
            //id va a ser auto incrementado en base de datos
            Abarrotes abarrotes= new Abarrotes(0, nombre, descripcion, tamaño, cantidad, "Abarrotes");
            return abarrotes;
        }

        public void BorrarTxt()
        {
            textNombre.Text = "";
            textDescripcion.Text = "";
            txtCantidad.Text = "";
            cbTamaño.SelectedItem = -1;
            IdArticulo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                if (CapturarTxt() == true)
                {
                    Abarrotes abarrotes = new Abarrotes(id,nombre,descripcion,tamaño,cantidad,"Abarrotes");
                    DatosAbarrotes.ModificarAbarrotes(abarrotes);
                    BorrarTxt();
                    mostraAbarrotes();
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
                DatosAbarrotes.BorrarAbarrotes(id);
                BorrarTxt();
                mostraAbarrotes();
            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdArticulo.Text = table.SelectedCells[0].Value.ToString();
            textNombre.Text = table.SelectedCells[1].Value.ToString();
            textDescripcion.Text = table.SelectedCells[2].Value.ToString();
            txtCantidad.Text = table.SelectedCells[4].Value.ToString();
            cbTamaño.SelectedIndex = -1;
        }

        private void mostraAbarrotes()
        {
            DatosAbarrotes datosAbarrotes = new DatosAbarrotes();
            DataTable dt = new DataTable();
            datosAbarrotes.mostrarAbarrotes(ref dt);
            table.DataSource = dt;
        }
    }
}
