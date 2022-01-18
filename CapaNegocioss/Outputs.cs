using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocios
{ 
    public class Outputs
    {
       private readonly CapaDatos.Consultas cons = new CapaDatos.Consultas();

        public string obtPersonal()
        {

                string ci = CapaDatos.Consultas.cipasing;
            return ci;
        }
        public string ConsultaLog(string nombre, string passwd)
        {
            string cargo = cons.ConsultaLog(nombre, passwd);
            return cargo;
        }

        public Boolean conexOpen()
        {

            Boolean cnx = CapaDatos.Consultas.apconex;
            
            return cnx;
        }

        /*dat*/
        public Boolean ExistClie(string cipass)
        {
            Boolean existC = false;
            ADODB.Recordset datosC;

            datosC = cons.ConsultaCiCliente(cipass);
            if (datosC.BOF && datosC.EOF)
            {
                existC = false;
                
            }
            else
            {
                existC = true;
            }
            
            return existC;
            
        }
        public ADODB.Recordset ConsultaClientes(string ci_pass)
        {
            ADODB.Recordset datosC = new ADODB.Recordset();
           
                datosC = cons.ConsultaDatClientes(ci_pass);
            
            return datosC;

        }

        public Boolean ExistPer(string cipass)
        {
            Boolean existP = false;
            ADODB.Recordset rs = new ADODB.Recordset();
            rs = cons.ConsultaCiPersonas(cipass);

            if (rs.EOF && rs.BOF)
            {
                existP = false;
            }
            else
            {
                existP = true;
            }
            
            return existP;
        }

        public ADODB.Recordset ConsultaServ()
        {

            ADODB.Recordset rs = new ADODB.Recordset();
                rs = cons.consultaServ();

            return rs;
        }

        public void cConex()
        {
            cons.cConex();
        }

        public int UltimaIDReserva()
        {
            int ID;
            ADODB.Recordset rs = cons.UltimoIDReserva();
            if (rs.BOF && rs.EOF)
            {
                ID = 0;
            }
            else
            {
                ID = int.Parse(rs.Fields[0].Value.ToString());
            }


            return ID;
        }

        public ADODB.Recordset consReservasA24()
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            rs = cons.consReservasA24();

            return rs;
        }

        public ADODB.Recordset consultaReservasCSC(string tipo)
        {
            ADODB.Recordset rs = new ADODB.Recordset();

            rs = cons.reservasCSC(tipo);

            return rs;
        }
        

        public ADODB.Recordset consultReservaClient(string cipas)
        {
            ADODB.Recordset rs = new ADODB.Recordset();

            rs = cons.ReservasDeCliente(cipas);

            return rs;
        }


        public Boolean hayCupos(string idser,string hora,string fecha)
        {
            Boolean cup= false;
            ADODB.Recordset rsO = new ADODB.Recordset();
            ADODB.Recordset rsT = new ADODB.Recordset();

            rsO = cons.consCapacidadOc(hora, idser,fecha);
            rsT = cons.consCapacidadTot(idser);

            int total=0, ocupado=0;

            if (!rsO.BOF && !rsO.EOF) 
            {
                ocupado = int.Parse(rsO.Fields[0].Value.ToString());
            }
            
            if(!rsT.BOF && !rsT.EOF)
            {
                total = int.Parse(rsT.Fields[0].Value.ToString());
            }

            if (total > ocupado)
            {
                cup = true;
            }
            return cup;
        }
    }
}
