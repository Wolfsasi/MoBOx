using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
namespace CapaDatos
{
    public class Consultas
    {


        /*Indica si la conexion esta abierta(true) o si esta cerrada(false)*/

        public static Boolean apconex = false;
        public static string cipasing;
        private static string pwd;

        public void abreconex()
        {
            Conexion.conex.Open("outbox", cipasing, pwd, -1);
        }
        public string ConsultaLog(string cipass, string passwd)
        {

            try
            {

                ADODB.Recordset rs = new ADODB.Recordset();

                string cargo = "";


                Conexion.conex.Open("outbox", cipass, passwd, -1);


                rs = Conexion.conex.Execute("SELECT cargo FROM administracion where ci_pas_personal = '" + cipass + "'", out _, 0);
                /*El objeto " _ "(Guion bajo) sirve para descartar salidas*/


                if (rs.BOF && rs.EOF)
                {
                    apconex = false;
                    Conexion.conex.Close();



                }
                else
                {
                    cargo = rs.Fields[0].Value.ToString();
                    cipasing = cipass;
                    pwd = passwd;
                    apconex = true;
                }
                if (cargo == "")
                {
                    cargo = "Usuario no ingresado en el sistema (tabla adm)";
                }

                return cargo;
            }

            catch (Exception e)
            {
                string err = e.Message;
                return err;
            }

        }
        public void cConex()
        {          
            apconex = false;
            cipasing = "";
            pwd = "";
            if(Conexion.conex.State != 0) { 
            Conexion.conex.Close();
            }
        }

        /*Utilizar para todas las consultas de la base de datos*/
        public ADODB.Recordset ConsultaCiCliente(string cipass)
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            
           

            string consulta = "SELECT c.ci_pas_cliente FROM cliente c where c.ci_pas_cliente = '"+cipass+"'; ";
            if(Conexion.conex.State == 0) { 
                abreconex();
            }
                rs = Conexion.conex.Execute(consulta, out _, 0);

            return rs;
        }
        public ADODB.Recordset ConsultaDatClientes(string cipass)
        {

            if (Conexion.conex.State == 0)
            {
                abreconex();
            }
            ADODB.Recordset rs = new ADODB.Recordset();

            string consulta = "SELECT p.ci_pas, p.nombre, p.apellido, p.f_nac, p.cel, p.email, p.tipo FROM cliente c INNER JOIN persona p ON p.ci_pas = c.ci_pas_cliente WHERE c.ci_pas_cliente = '" + cipass + "'; ";

            rs = Conexion.conex.Execute(consulta,out _, 0);

           

            return rs;
        }
        public ADODB.Recordset ConsultaCiPersonas(string cipass)
        {

            if (Conexion.conex.State == 0)
            {
                abreconex();
            }
            ADODB.Recordset rs = new ADODB.Recordset();


            string consulta = "SELECT ci_pas FROM persona where ci_pas = '"+cipass+"' ;";

            rs = Conexion.conex.Execute(consulta, out _, 0);

            
            return rs;
        }
        public ADODB.Recordset consultaServ()
        {

            if (Conexion.conex.State == 0)
            {
                abreconex();
            }

            ADODB.Recordset rs = new ADODB.Recordset();

            string sql = "SELECT id_servicio AS 'ID',nombre_servicio AS 'Servicio',costo AS 'Precio/hora',zona AS 'Zona',estado AS 'Estado', capacidad AS 'Capacidad' ,hora_inicio AS 'Hora de apertura',hora_fin AS 'Hora de cierre' FROM servicio;";
                rs = Conexion.conex.Execute(sql, out _, 0);

            
            return rs;
        }

        public ADODB.Recordset UltimoIDReserva()
        {

            if (Conexion.conex.State == 0)
            {
                abreconex();
            }
            ADODB.Recordset rs = new ADODB.Recordset();

            string sql = "SELECT id_reserva from reserva order by id_reserva desc limit 1;";
            rs = Conexion.conex.Execute(sql, out _, 0);

            return rs;
        }

        public ADODB.Recordset ReservasDeCliente(string cipas)
        {
            ADODB.Recordset rs = new ADODB.Recordset();

            if (Conexion.conex.State == 0)
            {
                abreconex();
            }
            string sql = "SELECT r.id_reserva,r.pago,r.fecha_reserva,r.hora_inicio,r.hora_fin,s.costo,s.nombre_servicio FROM reserva r " +
                "INNER JOIN hace h on h.id_reserva = r.id_reserva " +
                "INNER JOIN tiene t ON t.id_reserva = r.id_reserva " +
                "INNER JOIN servicio s ON s.id_servicio = t.id_servicio " +
                "WHERE h.ci_pas_cliente = '"+cipas+"' AND r.pago = 0 ; ";
            rs = Conexion.conex.Execute(sql,out _, 0);

            return rs;
        }

        public ADODB.Recordset reservasCSC(string tipo)
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            string sql = "SELECT r.id_reserva,s.nombre_servicio,p.ci_pas,p.nombre,p.apellido,r.hora_inicio,r.hora_fin FROM reserva r " +
                " INNER JOIN hace h on h.id_reserva = r.id_reserva" +
                " INNER JOIN tiene t ON t.id_reserva = r.id_reserva" +
                " INNER JOIN servicio s ON s.id_servicio = t.id_servicio" +
                " INNER JOIN persona p ON p.ci_pas = h.ci_pas_cliente" +
                " WHERE r.pago = '"+tipo+"' ; ";


            if (Conexion.conex.State == 0)
            {
                abreconex();
            }

            rs = Conexion.conex.Execute(sql,out _, 0);

            return rs;

        }
         
        public ADODB.Recordset consCapacidadTot(string idser)
        {
            ADODB.Recordset rs = new ADODB.Recordset();

            string sql = "select capacidad from servicio where id_servicio = '"+idser+"'";

            if (Conexion.conex.State == 0)
            {
                abreconex();
            }
            rs = Conexion.conex.Execute(sql,out _, 0);

            return rs;

        }
        public ADODB.Recordset consCapacidadOc(string hora,string idser,string fecha)
        {
            ADODB.Recordset rs = new ADODB.Recordset();
           
            string sql = "select count(r.id_reserva) from reserva r " +
                "inner join tiene t on r.id_reserva = t.id_reserva " +
                "where '"+hora+"' between r.hora_inicio and r.hora_fin and t.id_servicio = '"+idser+"' and r.fecha_reserva = '"+fecha+"';";

            
            if (Conexion.conex.State == 0)
            {
                abreconex();
            }

            rs = Conexion.conex.Execute(sql,out _, 0);



            return rs;
        }

        public ADODB.Recordset consReservasA24()
        {
            ADODB.Recordset rs = new ADODB.Recordset();

            string sql = "SELECT id_reserva FROM hace WHERE fecha_hora_reserva < '" + String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now.AddHours(-24)) + "';";
            if (Conexion.conex.State == 0)
            {
                abreconex();
            }

            rs = Conexion.conex.Execute(sql,out _, 0);

            return rs;
        }
    }
}
