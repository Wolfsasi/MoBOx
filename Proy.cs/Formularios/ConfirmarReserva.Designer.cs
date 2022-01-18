namespace Proy.cs.Formularios
{
    partial class ConfirmarReserva
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
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.txtCiPas = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.DGVReservas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblMontoPagado = new System.Windows.Forms.Label();
            this.rdbContado = new System.Windows.Forms.RadioButton();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCIPass = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSelectAll);
            this.groupBox1.Controls.Add(this.txtCiPas);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.DGVReservas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1176, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de reserva";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(181, 20);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(224, 21);
            this.chkSelectAll.TabIndex = 19;
            this.chkSelectAll.Text = "Seleccionar todas las reservas";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // txtCiPas
            // 
            this.txtCiPas.Location = new System.Drawing.Point(207, 66);
            this.txtCiPas.Name = "txtCiPas";
            this.txtCiPas.Size = new System.Drawing.Size(182, 22);
            this.txtCiPas.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(287, 93);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 28);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // DGVReservas
            // 
            this.DGVReservas.AllowUserToAddRows = false;
            this.DGVReservas.AllowUserToDeleteRows = false;
            this.DGVReservas.AllowUserToResizeColumns = false;
            this.DGVReservas.AllowUserToResizeRows = false;
            this.DGVReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVReservas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReservas.Location = new System.Drawing.Point(411, 20);
            this.DGVReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVReservas.Name = "DGVReservas";
            this.DGVReservas.ReadOnly = true;
            this.DGVReservas.RowHeadersVisible = false;
            this.DGVReservas.RowHeadersWidth = 51;
            this.DGVReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVReservas.RowTemplate.Height = 24;
            this.DGVReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVReservas.Size = new System.Drawing.Size(741, 172);
            this.DGVReservas.TabIndex = 1;
            this.DGVReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVReservas_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cedula/Pasaporte:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIngreso);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnConfirmar);
            this.groupBox2.Controls.Add(this.lblCambio);
            this.groupBox2.Controls.Add(this.lblMontoPagado);
            this.groupBox2.Controls.Add(this.rdbContado);
            this.groupBox2.Controls.Add(this.rdbDebito);
            this.groupBox2.Controls.Add(this.rdbCredito);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMontoPagado);
            this.groupBox2.Controls.Add(this.lblMonto);
            this.groupBox2.Controls.Add(this.lblCorreo);
            this.groupBox2.Controls.Add(this.lblCelular);
            this.groupBox2.Controls.Add(this.lblCIPass);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Location = new System.Drawing.Point(5, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(846, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmacion de reserva";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(415, 179);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(59, 17);
            this.lblIngreso.TabIndex = 16;
            this.lblIngreso.Text = "Ingreso:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(100, 226);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(551, 226);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(117, 39);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(123, 179);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(59, 17);
            this.lblCambio.TabIndex = 13;
            this.lblCambio.Text = "Cambio:";
            // 
            // lblMontoPagado
            // 
            this.lblMontoPagado.AutoSize = true;
            this.lblMontoPagado.Location = new System.Drawing.Point(17, 146);
            this.lblMontoPagado.Name = "lblMontoPagado";
            this.lblMontoPagado.Size = new System.Drawing.Size(103, 17);
            this.lblMontoPagado.TabIndex = 12;
            this.lblMontoPagado.Text = "Monto pagado:";
            // 
            // rdbContado
            // 
            this.rdbContado.AutoSize = true;
            this.rdbContado.Checked = true;
            this.rdbContado.Location = new System.Drawing.Point(299, 92);
            this.rdbContado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbContado.Name = "rdbContado";
            this.rdbContado.Size = new System.Drawing.Size(82, 21);
            this.rdbContado.TabIndex = 11;
            this.rdbContado.TabStop = true;
            this.rdbContado.Text = "Contado";
            this.rdbContado.UseVisualStyleBackColor = true;
            this.rdbContado.CheckedChanged += new System.EventHandler(this.rdbContado_CheckedChanged);
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.Location = new System.Drawing.Point(223, 92);
            this.rdbDebito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(70, 21);
            this.rdbDebito.TabIndex = 10;
            this.rdbDebito.Text = "Débito";
            this.rdbDebito.UseVisualStyleBackColor = true;
            this.rdbDebito.CheckedChanged += new System.EventHandler(this.rdbDebito_CheckedChanged);
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(143, 92);
            this.rdbCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(74, 21);
            this.rdbCredito.TabIndex = 9;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            this.rdbCredito.CheckedChanged += new System.EventHandler(this.rdbCredito_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pago:";
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Location = new System.Drawing.Point(126, 146);
            this.txtMontoPagado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.Size = new System.Drawing.Size(136, 22);
            this.txtMontoPagado.TabIndex = 7;
            this.txtMontoPagado.TextChanged += new System.EventHandler(this.txtMontoPagado_TextChanged);
            this.txtMontoPagado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPagado_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(83, 66);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(51, 17);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(415, 153);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 17);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(415, 123);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(56, 17);
            this.lblCelular.TabIndex = 3;
            this.lblCelular.Text = "Celular:";
            // 
            // lblCIPass
            // 
            this.lblCIPass.AutoSize = true;
            this.lblCIPass.Location = new System.Drawing.Point(415, 94);
            this.lblCIPass.Name = "lblCIPass";
            this.lblCIPass.Size = new System.Drawing.Size(125, 17);
            this.lblCIPass.TabIndex = 2;
            this.lblCIPass.Text = "Cedula/Pasaporte:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(415, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // ConfirmarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 536);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConfirmarReserva";
            this.Text = "Confirmar Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReservas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVReservas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCIPass;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.RadioButton rdbContado;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.Label lblMontoPagado;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCiPas;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Label lblIngreso;
    }
}