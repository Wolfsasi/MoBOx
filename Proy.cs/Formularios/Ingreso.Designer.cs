namespace Proy.cs.Formularios
{
    partial class Ingreso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtCiPass = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula/Pasaporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(207, 133);
            this.txtPasswd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(187, 22);
            this.txtPasswd.TabIndex = 2;
            this.txtPasswd.UseSystemPasswordChar = true;
            this.txtPasswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswd_KeyPress);
            // 
            // txtCiPass
            // 
            this.txtCiPass.Location = new System.Drawing.Point(207, 81);
            this.txtCiPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCiPass.Name = "txtCiPass";
            this.txtCiPass.Size = new System.Drawing.Size(187, 22);
            this.txtCiPass.TabIndex = 1;
            this.txtCiPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomUsu_KeyPress);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(309, 185);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnIngreso.Size = new System.Drawing.Size(84, 34);
            this.btnIngreso.TabIndex = 3;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(87, 185);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingreso Gerente o Administrativo";
            // 
            // Ingreso
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 231);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.txtCiPass);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCiPass;
        public System.Windows.Forms.TextBox txtPasswd;
    }
}