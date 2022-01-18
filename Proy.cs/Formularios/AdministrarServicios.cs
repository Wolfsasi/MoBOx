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
   
    public partial class AdministrarServicios : Form
    {
        /*Var globales*/
        private readonly CapaPresentacion.Controles control = new CapaPresentacion.Controles();
        private readonly CapaNegocios.Outputs cons = new CapaNegocios.Outputs();
        private readonly CapaNegocios.Inputs ingr = new CapaNegocios.Inputs();
        private string identMod="";



        /*Initialize Component*/
        public AdministrarServicios()
        {
            InitializeComponent();
        }

        /*LOAD*/
        private void AdministrarServicios_Load(object sender, EventArgs e)
        {
            actualizar();
            dtpApertura.CustomFormat = "HH:mm";
            dtpCierre.CustomFormat = "HH:mm";
        }

        /*METODOS*/
        private void actualizar()
        {
            try
            {
                ADODB.Recordset rs = cons.ConsultaServ();
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
                dgvServicios.Columns[2].DefaultCellStyle.Format = "$####.##";
                

            }

            catch (Exception e)
            {
                MessageBox.Show(this, "Error al cargar los datos: \n\n" + e.Message);
            }
        }


        /*BUTTONS*/
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedCells.Count == 0)
            {
                MessageBox.Show(this, "Debe seleccionar el servicio a modificar","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                string nombre, zona, capacidad;
                string costo;
                
                Boolean estado;
                DateTime horainicio, horafin;

                identMod = dgvServicios.SelectedCells[0].Value.ToString();
                nombre = dgvServicios.SelectedCells[1].Value.ToString();

                /*Costo_I*/
                costo =dgvServicios.SelectedCells[2].Value.ToString();
                costo = costo.Replace(",", ".");

                /*Costo_F*/

                zona = dgvServicios.SelectedCells[3].Value.ToString();

                /*Estado_I*/
                if (dgvServicios.SelectedCells[4].Value.ToString() == "1")
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                /*Estado_F*/

                capacidad = dgvServicios.SelectedCells[5].Value.ToString();
                horainicio = DateTime.Parse(dgvServicios.SelectedCells[6].Value.ToString());
                horafin = DateTime.Parse(dgvServicios.SelectedCells[7].Value.ToString());

                txtNombreServicio.Text = nombre;
                txtCapacidad.Text = capacidad;
                txtPrecioServicio.Text = costo.ToString();
                cboZonas.Text = zona;
                dtpApertura.Value = horainicio;
                dtpCierre.Value = horafin;
                chkEstado.Checked = estado;


            }
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre, zona, capacidad;
            string costo;
            Boolean estado;
            DateTime horainicio, horafin;
            Boolean ingresable=true;
            capacidad = txtCapacidad.Text;
            nombre = txtNombreServicio.Text;
            costo = txtPrecioServicio.Text.Trim();
            zona = cboZonas.Text;
            estado = chkEstado.Checked;
            horainicio = dtpApertura.Value;
            horafin = dtpCierre.Value;

            if (dgvServicios.RowCount > 0)
            {
                
                for (int i = 0; i < dgvServicios.RowCount; i++)
                {
                    
                    if (dgvServicios.Rows[i].Cells[1].Value.ToString() == nombre)
                    {
                        
                        MessageBox.Show("El servicio ya ha sido ingresado");
                        ingresable = false;
                        break;
                    }
                    else
                    {
                        ingresable = true;
                    }
                }
            }





            if (txtNombreServicio.Text.Trim() == "" || txtPrecioServicio.Text.Trim() == "" ||txtCapacidad.Text.Trim() == "") {

                MessageBox.Show(this,"Debe llenar todos los campos para ingresar un nuevo servicio");

            }
            else if(ingresable) {
                
                    try { 
                    ingr.inServicios(nombre, costo, zona,capacidad, estado, horainicio, horafin);

                    }catch(Exception ex)
                    {
                    MessageBox.Show(this,"Error al ingresar los datos: \n\n" + ex.Message);
                    }


            }

            actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string estado;
            if (dgvServicios.SelectedCells[4].Value.ToString() == "1")
            {
                estado = "Disponible";
            }
            else
            {
                estado = "No disponible";
            }
            DialogResult op;
            op = MessageBox.Show(this, "Seguro que desea eliminar el servicio \n\n" +
                "ID: " + dgvServicios.SelectedCells[0].Value +
                "\nNombre: " + dgvServicios.SelectedCells[1].Value +
                "\nPrecio: " + dgvServicios.SelectedCells[2].Value +
                "/Hora\nZona: " + dgvServicios.SelectedCells[3].Value +
                "\nEstado: " + estado +
                "\nCapacidad: " + dgvServicios.SelectedCells[5].Value +
                "\nHora de apertura: " + dgvServicios.SelectedCells[6].Value +
                "\nHora de cierre: " + dgvServicios.SelectedCells[7].Value,
                "Eliminar servicio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
                );

            if (op == DialogResult.Yes)
            {
                ingr.delServicios(dgvServicios.SelectedCells[0].Value.ToString());
                actualizar();
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            string nombre, zona,capacidad;
            string costo;
            Boolean estado;
            DateTime horainicio, horafin;
            if (txtNombreServicio.Text.Trim() == "" || txtPrecioServicio.Text.Trim() == "" || txtCapacidad.Text.Trim() == "")
            {

                MessageBox.Show(this, "Debe llenar todos los campos para ingresar un nuevo servicio");

            }
            else
            {
                nombre = txtNombreServicio.Text;
                costo = txtPrecioServicio.Text.Trim();
                zona = cboZonas.Text;
                estado = chkEstado.Checked;
                horainicio = dtpApertura.Value;
                horafin = dtpCierre.Value;
                capacidad = txtCapacidad.Text;
               

                try
                {
                    
                    ingr.upServicios(identMod,nombre, costo, zona, capacidad, estado, horainicio, horafin);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error al ingresar los datos: \n\n" + ex.Message);
                }


            }


            actualizar();
        }

        /*TXTCONFIG*/
        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (control.IsNumber(e.KeyChar) || (int)e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtPrecioServicio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (control.IsNumber(e.KeyChar) || (int)e.KeyChar == (int)Keys.Back || e.KeyChar == 46) /*caracter 46 = . (Punto)*/
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}
