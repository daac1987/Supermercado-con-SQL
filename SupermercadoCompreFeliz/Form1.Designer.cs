namespace SupermercadoCompreFeliz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.cbOpcion = new System.Windows.Forms.ComboBox();
            this.Opciones = new System.Windows.Forms.Label();
            this.btnAcpetar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPrincipal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelPrincipal.Location = new System.Drawing.Point(241, 2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(768, 683);
            this.panelPrincipal.TabIndex = 0;
            // 
            // cbOpcion
            // 
            this.cbOpcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcion.FormattingEnabled = true;
            this.cbOpcion.Items.AddRange(new object[] {
            "Empleados",
            "Clientes",
            "Proveedor",
            "Dulces ",
            "Abarrotes",
            "Aseo Personal",
            "Ofertas",
            "Compras"});
            this.cbOpcion.Location = new System.Drawing.Point(12, 145);
            this.cbOpcion.Name = "cbOpcion";
            this.cbOpcion.Size = new System.Drawing.Size(223, 33);
            this.cbOpcion.TabIndex = 0;
            this.cbOpcion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Opciones
            // 
            this.Opciones.AutoSize = true;
            this.Opciones.Location = new System.Drawing.Point(76, 101);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(91, 25);
            this.Opciones.TabIndex = 0;
            this.Opciones.Text = "Opciones";
            // 
            // btnAcpetar
            // 
            this.btnAcpetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcpetar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAcpetar.Location = new System.Drawing.Point(73, 390);
            this.btnAcpetar.Name = "btnAcpetar";
            this.btnAcpetar.Size = new System.Drawing.Size(94, 41);
            this.btnAcpetar.TabIndex = 0;
            this.btnAcpetar.Text = "Aceptar";
            this.btnAcpetar.UseVisualStyleBackColor = true;
            this.btnAcpetar.Click += new System.EventHandler(this.btnAcpetar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1006, 686);
            this.Controls.Add(this.btnAcpetar);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.cbOpcion);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Supermercado Compre Feliz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelPrincipal;
        private ComboBox cbOpcion;
        private Label Opciones;
        private Button btnAcpetar;
    }
}