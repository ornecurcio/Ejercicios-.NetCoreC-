
namespace FrmEstacionamiento
{
    partial class FrmEstacionamiento
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbTipoMoto = new System.Windows.Forms.ComboBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.txtNombreEstaciomamiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(75, 343);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 47);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Items.AddRange(new object[] {
            "Automovil",
            "Moto"});
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(117, 41);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVehiculo.TabIndex = 1;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            // 
            // cmbTipoMoto
            // 
            this.cmbTipoMoto.FormattingEnabled = true;
            this.cmbTipoMoto.Items.AddRange(new object[] {
            "Ciclomotor",
            "Scooter",
            "Sport"});
            this.cmbTipoMoto.Location = new System.Drawing.Point(117, 146);
            this.cmbTipoMoto.Name = "cmbTipoMoto";
            this.cmbTipoMoto.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMoto.TabIndex = 2;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(0, 45);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(111, 17);
            this.lblTipoVehiculo.TabIndex = 3;
            this.lblTipoVehiculo.Text = "Tipo Vehiculo:";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(2, 95);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(73, 17);
            this.lblPatente.TabIndex = 4;
            this.lblPatente.Text = "Patente: ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(2, 146);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(63, 17);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Marca: ";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(117, 92);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(121, 20);
            this.txtPatente.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(262, 147);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.Location = new System.Drawing.Point(295, 77);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(544, 316);
            this.lstVehiculos.TabIndex = 8;
            this.lstVehiculos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVehiculos_MouseDoubleClick);
            // 
            // txtNombreEstaciomamiento
            // 
            this.txtNombreEstaciomamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombreEstaciomamiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEstaciomamiento.Location = new System.Drawing.Point(295, 17);
            this.txtNombreEstaciomamiento.Name = "txtNombreEstaciomamiento";
            this.txtNombreEstaciomamiento.Size = new System.Drawing.Size(544, 39);
            this.txtNombreEstaciomamiento.TabIndex = 9;
            // 
            // FrmEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(851, 402);
            this.Controls.Add(this.txtNombreEstaciomamiento);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.cmbTipoMoto);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.btnAgregar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamiento Curcio Ornela";
            this.Load += new System.EventHandler(this.FrmEstacionamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbTipoMoto;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.TextBox txtNombreEstaciomamiento;
    }
}

