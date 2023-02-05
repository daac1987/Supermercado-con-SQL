using SupermercadoCompreFeliz.Clases;
using SupermercadoCompreFeliz.ConexionBD;
using System.Data;

namespace SupermercadoCompreFeliz
{
    public partial class PanelClientes : UserControl
    {
        public PanelClientes()
        {
            InitializeComponent();
            mostraClientes();
        }
        int id;
        string nombre;
        string direccion;
        string tipoCliente;

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                DatosClientes.BorrarClientes(id);
                mostraClientes();
                BorrarTxt();
            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (CapturarTxt()==true)
            {
                DatosClientes.InsertarCliente(CrearCl());
                BorrarTxt();
                mostraClientes();
            }  
        }

        public Boolean CapturarTxt()
        //validar si todas la cajas de texto fueron llenas correctamente
        //devuelve falso si hay ingreso incorrecto y verdadero si todo esta bien
        //los if es para verificar que los campos no esten vacios
        {
            try
            {
                id = int.Parse(txtIdCliente.Text);
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
            if (textDireccion.Text.Equals(""))
            {
                MessageBox.Show("Error la casilla direccion no esta llena");
                return false;
            }
            else
            {
                direccion = textDireccion.Text;
            }
            if (cbTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("No selecciono genero");
                return false;
            }
            else {
                tipoCliente = cbTipoCliente.Text;
            }
            return true;
        }

         Cliente CrearCl()
        {
            Cliente cliente = new Cliente(id,nombre,direccion,tipoCliente);
            return cliente;
        }

        public void BorrarTxt()
        {
            txtIdCliente.Text = "";
            textNombre.Text = "";
            textDireccion.Text = "";
            cbTipoCliente.SelectedIndex = -0;
            txtTipo.Text = "";
        }
        private void mostraClientes()
        {
            DatosClientes clientes = new DatosClientes();
            DataTable dt = new DataTable();
            clientes.mostrarClientes(ref dt);
            table.DataSource = dt;
        }

        private void dataClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txtIdCliente.Text = table.SelectedCells[0].Value.ToString();
                textNombre.Text = table.SelectedCells[1].Value.ToString();
                textDireccion.Text = table.SelectedCells[2].Value.ToString();
                txtTipo.Text = table.SelectedCells[3].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(table.SelectedCells[0].Value.ToString());
                if (CapturarTxt() == true)
                {
                    DatosClientes.ModificarClientes(CrearCl());
                    mostraClientes();
                    BorrarTxt();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No selecciono fila");
            }

        }
    }


}
