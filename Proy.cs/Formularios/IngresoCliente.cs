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
using CapaNegocios;

namespace Proy.cs.Formularios
{




    public partial class IngresoCliente : Form
    {

        private readonly CapaPresentacion.Controles contr = new CapaPresentacion.Controles();
        
        public int cantidadAcomp = 0;
        public DataTable dt = new DataTable();
        

        public IngresoCliente()
        {
            InitializeComponent();
        }
        private void IngresoCliente_Load(object sender, EventArgs e)
        {
            dtpFNac.Value = DateTime.Now;
            this.Focus();
            this.Enabled = true;




            /*CIPAS 0*/
            DataColumn Dcip = new DataColumn(); 
            Dcip.DataType = Type.GetType("System.String");
            Dcip.ColumnName = "CI/Pasaporte";
            dt.Columns.Add(Dcip);

            /*Celular 1*/
            DataColumn DCel = new DataColumn();
            DCel.DataType = Type.GetType("System.String");
            DCel.ColumnName = "Celular";
            dt.Columns.Add(DCel);

            /*Nombre 2*/
            DataColumn DNom = new DataColumn();
            DNom.DataType = Type.GetType("System.String");
            DNom.ColumnName = "Nombre";
            dt.Columns.Add(DNom);

            /*Apellido 3*/
            DataColumn DApe = new DataColumn();
            DApe.DataType = Type.GetType("System.String");
            DApe.ColumnName = "Apellido";
            dt.Columns.Add(DApe);

            /*Tipo de cliente 4*/
            DataColumn DTipo = new DataColumn();
            DTipo.DataType = Type.GetType("System.String");
            DTipo.ColumnName = "Tipo";
            dt.Columns.Add(DTipo);

            /*Fecha de nacimiento 5*/
            DataColumn DFna = new DataColumn();
            DFna.DataType = Type.GetType("System.String");
            DFna.ColumnName = "Fecha de nacimiento";
            dt.Columns.Add(DFna);

            /*Correo 6*/
            DataColumn DMail = new DataColumn();
            DMail.DataType = Type.GetType("System.String");
            DMail.ColumnName = "Correo";
            dt.Columns.Add(DMail);

            /*ingreso de cliente 7*/
            DataColumn DTipoin = new DataColumn();
            DTipoin.DataType = Type.GetType("System.String");
            DTipoin.ColumnName = "Ingreso";
            dt.Columns.Add(DTipoin);

            /*Ocultar cabecera de filas*/
            dgvClientes.RowHeadersVisible = false;

            /*Mostrar solamente la barra de desplazamiento vertical*/
            dgvClientes.ScrollBars = ScrollBars.Vertical;


        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean principal = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].ItemArray[4].ToString() == "Cliente")
                {

                    principal = true;

                }
                else
                {
                    cantidadAcomp++;
                }
            }
            if (principal)
            {
               

                try {

                CapaNegocios.Outputs outputs = new CapaNegocios.Outputs();
                CapaNegocios.Inputs inputs = new CapaNegocios.Inputs();
                    DataTable dtc = new DataTable();

                OleDbDataAdapter da = new OleDbDataAdapter();




                   
                    

                    /*DTC CONSULTA de CLIENTES*/
                    /*DT TABLA LOCAL de CLIENTES*/



                    for (int i = 1; i <= dt.Rows.Count; i++)
                    {
                        
                        ADODB.Recordset rs = outputs.ConsultaClientes(dt.Rows[i - 1].ItemArray[0].ToString());
                        da.Fill(dtc, rs);
                        string date = String.Format("{0:yyyy/MM/dd}", dtc.Rows[0][3]);
                        int a = (dtc.Rows.Count) - 1;

                        if (!outputs.ExistPer(dt.Rows[i - 1].ItemArray[0].ToString()))
                        {


                            try
                            {

                                inputs.inPersona(dt.Rows[i - 1].ItemArray[0].ToString(), /*CI*/
                                                 dt.Rows[i - 1].ItemArray[2].ToString(), /*Nombre*/
                                                 dt.Rows[i - 1].ItemArray[3].ToString(), /*Apellido*/
                                                 dt.Rows[i - 1].ItemArray[5].ToString(), /*fecha Nac*/
                                                 dt.Rows[i - 1].ItemArray[1].ToString(), /*Celular*/
                                                 dt.Rows[i - 1].ItemArray[6].ToString(), /*correo*/
                                                 dt.Rows[i - 1].ItemArray[7].ToString()); /*ingreso*/

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(this, "Error al ingresar persona \n\n" + ex.Message, "Error IC134");
                            }
                        }
                        /*cipas, nombre, apellido, fnac, celular, mail, tipo*/
                        else if (dt.Rows[i - 1].ItemArray[0].ToString() == dtc.Rows[0][0].ToString() &&
                                (dt.Rows[i - 1].ItemArray[2].ToString() != dtc.Rows[0][1].ToString() ||
                                dt.Rows[i - 1].ItemArray[3].ToString() != dtc.Rows[0][2].ToString() ||
                                dt.Rows[i - 1].ItemArray[5].ToString() != date ||
                                dt.Rows[i - 1].ItemArray[1].ToString() != dtc.Rows[0][4].ToString() ||
                                dt.Rows[i - 1].ItemArray[6].ToString() != dtc.Rows[0][5].ToString() ||
                                dt.Rows[i - 1].ItemArray[7].ToString() != dtc.Rows[0][6].ToString() ))
                        {


                            
                            
                            DialogResult msop = MessageBox.Show(this, "¿Seguro que desea modificar el cliente: " + dt.Rows[0][0].ToString()
                                                    + " ?\nDatos nuevos --- Datos anteriores\n" +
                                                    dt.Rows[i - 1].ItemArray[2].ToString() + " --- " + dtc.Rows[0][1].ToString()
                                                    + "\n" + dt.Rows[i - 1].ItemArray[3].ToString() + " --- " + dtc.Rows[0][2].ToString() + "\n" +
                                                     dt.Rows[i - 1].ItemArray[5].ToString() + " --- " + date + "\n" +
                                                     dt.Rows[i - 1].ItemArray[1].ToString() + " --- " + dtc.Rows[0][4].ToString() + "\n" +
                                                     dt.Rows[i - 1].ItemArray[6].ToString() + " --- " + dtc.Rows[0][5].ToString() + "\n" +
                                                     dt.Rows[i - 1].ItemArray[7].ToString() + " --- " + dtc.Rows[0][6].ToString(),

                                                     "Modificacion cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (msop == DialogResult.Yes)
                            {
                                inputs.upPersonas(dt.Rows[i - 1].ItemArray[0].ToString(),
                                                  dt.Rows[i - 1].ItemArray[2].ToString(),
                                                  dt.Rows[i - 1].ItemArray[3].ToString(),
                                                  dt.Rows[i - 1].ItemArray[5].ToString(),
                                                  dt.Rows[i - 1].ItemArray[1].ToString(),
                                                  dt.Rows[i - 1].ItemArray[6].ToString(),
                                                  dt.Rows[i - 1].ItemArray[7].ToString());
                            }
                            else
                            {
                                
                                dt.Rows[i - 1].ItemArray[0] = dtc.Rows[a][0].ToString();
                                dt.Rows[i - 1].ItemArray[2] = dtc.Rows[a][1].ToString();
                                dt.Rows[i - 1].ItemArray[3] = dtc.Rows[a][2].ToString();
                                dt.Rows[i - 1].ItemArray[5] = dtc.Rows[a][4].ToString();
                                dt.Rows[i - 1].ItemArray[1] = dtc.Rows[a][5].ToString();
                                dt.Rows[i - 1].ItemArray[6] = dtc.Rows[a][6].ToString();
                            }

                        }
                        
                        
                        


                        if (!outputs.ExistClie(dt.Rows[i - 1].ItemArray[0].ToString()))
                            {
                                try
                                {
                                    inputs.inCliente(dt.Rows[i - 1].ItemArray[0].ToString(),
                                                     dt.Rows[i - 1].ItemArray[7].ToString());
                                
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(this, "Error al ingresar cliente \n\n" + ex.Message, "Error IC147");
                                }
                        }      
                }

            }
            catch (Exception ex)
            {
                 MessageBox.Show(this,"Error al ingresar los clientes: \n"+ex.Message,"Error IC156");
            }

                /*Cantidad de acompañantes + el cliente principal*/
                        AdministraReserva.cantidadPersonas = cantidadAcomp + 1;
                AdministraReserva.dtC = dt;
                this.Close();
            }
            else
            {
                cantidadAcomp = 0;
                MessageBox.Show(this,"Debe ingresar al menos un cliente principal","Error IC161",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /*Indico que el cliente no se ingreso y cierro la ventana*/
            AdministraReserva.cantidadPersonas = 0;
            this.Close();
            
        }
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (contr.IsNumber(e.KeyChar) || (int)e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (contr.IsNumber(e.KeyChar)||(int)e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
            
            if (txtCIPass.Text == "" || txtApe.Text == "" || txtNom.Text == "" || dtpFNac.Value == DateTime.Now || txtCelular.Text == "")
            {
                MessageBox.Show(
                    this,
                    "Debe llenar todos los campos", "Error IC202",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

            }
            else
            {

                if (rdCedula.Checked && contr.ValidateCI(txtCIPass.Text) == false)
                {
                    MessageBox.Show(this, "La cedula no es correcta","Error IC213");

                }
                else
                { 
                    Boolean control = true;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dgvClientes.Rows[i].Cells[0].Value.ToString() == txtCIPass.Text)
                        {

                            MessageBox.Show(this,"El cliente ya se ingresó en la lista","Error IC225",MessageBoxButtons.OK,MessageBoxIcon.Question);
                            control = false;
                            break;
                        }
                    }
                    if (control) {
                        string tipo;
                        if (rdPrincipal.Checked)
                        {
                             tipo = "Cliente";
                        }
                        else
                        {
                             tipo = "Acomp";
                        }
                        string Tingreso;
                        if (rdJubPen.Checked)
                        {
                            Tingreso = "Jubilado/Pensionista";
                        }
                        else if (rdTurista.Checked)
                        {
                            Tingreso = "Turista";
                        }
                        else
                        {
                            Tingreso = "Normal";
                        }

                        
                    DataRow dr = dt.NewRow();
                    dr["CI/Pasaporte"] =txtCIPass.Text;
                    dr["Celular"] = txtCelular.Text;
                    dr["Nombre"] = txtNom.Text;
                    dr["Apellido"] = txtApe.Text;
                    dr["Tipo"] = tipo;
                    dr["Ingreso"] = Tingreso;
                    dr["Correo"] = txtCorreo.Text;
                    dr["Fecha de nacimiento"] = String.Format("{0:yyyy/MM/dd}",dtpFNac.Value);

                    dt.Rows.Add(dr);
                        txtApe.Text = "";
                        txtCelular.Text = "";
                        txtCIPass.Text = "";
                        txtNom.Text = "";
                        txtCorreo.Text = "";
                    }
                    dgvClientes.DataSource = dt;

                    controlAcompPrinc();

                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente a la tabla \n"+ex.Message);
            }
        }
        private void rdCedula_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCedula.Checked)
            {
                rdCedula.Text = "Cedula *";
                rdPasaporte.Text = "Pasaporte";
            }
            else
            {
                rdCedula.Text = "Cedula";
                rdPasaporte.Text = "Pasaporte *";
            }
        }
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            CapaNegocios.Outputs outputs = new CapaNegocios.Outputs();

            
        try{ 
            DataTable dtt = new DataTable();

            ADODB.Recordset rs = outputs.ConsultaClientes(txtCIPass.Text.Trim()) ;
            OleDbDataAdapter da = new OleDbDataAdapter();

            da.Fill(dtt, rs);
            if(dtt.Rows.Count == 0)
            {

                MessageBox.Show(this,"El cliente no está ingresado en el sistma", "Busqueda IC296", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            }
            else
            {

                DateTime fnac = DateTime.Parse(dtt.Rows[0][3].ToString());

                txtNom.Text = dtt.Rows[0][1].ToString();
                txtApe.Text = dtt.Rows[0][2].ToString();
                dtpFNac.Value = fnac;
                txtCelular.Text = dtt.Rows[0][4].ToString();
                txtCorreo.Text = dtt.Rows[0][5].ToString();

                    if (dtt.Rows[0][6].ToString()== "Turista")
                    {
                        rdTurista.Checked = true;
                    }
                    else if(dtt.Rows[0][6].ToString() == "Jubilado/Pensionista") 
                    {
                        rdJubPen.Checked = true;
                    }
                    else
                    {
                        rdComun.Checked = true;
                    }
                
            }
        }
        catch (Exception ex)
        {
                MessageBox.Show(this, "Error al consultar los clientes: \n" + ex.Message);
        }
    }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ciElim = dgvClientes.SelectedCells[0].Value.ToString();
            DialogResult op = MessageBox.Show(this, "¿Seguro que desea quitar al cliente " + ciElim + " De la lista?","Eliminar registro",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (op == DialogResult.Yes)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].ItemArray[0].ToString() == ciElim) { 

                    dt.Rows.Remove(dt.Rows[i]);
                        break; 
                    }
                }
                
            }
            controlAcompPrinc();

        }
        private void btnCargar_Click(object sender, EventArgs e)
        {

              
            txtCIPass.Text = dgvClientes.SelectedCells[0].Value.ToString();
            txtCelular.Text = dgvClientes.SelectedCells[1].Value.ToString();
            txtNom.Text = dgvClientes.SelectedCells[2].Value.ToString();
            txtApe.Text = dgvClientes.SelectedCells[3].Value.ToString();
           

            if (dgvClientes.SelectedCells[4].Value.ToString() == "Acomp" )
            {
                rdAcomp.Checked = true;
            }
            else
            {
                rdPrincipal.Checked = true;
            }
            dtpFNac.Text = dgvClientes.SelectedCells[5].Value.ToString();
            txtCorreo.Text = dgvClientes.SelectedCells[6].Value.ToString();

            if (dgvClientes.SelectedCells[7].Value.ToString() == "Jubilado/Pensionista")
            {
                rdJubPen.Checked = true;
            }
            else if(dgvClientes.SelectedCells[7].Value.ToString() == "Turista")
            {
                rdTurista.Checked = true;
            }
            else
            {
                rdComun.Checked = true;
            }

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cimod = txtCIPass.Text;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].ItemArray[0].ToString() == cimod)
                {

                    dt.Rows.Remove(dt.Rows[i]);
                    break;
                }
            }
            btnAgregar_Click(sender, e);
            controlAcompPrinc();
        }


        private void controlAcompPrinc()
        {
            Boolean cont2 = false;
            for (int i = 1; i <= dt.Rows.Count; i++)
            {

                if (dgvClientes.Rows[i - 1].Cells[4].Value.ToString() == "Cliente")
                {
                    cont2 = true;
                }
            }
            if (cont2)
            {
                rdAcomp.Checked = true;
                rdPrincipal.Checked = false;
                rdPrincipal.Enabled = false;
            }
            else
            {
                rdAcomp.Checked = false;
                rdPrincipal.Checked = true;
                rdPrincipal.Enabled = true;
            }
        }
    }
}