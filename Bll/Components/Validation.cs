using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bll.Components
{
    public class Validation
    {
        #region Constantes

        public const string REGULAR_EXPRESSION_DATE = "(((0[1-9]|[12][0-9]|3[01])([/])(0[13578]|10|12)([/])(\\d{4}))|(([0][1-9]|[12][0-9]|30)([/])(0[469]|11)([/])(\\d{4}))|((0[1-9]|1[0-9]|2[0-8])([/])(02)([/])(\\d{4}))|((29)(\\.|-|\\/)(02)([/])([02468][048]00))|((29)([/])(02)([/])([13579][26]00))|((29)([/])(02)([/])([0-9][0-9][0][48]))|((29)([/])(02)([/])([0-9][0-9][2468][048]))|((29)([/])(02)([/])([0-9][0-9][13579][26])))";
        public const string REGULAR_EXPRESSION_EMAIL = @"^(([^<>()[\]\\.,;:\s@\""]+"
                        + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                        + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                        + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                        + @"[a-zA-Z]{2,}))$";

        #endregion

        public static void Validate(bool condition, string message)
        {
            if (!condition)
            {
                throw new ApplicationException(message);
            }
        }

        public static bool DateValidate(string date)
        {
            return Regex.IsMatch(date, REGULAR_EXPRESSION_DATE);
        }

        public static bool EmailValidate(string email)
        {
            return Regex.IsMatch(email, REGULAR_EXPRESSION_EMAIL);
        }

        public static bool CPFValidate(string cpf)
        {
            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
            {
                return false;
            }

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
            {
                if (valor[i] != valor[0])
                {
                    igual = false;
                }
            }

            if (igual || valor == "12345678909")
            {
                return false;
            }

            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
            {
                numeros[i] = int.Parse(
                valor[i].ToString());
            }

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += (10 - i) * numeros[i];
            }

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                {
                    return false;
                }
            }
            else if (numeros[9] != 11 - resultado)
            {
                return false;
            }

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += (11 - i) * numeros[i];
            }

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                {
                    return false;
                }

            }
            else
            {
                if (numeros[10] != 11 - resultado)
                {
                    return false;
                }
            }

            return true;

        }

        private static Boolean cnpjValidate(String cnpj)
        {

            Int32[] digitos, soma, resultado;
            Int32 nrDig;
            String ftmt;
            Boolean[] cnpjOk;

            cnpj = cnpj.Replace("/", "");
            cnpj = cnpj.Replace(".", "");
            cnpj = cnpj.Replace("-", "");

            if (cnpj == "00000000000000")
            {
                return false;
            }

            ftmt = "6543298765432";
            digitos = new Int32[14];
            soma = new Int32[2];
            soma[0] = 0;
            soma[1] = 0;

            resultado = new Int32[2];
            resultado[0] = 0;
            resultado[1] = 0;
            cnpjOk = new Boolean[2];
            cnpjOk[0] = false;
            cnpjOk[1] = false;

            try
            {

                for (nrDig = 0; nrDig < 14; nrDig++)
                {

                    digitos[nrDig] = int.Parse(cnpj.Substring(nrDig, 1));

                    if (nrDig <= 11)

                        soma[0] += (digitos[nrDig] *

                        int.Parse(ftmt.Substring(nrDig + 1, 1)));

                    if (nrDig <= 12)

                        soma[1] += (digitos[nrDig] *

                        int.Parse(ftmt.Substring(nrDig, 1)));

                }

                for (nrDig = 0; nrDig < 2; nrDig++)
                {

                    resultado[nrDig] = (soma[nrDig] % 11);

                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))

                        cnpjOk[nrDig] = (digitos[12 + nrDig] == 0);

                    else

                        cnpjOk[nrDig] = (digitos[12 + nrDig] == (

                        11 - resultado[nrDig]));

                }

                return (cnpjOk[0] && cnpjOk[1]);

            }

            catch
            {

                return false;

            }

        }

    }
}
