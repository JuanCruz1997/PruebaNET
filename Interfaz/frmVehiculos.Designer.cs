namespace Interfaz
{
    partial class frmVehiculos
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAlta = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.cmbPuertas = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.gbAlta.SuspendLayout();
            this.gbLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAlta
            // 
            this.gbAlta.Controls.Add(this.txtTitular);
            this.gbAlta.Controls.Add(this.btnLimpiarCampos);
            this.gbAlta.Controls.Add(this.btnSalir);
            this.gbAlta.Controls.Add(this.btnAlta);
            this.gbAlta.Controls.Add(this.cmbPuertas);
            this.gbAlta.Controls.Add(this.txtModelo);
            this.gbAlta.Controls.Add(this.cmbMarca);
            this.gbAlta.Controls.Add(this.txtPatente);
            this.gbAlta.Controls.Add(this.lblTitular);
            this.gbAlta.Controls.Add(this.lblPuertas);
            this.gbAlta.Controls.Add(this.lblModelo);
            this.gbAlta.Controls.Add(this.lblMarca);
            this.gbAlta.Controls.Add(this.lblPatente);
            this.gbAlta.Location = new System.Drawing.Point(13, 13);
            this.gbAlta.Name = "gbAlta";
            this.gbAlta.Size = new System.Drawing.Size(466, 376);
            this.gbAlta.TabIndex = 0;
            this.gbAlta.TabStop = false;
            this.gbAlta.Text = "Alta Vehículos";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(338, 171);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(121, 31);
            this.btnLimpiarCampos.TabIndex = 12;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(236, 317);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(224, 49);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(10, 317);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(224, 49);
            this.btnAlta.TabIndex = 10;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // cmbPuertas
            // 
            this.cmbPuertas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuertas.FormattingEnabled = true;
            this.cmbPuertas.Location = new System.Drawing.Point(300, 88);
            this.cmbPuertas.Name = "cmbPuertas";
            this.cmbPuertas.Size = new System.Drawing.Size(160, 24);
            this.cmbPuertas.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(110, 85);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 22);
            this.txtModelo.TabIndex = 7;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(290, 36);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(170, 24);
            this.cmbMarca.TabIndex = 6;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(110, 36);
            this.txtPatente.MaxLength = 8;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(121, 22);
            this.txtPatente.TabIndex = 5;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(4, 143);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(92, 17);
            this.lblTitular.TabIndex = 4;
            this.lblTitular.Text = "Titular/dueño";
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Location = new System.Drawing.Point(237, 88);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(57, 17);
            this.lblPuertas.TabIndex = 3;
            this.lblPuertas.Text = "Puertas";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(7, 85);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(237, 36);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(7, 36);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(96, 17);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "Patente/Placa";
            // 
            // gbLista
            // 
            this.gbLista.Controls.Add(this.lstVehiculos);
            this.gbLista.Location = new System.Drawing.Point(486, 13);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(433, 376);
            this.gbLista.TabIndex = 1;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "Listado Vehículos";
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.ItemHeight = 16;
            this.lstVehiculos.Location = new System.Drawing.Point(6, 21);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(421, 340);
            this.lstVehiculos.TabIndex = 0;
            this.lstVehiculos.SelectedIndexChanged += new System.EventHandler(this.lstVehiculos_SelectedIndexChanged);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(110, 143);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(349, 22);
            this.txtTitular.TabIndex = 13;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 401);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.gbAlta);
            this.Name = "frmVehiculos";
            this.Text = "Gestión de vehículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVehiculos_FormClosed);
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            this.gbAlta.ResumeLayout(false);
            this.gbAlta.PerformLayout();
            this.gbLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ComboBox cmbPuertas;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.TextBox txtTitular;
    }
}

