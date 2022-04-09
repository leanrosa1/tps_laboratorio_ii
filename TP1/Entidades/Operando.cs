using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando () :this(0)
        {
        }

        public Operando (double numero)
        {
            this.numero = numero;
        }

        public Operando (string strNumero) :this(double.Parse(strNumero))
        {
        }

        private double ValidarOperando (string strNumero)
        {
            double ret;
            bool isNumeric = double.TryParse(strNumero, out double numero);
            if (isNumeric)
            {
                ret = numero;
            }
            else
            {
                ret = 0;
            }
            return ret;
        }

        private bool EsBinario (string binario)
        {
            foreach (char caracter in binario)
            {
                if (caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public string BinarioDecimal (string binario)
        {
            string ret;
            bool esBinario = this.EsBinario(binario);
            if (esBinario)
            {
                ret = Convert.ToInt32(binario, 2).ToString();
            }
            else
            {
                ret = "Valor inválido";
            }
            return ret;
        }

        public string DecimalBinario (double numero)
        {
            string ret;
            // PREGUNTAR: dice quedarse con la parte entera y absoluta
            if (numero < 0)
            {
                ret = "Valor inválido";
            }
            else
            {
                int parteEntera = (int)(numero);
                ret = Convert.ToString(parteEntera, 2);
            }
            return ret;
        }

        public string DecimalBinario (string numero)
        {
            string ret;
            bool esNumerico = double.TryParse(numero, out double numeroAConvertir);
            if (esNumerico)
            {
                ret = DecimalBinario(numeroAConvertir);
            }
            else
            {
                ret = "Valor inválido";
            }
            return ret;
        }

        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator * (Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator / (Operando n1, Operando n2)
        {
            double ret;
            if (n2.numero == 0)
            {
                ret = double.MinValue;
            }
            else
            {
                ret = n1.numero / n2.numero;
            }
            return ret;
        }
    }
}
