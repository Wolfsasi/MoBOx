using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using System.Data;
using System.Data.OleDb;
namespace CapaNegocios
{
    public class Inputs
    {
        private readonly CapaDatos.Ingresos ing = new CapaDatos.Ingresos();

        public string inReservas(string idser,string idres, string cipas, string fecha, string horai, string horaf, string ciuser)
        {
            
            string er = "SR";
            er = ing.insertReserva(idser ,idres, cipas, fecha, horai, horaf, ciuser);

            return er;
        }

        public void inServicios(string nombre_servicio, string costo, string zona, string capacidad , Boolean estado, DateTime hora_inicio,DateTime hora_fin)
        {
            ing.insertServ(nombre_servicio, costo, zona, capacidad , estado, hora_inicio, hora_fin);
        }  
        public void inPersona(string cipas, string nombre, string apellido, string fnac, string celular,string mail,string tipo)
        {

            ing.insertPerson(cipas, nombre, apellido, fnac, celular, mail, tipo);
        }
        public void inCliente(string cipas,string tipo)
        {
            ing.insertCliente(cipas, tipo);
        }
        
        public void upServicios(string idservicio, string nombre_servicio, string costo, string zona, string capacidad, Boolean estado, DateTime hora_inicio, DateTime hora_fin)
        {
            
            ing.updateSer(idservicio, nombre_servicio, costo, zona, capacidad, estado, hora_inicio, hora_fin);
        }
        public void upPersonas(string cipas, string nombre, string apellido, string fnac, string celular,string mail, string tipo)
        {
            ing.updatePerson(cipas, nombre, apellido, fnac, celular, mail, tipo);
        }
        
        public void upConfReservas(string idRes,string pago, string m_pago)
        {
            ing.updateRes(idRes,pago,m_pago);
        }
        public void delServicios(string idservicio)
        {
            ing.deleteSer(idservicio);
        }

        public void delReservas24(string idres)
        {

            ing.deleteRes24h(idres);
        }
    }
}
