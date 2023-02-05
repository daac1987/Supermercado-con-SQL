namespace SupermercadoCompreFeliz
{
    partial class PanelOfertas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMontoDescuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDescuento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.txtFechaInico = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnInicial = new System.Windows.Forms.Button();
            this.btnfechaFinal = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertarDescuento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMontoDescuento
            // 
            this.txtMontoDescuento.Location = new System.Drawing.Point(218, 480);
            this.txtMontoDescuento.Name = "txtMontoDescuento";
            this.txtMontoDescuento.ReadOnly = true;
            this.txtMontoDescuento.Size = new System.Drawing.Size(100, 33);
            this.txtMontoDescuento.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 84;
            this.label4.Text = "Monto con descuento";
            // 
            // cbDescuento
            // 
            this.cbDescuento.AutoCompleteCustomSource.AddRange(new string[] {
            "Sin Decuento",
            "5%",
            "10%",
            "15%"});
            this.cbDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescuento.FormattingEnabled = true;
            this.cbDescuento.Items.AddRange(new object[] {
            "Sin descuento",
            "5%",
            "10%",
            "15%"});
            this.cbDescuento.Location = new System.Drawing.Point(186, 419);
            this.cbDescuento.Name = "cbDescuento";
            this.cbDescuento.Size = new System.Drawing.Size(132, 33);
            this.cbDescuento.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "Descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 81;
            this.label5.Text = "Ofertas";
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(16, 48);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowTemplate.Height = 25;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(753, 232);
            this.table.TabIndex = 80;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrar.Location = new System.Drawing.Point(510, 358);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(124, 41);
            this.btnBorrar.TabIndex = 79;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsertar.Location = new System.Drawing.Point(510, 284);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(124, 41);
            this.btnInsertar.TabIndex = 78;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Fecha Inicio";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(186, 298);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(132, 33);
            this.txtIdProducto.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Codigo Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 643);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 86;
            this.label6.Text = "Fecha Final";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(16, 537);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 88;
            // 
            // txtFechaInico
            // 
            this.txtFechaInico.Location = new System.Drawing.Point(346, 570);
            this.txtFechaInico.Name = "txtFechaInico";
            this.txtFechaInico.Size = new System.Drawing.Size(132, 33);
            this.txtFechaInico.TabIndex = 89;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(346, 640);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(132, 33);
            this.txtFinal.TabIndex = 90;
            // 
            // btnInicial
            // 
            this.btnInicial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInicial.Location = new System.Drawing.Point(510, 565);
            this.btnInicial.Name = "btnInicial";
            this.btnInicial.Size = new System.Drawing.Size(124, 41);
            this.btnInicial.TabIndex = 91;
            this.btnInicial.Text = "Ingresar F-I";
            this.btnInicial.UseVisualStyleBackColor = true;
            this.btnInicial.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // btnfechaFinal
            // 
            this.btnfechaFinal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnfechaFinal.Location = new System.Drawing.Point(510, 640);
            this.btnfechaFinal.Name = "btnfechaFinal";
            this.btnfechaFinal.Size = new System.Drawing.Size(124, 41);
            this.btnfechaFinal.TabIndex = 92;
            this.btnfechaFinal.Text = "Ingresar F-F";
            this.btnfechaFinal.UseVisualStyleBackColor = true;
            this.btnfechaFinal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(510, 432);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 41);
            this.btnModificar.TabIndex = 93;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.Location = new System.Drawing.Point(186, 363);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(132, 33);
            this.txtMontoInicial.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 94;
            this.label7.Text = "Monto Inicial";
            // 
            // btnInsertarDescuento
            // 
            this.btnInsertarDescuento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsertarDescuento.Location = new System.Drawing.Point(354, 419);
            this.btnInsertarDescuento.Name = "btnInsertarDescuento";
            this.btnInsertarDescuento.Size = new System.Drawing.Size(124, 41);
            this.btnInsertarDescuento.TabIndex = 96;
            this.btnInsertarDescuento.Text = "Inertar Desc";
            this.btnInsertarDescuento.UseVisualStyleBackColor = true;
            this.btnInsertarDescuento.Click += new System.EventHandler(this.btnInsertarDescuento_Click);
            // 
            // PanelOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnInsertarDescuento);
            this.Controls.Add(this.txtMontoInicial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnfechaFinal);
            this.Controls.Add(this.btnInicial);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtFechaInico);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontoDescuento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDescuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PanelOfertas";
            this.Size = new System.Drawing.Size(793, 708);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMontoDescuento;
        private Label label4;
        private ComboBox cbDescuento;
        private Label label1;
        private Label label5;
        private DataGridView table;
        private Button btnBorrar;
        private Button btnInsertar;
        private Label label3;
        private TextBox txtIdProducto;
        private Label label2;
        private Label label6;
        private MonthCalendar calendario;
        private TextBox txtFechaInico;
        private TextBox txtFinal;
        private Button btnInicial;
        private Button btnfechaFinal;
        private Button btnModificar;
        private TextBox txtMontoInicial;
        private Label label7;
        private Button btnInsertarDescuento;
    }
}
