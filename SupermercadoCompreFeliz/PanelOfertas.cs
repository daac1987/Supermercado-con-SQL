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
    public partial class PanelOfertas : UserControl
    {
        public PanelOfertas()
        {
            InitializeComponent();
            mostraOfertas();
        }
        DateTime inicio;
        DateTime final;
        int idProducto;
        float descuento;
        float montoTotal;
        string fechaInicialString;
        string fechaFinalString;
        float montoConDescuento;
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (CapturarTxt() == true)
            {
                datosOfertas.InsertarCompras(CrearOfertas());
                BorrarTxt();
                mostraOfertas();
            }
        }
        //para extraer la fechas
        private void btnFechas_Click(object sender, EventArgs e)
        {
            inicio = calendario.SelectionStart;
            txtFechaInico.Text = inicio.ToString(("dd'/'MM'/'yyyy"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            final = calendario.SelectionEnd;
            txtFinal.Text = final.ToString(("dd'/'MM'/'yyyy"));
        }

        public Boolean CapturarTxt()
        //validar si todas la cajas de texto fueron llenas correctamente
        //devuelve falso si hay ingreso incorrecto y verdadero si todo esta bien
        //los if es para verificar que los campos no esten vacios
        {
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
                montoTotal = float.Parse(txtMontoDescuento.Text);
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
                MessageBox.Show("Error se espera en casilla monto un numero: " + e.Message);
                return false;
            }
            if (txtFechaInico.Text.Equals(""))
            {
                MessageBox.Show("Error no ingreso fecha inicial");
                return false;
            }
            else
            {
                fechaInicialString = txtFechaInico.Text;
            }
            if (txtFinal.Text.Equals(""))
            {
                MessageBox.Show("Error no ingreso fecha inicial");
                return false;
            }
            else
            {
                fechaFinalString = txtFinal.Text;
            }
            return true;
        }

        Ofertas CrearOfertas()
        {
            //id va a ser auto incrementado en base de datos
            Ofertas ofertas = new Ofertas( idProducto, fechaInicialString, fechaFinalString, descuento, montoConDescuento,0);
            return ofertas;
        }

        public void BorrarTxt()
        {
            txtIdProducto.Text = "";
            txtFechaInico.Text = "";
            txtFinal.Text = "";
            txtMontoDescuento.Text = "";
            cbDescuento.SelectedIndex = -1;
            txtMontoInicial.Text = "";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                if (CapturarTxt() == true)
                {
                    Ofertas ofertas = new Ofertas(idProducto, fechaInicialString, fechaFinalString, descuento, montoConDescuento, id);
                    datosOfertas.ModificarOferta(ofertas);
                    BorrarTxt();
                    mostraOfertas();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProducto.Text = table.SelectedCells[1].Value.ToString();
            txtFechaInico.Text = table.SelectedCells[2].Value.ToString();
            txtFinal.Text = table.SelectedCells[3].Value.ToString();            
            txtMontoDescuento.Text = table.SelectedCells[5].Value.ToString();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void mostraOfertas()
        {
            datosOfertas datosOfertas = new datosOfertas();
            DataTable dt = new DataTable();
            datosOfertas.mostrarOferta(ref dt);
            table.DataSource = dt;
        }

        private void btnInsertarDescuento_Click(object sender, EventArgs e)
        {
            porcentajeDescuento();
            float montoInicial = int.Parse(txtMontoInicial.Text);

            switch (cbDescuento.SelectedIndex)
            {
                case 0:
                    txtMontoDescuento.Text = montoInicial.ToString();
                    break;
                case 1:
                    montoConDescuento = montoInicial - ((montoInicial * descuento) / 100);
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
