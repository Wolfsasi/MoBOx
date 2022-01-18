using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
namespace CapaDatos
{
    public class Ingresos
    {
        public CapaDatos.Consultas cons = new CapaDatos.Consultas();
        public string insertReserva(string idser,string idres,string cipas, string fecha, string horai, string horaf, string ciuser)
        {
            string ercode="SR";
            string fhoy = String.Format("{0:yyyy-MM-dd HH:mm:ss}",DateTime.Now);
            Console.WriteLine(fhoy);
            DateTime fyhTday = DateTime.Now;
            string sqlReserva = "INSERT INTO reserva(id_reserva,pago,fecha_reserva,hora_inicio,hora_fin) VALUES" +
                " ('"+idres+"','"+0+"','"+fecha+"','"+horai+"','"+horaf+"')";

            string sqlHace = "INSERT INTO hace(id_reserva,ci_pas_cliente,ci_pas_personal,fecha_hora_reserva) VALUES " +
                "('"+idres+"','"+cipas+"','"+ciuser+"','"+fhoy+"')";

            string sqlRealiza = "INSERT INTO realiza(id_reserva,ci_pas_personal) VALUES " +
                "('"+idres+"','"+ciuser+"')";
            string sqlTiene = "INSERT INTO tiene(id_servicio,id_reserva) VALUES " +
                "('"+idser+"','"+idres+"')";
            if (Conexion.conex.State == 0)
            {
               cons.abreconex();
            }
            try { 
            Conexion.conex.Execute(sqlReserva, out _, 0);
            }catch(Exception ex)
            {
                ercode = "ER1 "+ex.Message;
            }
            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            try { 
            Conexion.conex.Execute(sqlHace, out _, 0);
            }catch(Exception ex) {
                ercode = "ER2 " + ex.Message;
            }
            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            try { 
            Conexion.conex.Execute(sqlRealiza, out _, 0);
            }
            catch(Exception ex) 
            {
                ercode = "ER3 " + ex.Message;            
            }
            try
            {
                Conexion.conex.Execute(sqlTiene, out _, 0);
            }
            catch (Exception ex)
            {
                ercode = "ER4 " + ex.Message;
            }

            return ercode;
        }
        
        public void insertPerson(string cipas, string nombre, string apellido, string fnac,string celular,string mail,string tipo)
        {

            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            string sql = "INSERT INTO persona(ci_pas,nombre,apellido,f_nac,cel,email,tipo) VALUES ('" + cipas + "','" + nombre + "','" + apellido + "','" + fnac + "','" + celular + "','"+mail+"','"+tipo+"');";
            Conexion.conex.Execute(sql, out _, 0);
            

        }
        public void insertCliente(string cipas,string tipo)
        {
            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            string sql = "INSERT INTO cliente(ci_pas_cliente,tipo) VALUES ('" + cipas + "','" + tipo + "');";
            Conexion.conex.Execute(sql, out _, 0);
            
        }


        public void insertServ(string nombre_servicio, string costo, string zona, string capacidad, Boolean estado, DateTime hora_inicio, DateTime hora_fin)
        {
            string h_i = hora_inicio.ToString("HH:mm");
            string h_f = hora_fin.ToString("HH:mm");
            int est;

            if (estado)
            {
                est = 1;
            }
            else
            {
                est = 0;
            }
            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            string sql = "INSERT INTO servicio (nombre_servicio,costo,zona,capacidad,estado,hora_inicio,hora_fin) VALUES('" + nombre_servicio + "'," + costo + ",'" + zona + "',"+capacidad+ "," + est + ",'" + h_i + "','" + h_f + "');";

            Conexion.conex.Execute(sql, out _,0);
            
        }

        public void updateSer(string idservicio,string nombre_servicio, string costo, string zona, string capacidad, Boolean estado, DateTime hora_inicio, DateTime hora_fin)
        {
            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            string h_i = hora_inicio.ToString("HH:mm");
            string h_f = hora_fin.ToString("HH:mm");
            int est;
            if (estado)
            {
                est = 1;
            }
            else
            {
                est = 0;
            }

            string sql = "UPDATE servicio SET nombre_servicio = '" + nombre_servicio + "', costo = " + costo + ", zona = '" + zona + "', capacidad = " + capacidad + ", estado = " + est +  ", hora_inicio = '" + h_i + "', hora_fin = '" + h_f + "' WHERE id_servicio= "+idservicio+";";

            Conexion.conex.Execute(sql, out _, 0);
        }
        public void updateRes(string idRes,string pago,string metodo_pago)
        {
            string sql = "UPDATE reserva SET pago = '"+pago+"',metodo_pago = '"+metodo_pago+"' WHERE id_reserva = '"+idRes+"';";
            ADODB.Recordset rs = new ADODB.Recordset();

            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }

            rs = Conexion.conex.Execute(sql,out _ , 0);
        }
        public void updatePerson(string cipas, string nombre, string apellido, string fnac, string celular,string mail, string tipo)
        {
            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            string sql = "UPDATE persona SET nombre = '"+nombre+"', apellido = '"+apellido+"', f_nac = '"+fnac+"', cel = '"+celular+"', email = '"+mail+"', tipo = '"+tipo+"' where ci_pas = '"+cipas+"';" ;
            Conexion.conex.Execute(sql, out _, 0);

        }
        public void deleteSer(string idservicio)
        {
            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            string sql= "DELETE FROM servicio WHERE id_servicio ="+idservicio;
            Conexion.conex.Execute(sql, out _, 0);
        }
        public void deleteRes24h(string idres)
        {
            string ercode="";

            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }





                string sqlReserva = "DELETE FROM reserva WHERE id_reserva = '" + idres + "';";

                string sqlHace = "DELETE FROM hace WHERE id_reserva = '" + idres + "';";

                string sqlRealiza = "DELETE FROM realiza WHERE id_reserva = '" + idres + "';";
                string sqlTiene = "DELETE FROM tiene WHERE id_reserva = '" + idres + "';";

                if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            try
            {
                Conexion.conex.Execute(sqlTiene, out _, 0);
            }
            catch (Exception ex)
            {
                ercode = "ER1 " + ex.Message;
            }
            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            try
            {
                Conexion.conex.Execute(sqlHace, out _, 0);
            }
            catch (Exception ex)
            {
                ercode = "ER2 " + ex.Message;
            }
            if (Conexion.conex.State == 0)
            {
                cons.abreconex();
            }
            try
            {
                Conexion.conex.Execute(sqlRealiza, out _, 0);
            }
            catch (Exception ex)
            {
                ercode = "ER3 " + ex.Message;
            }
            try
            {
                Conexion.conex.Execute(sqlReserva, out _, 0);
            }
            catch (Exception ex)
            {
                ercode = "ER4 " + ex.Message;
            }

            Console.Error.WriteLine(ercode);
        }

        }
    }

