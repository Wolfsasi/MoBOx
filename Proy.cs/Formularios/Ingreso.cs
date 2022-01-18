using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
namespace Proy.cs.Formularios
{
    public partial class Ingreso : Form
    {
       
        public Ingreso()
        {
            InitializeComponent();
        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            txtCiPass.Focus();
            try
            {
                CapaNegocios.Outputs consult = new CapaNegocios.Outputs();
                string cargo = consult.ConsultaLog(txtCiPass.Text, txtPasswd.Text);

              

                //cargo = "Gerente";
                if (cargo.Equals("Gerente"))
                {
                    inicio.usuario = 1;
                    this.Close();
                }
                else if (cargo.Equals("Admin"))
                {
                    inicio.usuario = 2;
                    this.Close();
                }
                else
                {


                    MessageBox.Show(this, cargo + "\nCredenciales de inicio de sesión incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCiPass.Clear();
                    txtPasswd.Clear();
                   

                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(this, exep.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Ingreso_Load(object sender, EventArgs e)
        {

            inicio.usuario = 0;
            txtCiPass.Focus();
        }
        private void txtNomUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtPasswd.Focus();
            }

        }
        private void txtPasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnIngreso_Click(sender, e);
            }

        }
    }
}
