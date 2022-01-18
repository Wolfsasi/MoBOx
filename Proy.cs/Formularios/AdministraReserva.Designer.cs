namespace Proy.cs.Formularios
{
    partial class AdministraReserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarSer = new System.Windows.Forms.Button();
            this.btnAgregarSer = new System.Windows.Forms.Button();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHoraReserva = new System.Windows.Forms.Label();
            this.dtpHoraReserva = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvPreReservas = new System.Windows.Forms.DataGridView();
            this.dgvCientes = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.lblClienteSel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarSer);
            this.groupBox1.Controls.Add(this.btnAgregarSer);
            this.groupBox1.Controls.Add(this.dgvServicios);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(780, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // btnEliminarSer
            // 
            this.btnEliminarSer.Location = new System.Drawing.Point(684, 240);
            this.btnEliminarSer.Name = "btnEliminarSer";
            this.btnEliminarSer.Size = new System.Drawing.Size(90, 45);
            this.btnEliminarSer.TabIndex = 39;
            this.btnEliminarSer.Text = "Eliminar servicio";
            this.btnEliminarSer.UseVisualStyleBackColor = true;
            this.btnEliminarSer.Click += new System.EventHandler(this.btnEliminarSer_Click);
            // 
            // btnAgregarSer
            // 
            this.btnAgregarSer.Location = new System.Drawing.Point(684, 162);
            this.btnAgregarSer.Name = "btnAgregarSer";
            this.btnAgregarSer.Size = new System.Drawing.Size(90, 45);
            this.btnAgregarSer.TabIndex = 38;
            this.btnAgregarSer.Text = "Agregar servicio";
            this.btnAgregarSer.UseVisualStyleBackColor = true;
            this.btnAgregarSer.Click += new System.EventHandler(this.btnAgregarSer_Click);
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AllowUserToOrderColumns = true;
            this.dgvServicios.AllowUserToResizeColumns = false;
            this.dgvServicios.AllowUserToResizeRows = false;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.ColumnHeadersVisible = false;
            this.dgvServicios.Location = new System.Drawing.Point(13, 107);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.RowHeadersWidth = 51;
            this.dgvServicios.RowTemplate.Height = 24;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(661, 246);
            this.dgvServicios.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHoraReserva);
            this.groupBox2.Controls.Add(this.dtpHoraReserva);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblFechaReserva);
            this.groupBox2.Controls.Add(this.dtpFechaReserva);
            this.groupBox2.Controls.Add(this.nudHoras);
            this.groupBox2.Location = new System.Drawing.Point(13, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(757, 76);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso";
            // 
            // lblHoraReserva
            // 
            this.lblHoraReserva.AutoSize = true;
            this.lblHoraReserva.Location = new System.Drawing.Point(297, 12);
            this.lblHoraReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraReserva.Name = "lblHoraReserva";
            this.lblHoraReserva.Size = new System.Drawing.Size(115, 17);
            this.lblHoraReserva.TabIndex = 37;
            this.lblHoraReserva.Text = "Hora de reserva:";
            // 
            // dtpHoraReserva
            // 
            this.dtpHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraReserva.Location = new System.Drawing.Point(420, 12);
            this.dtpHoraReserva.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.Size = new System.Drawing.Size(104, 22);
            this.dtpHoraReserva.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cantidad de veces a reservar el servicio";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(13, 17);
            this.lblFechaReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(123, 17);
            this.lblFechaReserva.TabIndex = 35;
            this.lblFechaReserva.Text = "Fecha de reserva:";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReserva.Location = new System.Drawing.Point(144, 12);
            this.dtpFechaReserva.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(128, 22);
            this.dtpFechaReserva.TabIndex = 34;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(465, 40);
            this.nudHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(59, 22);
            this.nudHoras.TabIndex = 34;
            this.nudHoras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(692, 419);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 37);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(8, 419);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 37);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvPreReservas
            // 
            this.dgvPreReservas.AllowUserToAddRows = false;
            this.dgvPreReservas.AllowUserToDeleteRows = false;
            this.dgvPreReservas.AllowUserToOrderColumns = true;
            this.dgvPreReservas.AllowUserToResizeColumns = false;
            this.dgvPreReservas.AllowUserToResizeRows = false;
            this.dgvPreReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPreReservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPreReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreReservas.Location = new System.Drawing.Point(809, 12);
            this.dgvPreReservas.Name = "dgvPreReservas";
            this.dgvPreReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPreReservas.RowHeadersVisible = false;
            this.dgvPreReservas.RowHeadersWidth = 51;
            this.dgvPreReservas.RowTemplate.Height = 24;
            this.dgvPreReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreReservas.Size = new System.Drawing.Size(536, 472);
            this.dgvPreReservas.TabIndex = 5;
            this.dgvPreReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalidaReservas_CellClick);
            // 
            // dgvCientes
            // 
            this.dgvCientes.AllowUserToAddRows = false;
            this.dgvCientes.AllowUserToDeleteRows = false;
            this.dgvCientes.AllowUserToOrderColumns = true;
            this.dgvCientes.AllowUserToResizeColumns = false;
            this.dgvCientes.AllowUserToResizeRows = false;
            this.dgvCientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCientes.ColumnHeadersVisible = false;
            this.dgvCientes.Location = new System.Drawing.Point(8, 461);
            this.dgvCientes.Name = "dgvCientes";
            this.dgvCientes.RowHeadersWidth = 51;
            this.dgvCientes.RowTemplate.Height = 24;
            this.dgvCientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCientes.Size = new System.Drawing.Size(674, 266);
            this.dgvCientes.TabIndex = 40;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(692, 499);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(100, 52);
            this.btnSeleccionarCliente.TabIndex = 44;
            this.btnSeleccionarCliente.Text = "Seleccionar Cliente";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // lblClienteSel
            // 
            this.lblClienteSel.AutoSize = true;
            this.lblClienteSel.Location = new System.Drawing.Point(692, 563);
            this.lblClienteSel.Name = "lblClienteSel";
            this.lblClienteSel.Size = new System.Drawing.Size(142, 17);
            this.lblClienteSel.TabIndex = 45;
            this.lblClienteSel.Text = "Cliente seleccionado:";
            // 
            // AdministraReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 742);
            this.ControlBox = false;
            this.Controls.Add(this.lblClienteSel);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.dgvCientes);
            this.Controls.Add(this.dgvPreReservas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdministraReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Reservas";
            this.Load += new System.EventHandler(this.NuevaReserva_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPreReservas;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Button btnEliminarSer;
        private System.Windows.Forms.Button btnAgregarSer;
        private System.Windows.Forms.DataGridView dgvCientes;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Label lblClienteSel;
        private System.Windows.Forms.Label lblHoraReserva;
        private System.Windows.Forms.DateTimePicker dtpHoraReserva;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
    }
}