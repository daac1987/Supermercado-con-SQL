using SupermercadoCompreFeliz.Clases;

namespace SupermercadoCompreFeliz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAcpetar_Click(object sender, EventArgs e)
        {
            //traemos la eleccion de el combo box
            panelPrincipal.Controls.Clear();
            switch (cbOpcion.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("No ingreso eleccion");
                    break;
                case 0:
                    PanelEmpleados panelEmpleado = new PanelEmpleados();
                    panelEmpleado.Dock = DockStyle.Fill;
                    panelPrincipal.Controls.Add(panelEmpleado);
                    break;
                case 1:
                    PanelClientes panelClientes = new PanelClientes();
                    panelClientes.Dock = DockStyle.Fill;
                    panelPrincipal.Controls.Add(panelClientes);
                    break;
                case 2:
                    PanelProvedor   panelProvedor = new PanelProvedor();
                    panelProvedor.Dock = DockStyle.Fill;
                    panelPrincipal.Controls.Add(panelProvedor);
                    break;
                case 3:
                    PanelDulces panelDulces = new PanelDulces();    
                    panelDulces.Dock = DockStyle.Fill;
                    panelPrincipal.Controls.Add(panelDulces);
                    break;
                case 4:
                    PanelAbarrotes panelAbarrotes = new PanelAbarrotes();
                    panelAbarrotes.Dock = DockStyle.Fill;
                    panelPrincipal.Controls.Add(panelAbarrotes);
                    break;
                case 5:
                    PanelAseoPersonal aseoPersonal = new PanelAseoPersonal();  
                    aseoPersonal.Dock = DockStyle.Fill;
                    panelPrincipal.Controls.Add(aseoPersonal);
                    break;
                case 6:
                    PanelOfertas panelOfertas = new PanelOfertas();
                    panelOfertas.Dock = DockStyle.Fill;
                    panelPrincipal.Controls.Add(panelOfertas);
                    break;
                case 7:
                    PanelCompras panelCompras = new PanelCompras();
                    panelCompras.Dock = DockStyle.Fill;
                    panelPrincipal.Controls.Add(panelCompras);
                    break;


            }
        }
    }
}