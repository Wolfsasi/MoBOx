using System;

namespace CapaPresentacion
{
    public class Controles
    {

        /*Validacion de cedula*/

         

        const int coef = 2987634;

        private int validation_N(String ci)
        {
            int ret;


            int sum = 0;
            while (ci.Length <= 6)
            {
                ci += "0";
            }

            for (int i = 0; i < 7; i++) {
                
                int n1 = int.Parse(ci[i].ToString());
                int n2 = int.Parse(coef.ToString()[i].ToString());
                sum += n1 * n2;
            }

            int a = sum.ToString().Length-1;
            int sumP=sum;
            while (sumP.ToString()[a] != '0')
            {
                sumP++;
            }
             ret = sumP - sum;
            

            
            return ret ;

        }
        public bool ValidateCI(String ci)
        {

            bool valid = false;
            ci = ci.Trim();
            /*Remover el ultimo caracter de la cadena que es el identificador*/
            String cinID = ci.Remove(ci.Length - 1);
            cinID =cinID.Trim();
            /*Numero identificador de la cedula ingresado*/
            char ciID = ci[ci.Length - 1];

            while (cinID.Length <= 6)
            {
                cinID += "0";
            }
            
            int ident = validation_N(cinID);

            
            if (ident.ToString().Trim() == ciID.ToString().Trim())
            {
                valid = true;
                

            }
            else if (ident.ToString().Trim() != ciID.ToString().Trim())
            {
                valid = false;
                

            }
            
            
            return valid;

        }

        /*Validacion de caracteres*/
        public Boolean IsNumber(char caracter)
        {
            Boolean esNum;
             
            switch (caracter)
            {
                case '0':
                    esNum = true;
                    break;
                case '1':
                    esNum = true;
                    break;
                case '2':
                    esNum = true;
                    break;
                case '3':
                    esNum = true;
                    break;
                case '4':
                    esNum = true;
                    break;
                case '5':
                    esNum = true;
                    break;
                case '6':
                    esNum = true;
                    break;
                case '7':
                    esNum = true;
                    break;
                case '8':
                    esNum = true;
                    break;
                case '9':
                    esNum = true;
                    break;
                default:
                    esNum = false;
                    break;


            }
            return esNum;
        }

    }
}
