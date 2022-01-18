
namespace Proy.cs.Formularios
{
    partial class AdministrarServicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.txtPrecioServicio = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dtpApertura = new System.Windows.Forms.DateTimePicker();
            this.dtpCierre = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cboZonas = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AllowUserToResizeRows = false;
            this.dgvServicios.BackgroundColor = System.Drawing.Color.White;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServicios.Location = new System.Drawing.Point(266, 12);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.RowHeadersWidth = 51;
            this.dgvServicios.RowTemplate.Height = 24;
            this.dgvServicios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(807, 390);
            this.dgvServicios.TabIndex = 0;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(121, 37);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(139, 22);
            this.txtNombreServicio.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNombreServicio, "Nombre con el que se conoce el servicio");
            // 
            // txtPrecioServicio
            // 
            this.txtPrecioServicio.Location = new System.Drawing.Point(121, 65);
            this.txtPrecioServicio.Name = "txtPrecioServicio";
            this.txtPrecioServicio.Size = new System.Drawing.Size(139, 22);
            this.txtPrecioServicio.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPrecioServicio, "Precio por hora del servicio");
            this.txtPrecioServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioServicio_KeyPress);
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(121, 93);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(139, 22);
            this.txtCapacidad.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtCapacidad, "Capacidad maxima del servicio");
            this.txtCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hora de cierre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hora de apertura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Capacidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre:";
            // 
            // btnCargar
            // 
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Location = new System.Drawing.Point(1, 318);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(118, 34);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.toolTip1.SetToolTip(this.btnCargar, "Cargar los datos seleccionados de la tabla");
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Location = new System.Drawing.Point(1, 368);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(118, 34);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.toolTip1.SetToolTip(this.btnVolver, "Volver a la ventana principal");
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dtpApertura
            // 
            this.dtpApertura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dtpApertura.CustomFormat = "";
            this.dtpApertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpApertura.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpApertura.Location = new System.Drawing.Point(160, 187);
            this.dtpApertura.Name = "dtpApertura";
            this.dtpApertura.Size = new System.Drawing.Size(100, 22);
            this.dtpApertura.TabIndex = 13;
            this.toolTip1.SetToolTip(this.dtpApertura, "Hora de apertura del servicio");
            this.dtpApertura.Value = new System.DateTime(2021, 11, 16, 0, 0, 0, 0);
            // 
            // dtpCierre
            // 
            this.dtpCierre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dtpCierre.CustomFormat = "";
            this.dtpCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCierre.Location = new System.Drawing.Point(160, 218);
            this.dtpCierre.Name = "dtpCierre";
            this.dtpCierre.Size = new System.Drawing.Size(100, 22);
            this.dtpCierre.TabIndex = 14;
            this.toolTip1.SetToolTip(this.dtpCierre, "Hora de finalizacion del servicio");
            this.dtpCierre.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEstado.Location = new System.Drawing.Point(240, 164);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(18, 17);
            this.chkEstado.TabIndex = 17;
            this.toolTip1.SetToolTip(this.chkEstado, "Seleccionado = abierto | Sin seleccionar = cerrado/clausurado");
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Zona:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(125, 269);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 34);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar los datos ingresados a la tabla");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Location = new System.Drawing.Point(125, 318);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 34);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificar, "Modificar los datos cargados de la tabla");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cboZonas
            // 
            this.cboZonas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboZonas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboZonas.FormattingEnabled = true;
            this.cboZonas.Items.AddRange(new object[] {
            "Este",
            "Oeste"});
            this.cboZonas.Location = new System.Drawing.Point(121, 124);
            this.cboZonas.Name = "cboZonas";
            this.cboZonas.Size = new System.Drawing.Size(139, 24);
            this.cboZonas.TabIndex = 24;
            this.cboZonas.Text = "Este";
            this.toolTip1.SetToolTip(this.cboZonas, "Zona del spa en la que se encuentra el servicio");
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(1, 269);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 34);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar los datos seleccionados en la tabla");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // AdministrarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 414);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cboZonas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpCierre);
            this.Controls.Add(this.dtpApertura);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtPrecioServicio);
            this.Controls.Add(this.txtNombreServicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdministrarServicios";
            this.Text = "Administrar Servicios";
            this.Load += new System.EventHandler(this.AdministrarServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.TextBox txtPrecioServicio;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DateTimePicker dtpApertura;
        private System.Windows.Forms.DateTimePicker dtpCierre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboZonas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}