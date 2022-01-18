namespace Proy.cs.Formularios
{
    partial class inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboConsulta = new System.Windows.Forms.ComboBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.mnReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReservasNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReservasConfirmar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnServiciosAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUsuarioIngreso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUsuarioSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.btnCargar = new System.Windows.Forms.Button();
            this.TTSigns = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboConsulta
            // 
            this.cboConsulta.FormattingEnabled = true;
            this.cboConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboConsulta.Items.AddRange(new object[] {
            "Reservados (Sin confirmar)",
            "Confirmados (Pagos)"});
            this.cboConsulta.Location = new System.Drawing.Point(246, 31);
            this.cboConsulta.Name = "cboConsulta";
            this.cboConsulta.Size = new System.Drawing.Size(215, 24);
            this.cboConsulta.TabIndex = 7;
            this.cboConsulta.Text = "Reservados (Sin confirmar)";
            this.TTSigns.SetToolTip(this.cboConsulta, "Seleccionar el tipo de reservas a cargar con el boton \"Cargar\"");
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.AllowUserToResizeRows = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(48, 61);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(919, 373);
            this.dgvRegistros.TabIndex = 5;
            // 
            // mnReservas
            // 
            this.mnReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnReservasNueva,
            this.mnReservasConfirmar});
            this.mnReservas.Name = "mnReservas";
            this.mnReservas.Size = new System.Drawing.Size(80, 24);
            this.mnReservas.Text = "Reservas";
            // 
            // mnReservasNueva
            // 
            this.mnReservasNueva.Name = "mnReservasNueva";
            this.mnReservasNueva.Size = new System.Drawing.Size(230, 26);
            this.mnReservasNueva.Text = "Administrar Reservas";
            this.mnReservasNueva.Click += new System.EventHandler(this.mnReservasNueva_Click);
            // 
            // mnReservasConfirmar
            // 
            this.mnReservasConfirmar.Name = "mnReservasConfirmar";
            this.mnReservasConfirmar.Size = new System.Drawing.Size(230, 26);
            this.mnReservasConfirmar.Text = "Confirmar";
            this.mnReservasConfirmar.Click += new System.EventHandler(this.mnReservasConfirmar_Click);
            // 
            // mnServicios
            // 
            this.mnServicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnServiciosAdministrar});
            this.mnServicios.Name = "mnServicios";
            this.mnServicios.Size = new System.Drawing.Size(81, 24);
            this.mnServicios.Text = "Servicios";
            // 
            // mnServiciosAdministrar
            // 
            this.mnServiciosAdministrar.Name = "mnServiciosAdministrar";
            this.mnServiciosAdministrar.Size = new System.Drawing.Size(229, 26);
            this.mnServiciosAdministrar.Text = "Administrar servicios";
            this.mnServiciosAdministrar.Click += new System.EventHandler(this.mnServiciosAdministrar_Click);
            // 
            // mnUsuario
            // 
            this.mnUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUsuarioIngreso,
            this.mnUsuarioSalir});
            this.mnUsuario.Name = "mnUsuario";
            this.mnUsuario.Size = new System.Drawing.Size(73, 24);
            this.mnUsuario.Text = "Usuario";
            // 
            // mnUsuarioIngreso
            // 
            this.mnUsuarioIngreso.Name = "mnUsuarioIngreso";
            this.mnUsuarioIngreso.Size = new System.Drawing.Size(141, 26);
            this.mnUsuarioIngreso.Text = "Ingreso";
            this.mnUsuarioIngreso.Click += new System.EventHandler(this.mnUsuarioIngreso_Click);
            // 
            // mnUsuarioSalir
            // 
            this.mnUsuarioSalir.Name = "mnUsuarioSalir";
            this.mnUsuarioSalir.Size = new System.Drawing.Size(141, 26);
            this.mnUsuarioSalir.Text = "Salir";
            this.mnUsuarioSalir.Click += new System.EventHandler(this.mnUsuarioSalir_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnReservas,
            this.mnServicios,
            this.mnUsuario});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1013, 28);
            this.MenuBar.TabIndex = 8;
            this.MenuBar.Text = "menuStrip1";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(480, 32);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(91, 23);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.TTSigns.SetToolTip(this.btnCargar, "Cargar las reservas seleccionadas en la lista");
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // TTSigns
            // 
            this.TTSigns.ToolTipTitle = "Info";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.cboConsulta);
            this.Controls.Add(this.dgvRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboConsulta;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.ToolStripMenuItem mnReservas;
        private System.Windows.Forms.ToolStripMenuItem mnReservasNueva;
        private System.Windows.Forms.ToolStripMenuItem mnReservasConfirmar;
        private System.Windows.Forms.ToolStripMenuItem mnServicios;
        private System.Windows.Forms.ToolStripMenuItem mnServiciosAdministrar;
        private System.Windows.Forms.ToolStripMenuItem mnUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnUsuarioIngreso;
        private System.Windows.Forms.ToolStripMenuItem mnUsuarioSalir;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ToolTip TTSigns;
    }
}