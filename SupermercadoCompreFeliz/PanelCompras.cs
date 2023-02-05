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
using System.Windows.Forms.VisualStyles;

namespace SupermercadoCompreFeliz
{
    public partial class PanelCompras : UserControl
    {
        public PanelCompras()
        {
            InitializeComponent();
            FechaInico();
            mostraCompras();
        }
        int idEmpleado;
        int idCliente;
        int idProducto;
        string fecha;
        float descuento;
        float montoTotal;
        float montoConDescuento;

        //metodo para tener la fecha actullizada
        public void FechaInico()
        {
            DateTime dt = DateTime.Now;
            txtFechaInico.Text = dt.ToString(("dd'/'MM'/'yyyy"));
        }

        public Boolean CapturarTxt()
        //validar si todas la cajas de texto fueron llenas correctamente
        //devuelve falso si hay ingreso incorrecto y verdadero si todo esta bien
        //los if es para verificar que los campos no esten vacios
        {
            try
            {
                idEmpleado = int.Parse(txtIdEmpleado.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error se espera en casilla id empleado un numero: " + e.Message);
                return false;
            }
            try
            {
                idCliente = int.Parse(txtIdCliente.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error se espera en casilla id cliente un numero: " + e.Message);
                return false;
            }
            try
            {
                idProducto = int.Parse(txtIdProducto.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error se espera en casilla codigo un numero: " + e.Message);
                return false;
            }
            if (cbDescuento.SelectedIndex == -1)
            {
                MessageBox.Show("No selecciono descuento");
                return false;
            }
            else
            {
                porcentajeDescuento();
            }
            try
            {
                montoTotal = float.Parse(txtMonto.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error se espera en casilla monto un numero: " + e.Message);
                return false;
            }
            try
            {
                montoConDescuento = float.Parse(txtMontoDescuento.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error se espera en casilla monto con descuento un numero: " + e.Message);
                return false;
            }
            if (txtFechaInico.Text.Equals(""))
            {
                MessageBox.Show("Error no ingreso fecha inicial");
                return false;
            }
            else
            {
                fecha = txtFechaInico.Text;
            }
            return true;
        }

        Compras CrearCompra()
        {
            //id va a ser auto incrementado en base de datos
            Compras compras = new Compras(idEmpleado,idCliente,idProducto,fecha,descuento,montoConDescuento,0);
            return compras;
        }

        public void BorrarTxt()
        {
            txtIdEmpleado.Text = "";
            txtIdCliente.Text = "";
            txtIdProducto.Text = "";
            txtFechaInico.Text = "";
            txtMonto.Text = "";
            txtMontoDescuento.Text = "";
            txtidcompra.Text = "";
            cbDescuento.SelectedIndex = -1;
            FechaInico();
        }
        public void porcentajeDescuento()
        {
            switch (cbDescuento.SelectedIndex)
            {
                case 0:
                    descuento = 0;
                    break;
                case 1:
                    descuento = 5;
                    break;
                case 2:
                    descuento = 10;
                    break;
                case 3:
                    descuento = 15;
                    break;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (CapturarTxt() == true)
            {
                DatosCompras.InsertarCompras(CrearCompra());
                BorrarTxt();
                mostraCompras();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                DatosCompras.BorrarCompra(id);
                BorrarTxt();
                mostraCompras();
            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }
        }

        private void mostraCompras()
        {
            DatosCompras compras = new DatosCompras();
            DataTable dt = new DataTable();
            compras.mostrarCompra(ref dt);
            table.DataSource = dt;
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcompra.Text = table.SelectedCells[0].Value.ToString();
            txtIdEmpleado.Text = table.SelectedCells[1].Value.ToString();
            txtIdCliente.Text = table.SelectedCells[2].Value.ToString();
            txtIdProducto.Text = table.SelectedCells[3].Value.ToString();
            txtFechaInico.Text = table.SelectedCells[4].Value.ToString();
            txtMontoDescuento.Text = table.SelectedCells[6].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                if (CapturarTxt() == true)
                {
                    Compras compras = new Compras(idEmpleado, idCliente, idProducto, fecha, descuento, montoConDescuento, id);
                    DatosCompras.ModificarCompra(compras);
                    BorrarTxt();
                    mostraCompras();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }
        }


        private void btnDescuento_Click(object sender, EventArgs e)
        {
            porcentajeDescuento();
            float montoInicial = int.Parse(txtMonto.Text);
            
            switch (cbDescuento.SelectedIndex)
            {
                case 0:
                    txtMontoDescuento.Text = montoInicial.ToString();
                    break;
                case 1:
                    montoConDescuento = montoInicial-((montoInicial * descuento) / 100);
                    txtMontoDescuento.Text = montoConDescuento.ToString();
                    break;
                case 2:
                    montoConDescuento = montoInicial - ((montoInicial * descuento) / 100);
                    txtMontoDescuento.Text = montoConDescuento.ToString();
                    break;
                case 3:
                    montoConDescuento = montoInicial - ((montoInicial * descuento) / 100);
                    txtMontoDescuento.Text = montoConDescuento.ToString();
                    break;

            }
        }
    }
}
