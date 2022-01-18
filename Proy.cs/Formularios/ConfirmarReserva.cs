using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Proy.cs.Formularios
{
  

    public partial class ConfirmarReserva : Form
    {
        private DataTable dt = new DataTable();
        private CapaPresentacion.Controles controles = new CapaPresentacion.Controles();
        private CapaNegocios.Outputs outputs = new CapaNegocios.Outputs();
        private CapaNegocios.Inputs inputs = new CapaNegocios.Inputs();
        
       private String nombre;
       private String apellido;
       private String iDReserva;
       private String cIPass;
       private String celular;
       private String correo;
       private String monto;
       private String Ingreso;

        double cambio=0;

        public ConfirmarReserva()
        {
            InitializeComponent();
        }

        private void rdbContado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbContado.Checked)
            {
                txtMontoPagado.Visible = true;
                lblMontoPagado.Visible = true;
                lblCambio.Visible = true;
                btnConfirmar.Enabled = false;
            }
            else
            {
                txtMontoPagado.Visible = false;
                lblMontoPagado.Visible = false;
                lblCambio.Visible = false;
                btnConfirmar.Enabled = true;
                txtMontoPagado.Text = "";
                lblCambio.Text = "Cambio:";

            }
        }

        private void txtMontoPagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (controles.IsNumber(e.KeyChar)|| (int)e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
           
        }

        private void txtMontoPagado_TextChanged(object sender, EventArgs e)
        {
            if (!txtMontoPagado.Text.Equals(""))
            {
                double ingresado = double.Parse(txtMontoPagado.Text);

                double debe = double.Parse(monto);

                 cambio = ingresado - debe;

                lblCambio.Text = String.Format("Cambio: $U{0:0.00}", cambio);
                btnConfirmar.Enabled = true;
            }
            else
            {
                lblCambio.Text = "Cambio:";
                btnConfirmar.Enabled = false;
            }
            if (cambio <0)
            {
                lblCambio.Text = "Cambio: $U0,00";
            }
        }
         
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cambio<0 && rdbContado.Checked)
            {
                MessageBox.Show(this,
                    "El monto ingresado es menor que el monto a pagar"+"\n"+lblMonto.Text+"\n"+ String.Format("Pago: $U {0:0.00}", Int32.Parse(txtMontoPagado.Text)),
                    "Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            else
            {
                string metp;
                if (rdbContado.Checked)
                {
                    metp = "Efectivo";
                }
                else if (rdbCredito.Checked)
                {
                    metp = "Credito";
                }
                else
                {
                    metp = "Debito";
                }
                if (chkSelectAll.Checked)
                {
                    try { 
                    for (int i = 0; i < DGVReservas.SelectedRows.Count; i++)
                    {
                          
                        inputs.upConfReservas(DGVReservas.Rows[i].Cells[0].Value.ToString(), "1", metp);
                    }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error CR130");
                    }
                }
                else
                {
                    
                   string idr = DGVReservas.SelectedCells[0].Value.ToString();
                

                    inputs.upConfReservas(idr,"1",metp);
                }

            }
            actualizardgv();
        }

        private void actualizardgv()
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dtaux = new DataTable();
            da.Fill(dtaux, outputs.consultReservaClient(txtCiPas.Text));
            dt = dtaux;
            DGVReservas.DataSource = dt;
            chkSelectAll.Checked = false;
        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDebito.Checked)
            {
                btnConfirmar.Enabled=true;
            }

        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCredito.Checked)
            {
                btnConfirmar.Enabled = true;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        
            
            try {

                actualizardgv();
                OleDbDataAdapter da = new OleDbDataAdapter();
            cIPass = txtCiPas.Text;
            DGVReservas.DataSource = dt;

                DataTable dtc = new DataTable();
                
                da.Fill(dtc, outputs.ConsultaClientes(cIPass));


                nombre = dtc.Rows[0][1].ToString();
                apellido = dtc.Rows[0][2].ToString();
                celular = dtc.Rows[0][4].ToString();
                correo = dtc.Rows[0][5].ToString();
                Ingreso = dtc.Rows[0][6].ToString();

                lblNombre.Text = String.Format("Cliente: {0} {1}", nombre, apellido);

                lblCIPass.Text = String.Format("Cedula/Pasaporte: {0}", txtCiPas.Text);

                lblCelular.Text = String.Format("Celular: {0}", celular);

                lblCorreo.Text = String.Format("Correo: {0}", correo);

                lblIngreso.Text = String.Format("Ingreso: {0}", Ingreso);

            }
            catch(Exception ex)
                {
                    MessageBox.Show(this,ex.Message,"Error CR157");
                }
            }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked)
            {
                for (int i = 0; i < DGVReservas.Rows.Count; i++)
                {

                    DGVReservas.Rows[i].Selected = true;

                }
            }
            else
            {
                for (int i = 0; i<DGVReservas.Rows.Count;i++)
                {

                    DGVReservas.Rows[i].Selected = false;

                }
            }
        }

        private void DGVReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            chkSelectAll.Checked = false;

            try
            {

                double suma = 0;

                if (Ingreso == "Turista")
                {
                    suma += 100;
                }
                else if (Ingreso == "Normal")
                {
                    suma += 150;
                }
                else
                {
                    suma += 80;
                }


                if (DGVReservas.SelectedRows.Count == 1)
                {
                    suma += double.Parse(DGVReservas.SelectedCells[5].Value.ToString());
                }
                else if (DGVReservas.SelectedRows.Count > 1)
                {

                    for (int i = 0; i < DGVReservas.SelectedRows.Count; i++)
                    {
                        suma += double.Parse(DGVReservas.Rows[i].Cells[5].Value.ToString());
                    }


                }
                else

                {
                    MessageBox.Show(this, "Debe seleccionar al menos una fila de la tabla", "Error CR175");
                }

                monto = suma.ToString();
                lblMonto.Text = String.Format("Monto: $U {0}", monto);




            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error CR183");
            }

        }
    }
}
