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
    public partial class PanelProvedor : UserControl
    {
        public PanelProvedor()
        {
            InitializeComponent();
            mostraClientes();
        }
        int id;
        string nombre;
        int idProducto;
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (CapturarTxt() == true)
            {
                DatosProveedor.InsertarProvedor(CrearProv());
                mostraClientes();
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
                id = int.Parse(txtIdProvedor.Text);
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
                idProducto = int.Parse(textIdProducto.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error se espera en casilla id producto un numero: " + e.Message);
                return false;
            }
            return true;    
        }

        Proveedor CrearProv()
        {
            Proveedor proveedor = new Proveedor(id,nombre,idProducto);
            return proveedor;
        }

        public void BorrarTxt()
        {
            txtIdProvedor.Text = "";
            textNombre.Text = "";
            textIdProducto.Text = "";
        }

        private void mostraClientes()
        {
            DatosProveedor proveedor = new DatosProveedor();
            DataTable dt = new DataTable();
            proveedor.mostrarProvedor(ref dt);
            table.DataSource = dt;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                if (CapturarTxt() == true)
                {
                    DatosProveedor.ModificarProvedor(CrearProv());
                    mostraClientes();
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
            txtIdProvedor.Text = table.SelectedCells[0].Value.ToString();
            textNombre.Text = table.SelectedCells[1].Value.ToString();
            textIdProducto.Text = table.SelectedCells[2].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                DatosProveedor.BorrarProvedor(id);
                mostraClientes();
                BorrarTxt();
            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }
        }
    }
}
