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
using System.Data.OleDb;

namespace Proy.cs.Formularios
{
    public partial class inicio : Form
    {
        /*conexion*/

        /*Declarado de variables publicas y contador*/
        private CapaNegocios.Outputs  outputs = new CapaNegocios.Outputs();
        private CapaNegocios.Inputs inputs = new CapaNegocios.Inputs();
        public static int usuario=0;
        private int flock = 0;
        /*
         Usuario=0 Sin identificar
         Usuario=1 Gerente
         Usuario=2 Administrativo
             */
        public inicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            
            /*Si la conexion esta cerrada(llamo al metodo de la capa de negocios que me da esa informacion) abro la ventana de login, sino cargo los controles para el usuario ingresado)*/
            //!dCon.conexOpen()


            /*flock= fake lock = falso bloqueo
             se utiliza para que al primer inicio se muestre el login, una vez se cierra el login no reaparece de forma constante. el contador se suma y queda en 1 haciendo que al cargar los controles nuevamente no se cargue el loguin*/


            if (outputs.conexOpen())
            {
                CargarControles();
                
                this.Focus();
                ADODB.Recordset rs = new ADODB.Recordset();
                acutalizarRes();
                switch (cboConsulta.SelectedIndex)
                {

                    case 0:
                        /*Sin confirmar*/

                        rs = outputs.consultaReservasCSC("0");
                        break;
                    case 1:
                        /*Confirmados*/
                        rs = outputs.consultaReservasCSC("1");
                        break;
                    default:
                        /*None*/

                        break;

                }
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.Fill(dt, rs);

                dgvRegistros.DataSource = dt;
                acutalizarRes();

            }
            else
            {
                CargarControles();
                if (flock == 0) {
                    flock++;
                    
                    MostrarLogin();
                    
                }
               
               
                

            }
           


        }
        private void mnUsuarioSalir_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show(this, "¿Seguro que desea finalizar la aplicacion?", "Cierre de aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
                
        }
        private void acutalizarRes()
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable();
            rs = outputs.consReservasA24();

            da.Fill(dt, rs);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string idres = dt.Rows[i][0].ToString();



                inputs.delReservas24(idres);
            }

        }
        private void mnUsuarioIngreso_Click(object sender, EventArgs e)
        {

            
            
            if (outputs.conexOpen())
            {
                DialogResult a = MessageBox.Show(this, "¿Seguro que desea finalizar la sesion?", "Cierre de sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {
                    usuario = 0;
                    outputs.cConex();
                    CargarControles();
                }


            }
            else
            {

                MostrarLogin();
            }
            

        }
        private void mnReservasNueva_Click(object sender, EventArgs e)
        {
            AdministraReserva formNReserva = new AdministraReserva();


            formNReserva.Show();
            

            formNReserva.FormClosing += inicio_Load;
        }
        private void mnReservasConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmarReserva frmConfirmarReserva = new ConfirmarReserva();

            frmConfirmarReserva.Show();
            frmConfirmarReserva.Focus();
            
            

            frmConfirmarReserva.FormClosing += inicio_Load;
        }
        private void mnServiciosAdministrar_Click(object sender, EventArgs e)
        {
            AdministrarServicios modificarServicios = new AdministrarServicios();

            modificarServicios.Show();
            modificarServicios.Focus();
            
           

            modificarServicios.FormClosing += inicio_Load;
        }
        public void ControlesGerente()
        {
            mnUsuario.Visible = true;
            btnCargar.Visible = true;
            mnReservas.Visible = true;
            mnServicios.Visible = true;
            cboConsulta.Visible = true;
            dgvRegistros.Visible = true;

            

            mnUsuarioIngreso.Text = "Cerrar sesión";
        }
        public void ControlesAdministrativo()
        {
            mnUsuario.Visible = true;
            btnCargar.Visible = true;
            mnReservas.Visible = true;
            mnServicios.Visible = false;
            cboConsulta.Visible = true;
            dgvRegistros.Visible = true;
            mnUsuarioIngreso.Text = "Cerrar sesión";

        

        }
        public void ControlesInidentificado()
        {

            /*Ocultar todos los controles*/
            btnCargar.Visible = false;
            mnReservas.Visible = false;
            mnServicios.Visible = false;
            cboConsulta.Visible = false;
            dgvRegistros.Visible = false;
            mnUsuario.Visible = true;


            /*Muestro lo necesario para el ingreso de usuario*/
            mnUsuarioIngreso.Text = "Ingresar";

        
        }
        public void MostrarLogin()
        {
            Ingreso frmLogin = new Ingreso();
            

            frmLogin.txtCiPass.Text = "";
            frmLogin.txtPasswd.Text = "";
            frmLogin.MdiParent = this;
            frmLogin.FormClosed += inicio_Load;
            mnUsuario.Visible = false;
            /*inhabilito el uso de esta ventana para el usuario no ingresado*/


            frmLogin.Show();
        }

        public void CargarControles()
        {
            
            /*Consulto el tipo de usuario y con ello muestro los controles necesarios*/
            if (usuario == 1)
            {
                ControlesGerente();
                /*habilito el uso de esta ventana para el usuario ingresado*/
                
            }
            else if (usuario == 2)
            {
                ControlesAdministrativo();
                /*habilito el uso de esta ventana para el usuario ingresado*/
                
            }
            else
            {
                ControlesInidentificado();
                
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            acutalizarRes();
            switch (cboConsulta.SelectedIndex)
            {

                case 0:
                    /*Sin confirmar*/
                    
                    rs = outputs.consultaReservasCSC("0");
                    break;
                case 1:
                    /*Confirmados*/
                    rs = outputs.consultaReservasCSC("1");
                    break;
                default:
                    /*None*/

                    break;

            }
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
                da.Fill(dt, rs);
            
            dgvRegistros.DataSource = dt;
        }
    }
}
