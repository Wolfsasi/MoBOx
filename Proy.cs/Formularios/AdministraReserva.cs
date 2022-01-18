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
    public partial class AdministraReserva : Form
    {
        
        private DataTable dt = new DataTable();
        private string cipass;
        private string tipocli;

        private CapaNegocios.Outputs outputs = new CapaNegocios.Outputs();
        private CapaNegocios.Inputs inputs = new CapaNegocios.Inputs();
        public static DataTable dtC = new DataTable();
        public static int cantidadPersonas=0;
        private int id = 0,_lastUid = 0;

        public AdministraReserva()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            /*id reserva,Cedula,Tipo,Fecha,Hora inicio, Hora fin, ciAdministrativo, Fecha y hora actual*/
            for (int i = 0; i < dgvPreReservas.Rows.Count; i++)
            {
                
                string idres,ci, tipo, fecha, horai, horaf, ciuser, idser;
                string er;
                
                ciuser = outputs.obtPersonal();

                idres = dgvPreReservas.Rows[i].Cells[0].Value.ToString();
                ci = dgvPreReservas.Rows[i].Cells[1].Value.ToString();
                tipo = dgvPreReservas.Rows[i].Cells[2].Value.ToString();
                fecha = dgvPreReservas.Rows[i].Cells[3].Value.ToString();
                horai = dgvPreReservas.Rows[i].Cells[4].Value.ToString();
                horaf = dgvPreReservas.Rows[i].Cells[5].Value.ToString();
                idser = dgvPreReservas.Rows[i].Cells[6].Value.ToString();
                
                /*string idres,string cipas, string fecha, string horai, string horaf, string ciuser, string fyhTday*/
                try {


                    
                    er = inputs.inReservas(idser,idres, ci, fecha, horai, horaf, ciuser);
                    
                    if (er != "SR")
                    {
                        MessageBox.Show(this,er,"Error AR076");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error al ingresar la reserva \n" + ex.Message, "Error AR74");
                }

            }
            MessageBox.Show(this, "Reservas ingresadas exitosamente", "Reservas");
            this.Close();

        }



            private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.Close();

            }
            private void NuevaReserva_Load(object sender, EventArgs e)
            {
                  id = outputs.UltimaIDReserva()+1;
            _lastUid = id;
            dtpHoraReserva.CustomFormat = "HH:mm";
                lblClienteSel.Text = "Cliente seleccionado:\nSin seleccionar";


                /*Al generar una nueva reserva pido los datos del cliente para asignarle la reserva*/
                IngresoCliente frmIngresoC = new IngresoCliente();
            this.Enabled = false;
            frmIngresoC.Show();
            frmIngresoC.FormClosed += aux;
            

            /*CiCliente*/
            DataColumn Dcid = new DataColumn();
            Dcid.DataType = Type.GetType("System.String");
            Dcid.ColumnName = "ID";
            dt.Columns.Add(Dcid);

            /*TAB RESERVA*/
            /*CiCliente*/
            DataColumn DcCli = new DataColumn();
            DcCli.DataType = Type.GetType("System.String");
            DcCli.ColumnName = "Cliente";
            dt.Columns.Add(DcCli);


            /*TipoCliente*/
            DataColumn DcTipo = new DataColumn();
            DcTipo.DataType = Type.GetType("System.String");
            DcTipo.ColumnName = "Ingreso";
            dt.Columns.Add(DcTipo);

            /*Fecha*/
            DataColumn DcFecha = new DataColumn();
            DcFecha.DataType = Type.GetType("System.String");
            DcFecha.ColumnName = "Fecha";
            dt.Columns.Add(DcFecha);

            /*Hora de inicio*/
            DataColumn DcHin = new DataColumn();
            DcHin.DataType = Type.GetType("System.String");
            DcHin.ColumnName = "Hora inicio";
            dt.Columns.Add(DcHin);

            /*Hora fin*/
            DataColumn DcHFin = new DataColumn();
            DcHFin.DataType = Type.GetType("System.String");
            DcHFin.ColumnName = "Hora de finalizacion";
            dt.Columns.Add(DcHFin);

            /*idServicio*/
            DataColumn DcIdSer = new DataColumn();
            DcIdSer.DataType = Type.GetType("System.String");
            DcIdSer.ColumnName = "IDServicio";
            dt.Columns.Add(DcIdSer);

        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
            DialogResult op = MessageBox.Show(this,"Seguro que desea eliminar la reserva ID:",
                                                                                             "Confirmacion",
                                                                                              MessageBoxButtons.YesNo,
                                                                                             MessageBoxIcon.Warning);
            if (op == DialogResult.Yes)
            {

               
                /*Metodo de eliminar reserva de bdd*/
                MessageBox.Show(this, "Reserva eliminada exitosamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            

        }
        private void dgvSalidaReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void aux(object sender, EventArgs e)
        {
            this.Enabled = true;
            if (cantidadPersonas == 0)
            {
                this.Close();
            }
            else
            {
                actualizarServ();
                dgvCientes.DataSource = dtC;
                this.Focus();
            }
        }
        private void actualizarServ()
        {
            try
            {
                ADODB.Recordset rs = outputs.ConsultaServ();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter();

                da.Fill(dt, rs);
                dgvServicios.DataSource = dt;

                /*Ajustar el tamaño de las columnas*/
                dgvServicios.Columns[0].Width = 25;
                dgvServicios.Columns[1].Width = 150;
                dgvServicios.Columns[2].Width = 70;
                dgvServicios.Columns[3].Width = 40;
                dgvServicios.Columns[4].Width = 45;
                dgvServicios.Columns[5].Width = 65;
                dgvServicios.Columns[6].Width = 110;
                dgvServicios.Columns[7].Width = 100;

                /*Ocultar cabecera de filas*/
                dgvServicios.RowHeadersVisible = false;

                /*Mostrar solamente la barra de desplazamiento vertical*/
                dgvServicios.ScrollBars = ScrollBars.Vertical;
                /*Dar formato a las columnas*/
                dgvServicios.Columns[2].DefaultCellStyle.Format = "US$####.##";


            }

            catch (Exception e)
            {
                MessageBox.Show(this, "Error al cargar los datos: \n\n" + e.Message);
            }
        }
        private void actualizarRes()
        {
            dgvPreReservas.DataSource = dt;
        }

        private void btnAgregarSer_Click(object sender, EventArgs e)
        {

            if (cipass == null)
            {
                MessageBox.Show(this, "Debe seleccionar un cliente antes de ingresar una reserva", "Error AR201", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dtpHoraReserva.Value <= DateTime.Now && dtpFechaReserva.Value <= DateTime.Today)
            {
                MessageBox.Show(this, "No puede reservar para antes de la hora actual", "Error AR209", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dtpFechaReserva.Value <= DateTime.Today)
            {

                MessageBox.Show(this, "La fecha no puede ser menor a la de hoy", "Error AR205", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (nudHoras.Value <= 0)
            {
                MessageBox.Show(this, "No puede reservar 0 horas de un servicio", "Error AR212", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (DateTime.Parse(String.Format("{0:HH:mm}", dtpHoraReserva.Value)) <= DateTime.Parse(dgvServicios.SelectedCells[6].Value.ToString())
                 || DateTime.Parse(String.Format("{0:HH:mm}", dtpHoraReserva.Value)) >= DateTime.Parse(dgvServicios.SelectedCells[7].Value.ToString()))
                {

                    MessageBox.Show(this, "Horario invalido, debe ser mayor a " + dgvServicios.SelectedCells[6].Value.ToString() + "\n"
                        + "Y menor a " + dgvServicios.SelectedCells[7].Value.ToString());
                }
                else if (DateTime.Parse(String.Format("{0:HH:mm}", dtpHoraReserva.Value.AddHours(int.Parse(nudHoras.Value.ToString())))) >=
                    DateTime.Parse(dgvServicios.SelectedCells[7].Value.ToString())) 
                {
                    MessageBox.Show(this,"Hora de finalizacion invalida, la reserva no puede terminar despues de las "+ dgvServicios.SelectedCells[7].Value.ToString());
                }
                
                else
                { 
                if (outputs.hayCupos(dgvServicios.SelectedCells[0].Value.ToString(),
                                    String.Format("{0:HH:mm}", dtpHoraReserva.Value),
                                    String.Format("{0:yyyy/MM/dd}", dtpFechaReserva.Value)))
                {
            
                DataRow dr = dt.NewRow();
            dr["ID"] = id;
            dr["Cliente"] = cipass;
            dr["Ingreso"] = tipocli;
            dr["Fecha"] = String.Format("{0:yyyy/MM/dd}", dtpFechaReserva.Value);
            dr["Hora inicio"] = String.Format("{0:HH:mm}", dtpHoraReserva.Value);
            dr["Hora de finalizacion"] = String.Format("{0:HH:mm}", dtpHoraReserva.Value.AddHours(int.Parse(nudHoras.Value.ToString())));
                dr["IDServicio"] = dgvServicios.SelectedCells[0].Value.ToString();

            dt.Rows.Add(dr);
                id++;
            actualizarRes();
                }
                else
                {
                    MessageBox.Show(this, "No hay cupos para la hora: " + String.Format("{0:HH:mm}", dtpHoraReserva.Value), "Reservas");
                }
            }
            }
        }
         
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {

            cipass = dgvCientes.SelectedCells[0].Value.ToString();
            tipocli = dgvCientes.SelectedCells[7].Value.ToString();
            lblClienteSel.Text = "Cliente seleccionado:\n"+cipass;

        }

        private void btnEliminarSer_Click(object sender, EventArgs e)
        {
            try {
                if (dgvPreReservas.SelectedCells.Count != -1) { 
            string idElim = dgvPreReservas.SelectedCells[0].Value.ToString();
            DialogResult op = MessageBox.Show(this, "¿Seguro que desea quitar el servicio " + idElim + " De la lista?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (op == DialogResult.Yes)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].ItemArray[0].ToString() == idElim)
                    {
                        dt.Rows.Remove(dt.Rows[i]);
                            id--;
                        break;
                    }
                }
                 for (int i = 0; i< dgvPreReservas.Rows.Count; i++)
                {
                    dgvPreReservas.Rows[i].Cells[0].Value = _lastUid+i;
                }
            }
                }
                else
                {
                    MessageBox.Show(this,"Debe seleccionar la fila que desea eliminar de la tabla","Error AR315",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error AR320");
            }
        }
    }

}
