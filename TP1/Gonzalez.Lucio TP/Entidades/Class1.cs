using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {

        private double numero;

        public String SetNumero
        {
            set { numero = ValidarNumero(value); }
        }

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }


        private double ValidarNumero(string strNumero)
        {
            double numValidado = 0;

            numValidado = Convert.ToDouble(strNumero);

            return numValidado;
        }

        private static bool EsBinario(string binario)
        {
            foreach (char auxBinario in binario)
            {
                if (auxBinario != '0' && auxBinario != '1')
                {
                    return false;
                }
            }

            return true;
        }

        public static string BinarioDecimal(string binario)
        {
            string valor = "Valor invalido";
            int auxDecimal;

            if (EsBinario(binario))
            {
                auxDecimal = Convert.ToInt32(binario, 2);
                valor = "Valor valido";
            }

            return valor;
        }
        public static string DecimalBinario(double numero)
        {
            string valor = "Valor invalido";
            int num = (int)numero;

            Convert.ToString(num, 2);

            return valor;
        }

        public static string DecimalBinario(string numero)
        {
            string valor = "Valor invalido";
            int num = int.Parse(numero);
            return valor;
        }

        public static double operator +(Numero x, Numero y)
        {
            double resul;

            resul = x.numero + y.numero;

            return resul;
        }
        public static double operator -(Numero x, Numero y)
        {
            double resul;

            resul = x.numero - y.numero;

            return resul;
        }
        public static double operator *(Numero x, Numero y)
        {
            double resul;

            resul = x.numero * y.numero;

            return resul;
        }
        public static double operator /(Numero x, Numero y)
        {
            double resul;

            resul = x.numero / y.numero;

            return resul;
        }

    }
}
