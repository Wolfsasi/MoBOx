namespace Proy.cs.Formularios
{
    partial class IngresoCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdJubPen = new System.Windows.Forms.RadioButton();
            this.rdTurista = new System.Windows.Forms.RadioButton();
            this.rdComun = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdPrincipal = new System.Windows.Forms.RadioButton();
            this.rdAcomp = new System.Windows.Forms.RadioButton();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rdPasaporte = new System.Windows.Forms.RadioButton();
            this.rdCedula = new System.Windows.Forms.RadioButton();
            this.dtpFNac = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCIPass = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtApe);
            this.groupBox1.Controls.Add(this.btnCargarDatos);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.rdPasaporte);
            this.groupBox1.Controls.Add(this.rdCedula);
            this.groupBox1.Controls.Add(this.dtpFNac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCIPass);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(377, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdJubPen);
            this.groupBox3.Controls.Add(this.rdTurista);
            this.groupBox3.Controls.Add(this.rdComun);
            this.groupBox3.Location = new System.Drawing.Point(3, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 41);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // rdJubPen
            // 
            this.rdJubPen.AutoSize = true;
            this.rdJubPen.Location = new System.Drawing.Point(85, 15);
            this.rdJubPen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdJubPen.Name = "rdJubPen";
            this.rdJubPen.Size = new System.Drawing.Size(170, 21);
            this.rdJubPen.TabIndex = 41;
            this.rdJubPen.TabStop = true;
            this.rdJubPen.Text = "Jubilado o pensionista";
            this.rdJubPen.UseVisualStyleBackColor = true;
            // 
            // rdTurista
            // 
            this.rdTurista.AutoSize = true;
            this.rdTurista.Location = new System.Drawing.Point(261, 15);
            this.rdTurista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTurista.Name = "rdTurista";
            this.rdTurista.Size = new System.Drawing.Size(73, 21);
            this.rdTurista.TabIndex = 40;
            this.rdTurista.TabStop = true;
            this.rdTurista.Text = "Turista";
            this.rdTurista.UseVisualStyleBackColor = true;
            // 
            // rdComun
            // 
            this.rdComun.AutoSize = true;
            this.rdComun.Checked = true;
            this.rdComun.Location = new System.Drawing.Point(6, 15);
            this.rdComun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdComun.Name = "rdComun";
            this.rdComun.Size = new System.Drawing.Size(73, 21);
            this.rdComun.TabIndex = 39;
            this.rdComun.TabStop = true;
            this.rdComun.Text = "Común";
            this.rdComun.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(151, 130);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(161, 22);
            this.txtCorreo.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdPrincipal);
            this.groupBox2.Controls.Add(this.rdAcomp);
            this.groupBox2.Location = new System.Drawing.Point(19, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 49);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de cliente";
            // 
            // rdPrincipal
            // 
            this.rdPrincipal.AutoSize = true;
            this.rdPrincipal.Checked = true;
            this.rdPrincipal.Location = new System.Drawing.Point(36, 23);
            this.rdPrincipal.Name = "rdPrincipal";
            this.rdPrincipal.Size = new System.Drawing.Size(83, 21);
            this.rdPrincipal.TabIndex = 8;
            this.rdPrincipal.TabStop = true;
            this.rdPrincipal.Text = "Principal";
            this.rdPrincipal.UseVisualStyleBackColor = true;
            // 
            // rdAcomp
            // 
            this.rdAcomp.AutoSize = true;
            this.rdAcomp.Location = new System.Drawing.Point(173, 23);
            this.rdAcomp.Name = "rdAcomp";
            this.rdAcomp.Size = new System.Drawing.Size(116, 21);
            this.rdAcomp.TabIndex = 9;
            this.rdAcomp.Text = "Acompañante";
            this.rdAcomp.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(19, 386);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(164, 30);
            this.btnCargar.TabIndex = 33;
            this.btnCargar.TabStop = false;
            this.btnCargar.Text = "Cargar datos de la lista";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(189, 386);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(164, 30);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.TabStop = false;
            this.btnModificar.Text = "Modificar de la lista";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(19, 352);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 30);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "Eliminar de la lista";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(82, 201);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 30;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(154, 198);
            this.txtApe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(161, 22);
            this.txtApe.TabIndex = 6;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(171, 53);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(124, 28);
            this.btnCargarDatos.TabIndex = 2;
            this.btnCargarDatos.Text = "Cargar cliente";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(192, 352);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 30);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Text = "Agregar a la lista";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rdPasaporte
            // 
            this.rdPasaporte.AutoSize = true;
            this.rdPasaporte.Location = new System.Drawing.Point(19, 57);
            this.rdPasaporte.Margin = new System.Windows.Forms.Padding(4);
            this.rdPasaporte.Name = "rdPasaporte";
            this.rdPasaporte.Size = new System.Drawing.Size(94, 21);
            this.rdPasaporte.TabIndex = 26;
            this.rdPasaporte.TabStop = true;
            this.rdPasaporte.Text = "Pasaporte";
            this.rdPasaporte.UseVisualStyleBackColor = true;
            // 
            // rdCedula
            // 
            this.rdCedula.AutoSize = true;
            this.rdCedula.Checked = true;
            this.rdCedula.Location = new System.Drawing.Point(19, 28);
            this.rdCedula.Margin = new System.Windows.Forms.Padding(4);
            this.rdCedula.Name = "rdCedula";
            this.rdCedula.Size = new System.Drawing.Size(82, 21);
            this.rdCedula.TabIndex = 25;
            this.rdCedula.TabStop = true;
            this.rdCedula.Text = "Cédula *";
            this.rdCedula.UseVisualStyleBackColor = true;
            this.rdCedula.CheckedChanged += new System.EventHandler(this.rdCedula_CheckedChanged);
            // 
            // dtpFNac
            // 
            this.dtpFNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFNac.Location = new System.Drawing.Point(153, 228);
            this.dtpFNac.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFNac.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpFNac.Name = "dtpFNac";
            this.dtpFNac.Size = new System.Drawing.Size(161, 22);
            this.dtpFNac.TabIndex = 7;
            this.dtpFNac.Value = new System.DateTime(2021, 8, 14, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(153, 165);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(161, 22);
            this.txtNom.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // txtCIPass
            // 
            this.txtCIPass.Location = new System.Drawing.Point(153, 27);
            this.txtCIPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCIPass.Name = "txtCIPass";
            this.txtCIPass.Size = new System.Drawing.Size(161, 22);
            this.txtCIPass.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(230, 419);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 37);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(55, 419);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 37);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Celular: *";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(153, 94);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(161, 22);
            this.txtCelular.TabIndex = 3;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.Location = new System.Drawing.Point(389, 22);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1109, 428);
            this.dgvClientes.TabIndex = 34;
            // 
            // IngresoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1521, 508);
            this.ControlBox = false;
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IngresoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.IngresoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCIPass;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.DateTimePicker dtpFNac;
        private System.Windows.Forms.RadioButton rdPasaporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApe;
        protected internal System.Windows.Forms.RadioButton rdCedula;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdPrincipal;
        private System.Windows.Forms.RadioButton rdAcomp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.RadioButton rdJubPen;
        private System.Windows.Forms.RadioButton rdTurista;
        private System.Windows.Forms.RadioButton rdComun;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}