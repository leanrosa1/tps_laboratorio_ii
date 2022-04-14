using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        private string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        /// <summary>
        /// Inicializa el atributo numero en 0
        /// </summary>
        public Operando () :this(0)
        {
        }

        /// <summary>
        /// Inicializa el atributo numero con el valor de tipo double recibido por parámetro
        /// </summary>
        /// <param name="numero">Valor tipo double a asignar</param>
        public Operando (double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Inicializa el atributo numero con el valor de tipo string recibido por parámetro
        /// </summary>
        /// <param name="strNumero">Valor tipo string a asignar</param>
        public Operando (string strNumero) 
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Valida si es posible convertir el valor recibido por parámetro. De ser posible, lo convierte.
        /// </summary>
        /// <param name="strNumero">Valor tipo string a validar y convertir</param>
        /// <returns>
        /// Valor tipo double si pudo realizarse la conversión.
        /// En caso de no ser posible, retorna 0.
        /// </returns>
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

        /// <summary>
        /// Valida si el string recibido por parametro representa una cadena formada por '1' y '0'
        /// </summary>
        /// <param name="binario">Valor tipo string a validar</param>
        /// <returns>True si el valor recibido está formado por '1' y '0'. De lo contrario, false.</returns>
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

        /// <summary>
        /// Convierte, de ser posible, el valor tipo string recibido por parámetro en decimal.
        /// </summary>
        /// <param name="binario">Valor tipo string que representa el binario a convertir</param>
        /// <returns>
        /// Si fue posible la conversión, retorna valor tipo string con la representación decimal.
        /// De no ser posible, retorna 'Valor inválido'.
        /// </returns>
        public string BinarioDecimal (string binario)
        {
            string ret;
            bool esBinario = this.EsBinario(binario);
            if (esBinario)
            {
                int resultado = Convert.ToInt32(binario, 2);
                resultado = Math.Abs(resultado);
                ret = resultado.ToString();
            }
            else
            {
                ret = "Valor inválido";
            }
            return ret;
        }

        /// <summary>
        /// Convierte, de ser posible, el valor tipo double recibido por parámetro en binario.
        /// </summary>
        /// <param name="numero">Valor tipo double que representa el decimal a convertir</param>
        /// <returns>
        /// Si fue posible la conversión, retorna valor tipo string con la representación binaria.
        /// De no ser posible, retorna 'Valor inválido'.
        /// </returns>
        public string DecimalBinario (double numero)
        {
            string ret;
            int parteEnteraAbsoluta = Math.Abs((int)numero);
            ret = Convert.ToString(parteEnteraAbsoluta, 2);
            return ret;
        }

        /// <summary>
        /// Convierte, de ser posible, el valor tipo string recibido por parámetro en binario.
        /// </summary>
        /// <param name="numero">Valor tipo string que representa el decimal a convertir</param>
        /// <returns>
        /// Si fue posible la conversión, retorna valor tipo string con la representación binaria.
        /// De no ser posible, retorna 'Valor inválido'.
        /// </returns>
        public string DecimalBinario (string numero)
        {
            string ret;
            bool esNumerico = double.TryParse(numero, out double numeroAConvertir);
            if (esNumerico)
            {
                ret = this.DecimalBinario(numeroAConvertir);
            }
            else
            {
                ret = "Valor inválido";
            }
            return ret;
        }

        /// <summary>
        /// Sobrecarga de operador '-' que resta los atributos 'numero' de los valores de tipo Operando recibidos.
        /// </summary>
        /// <param name="n1">Valor de tipo Operando</param>
        /// <param name="n2">Valor de tipo Operando</param>
        /// <returns>Resta de los atributos 'numero' de n1 y n2</returns>
        public static double operator - (Operando n1, Operando n2)
        {
            return Math.Round((n1.numero - n2.numero), 4);
        }

        /// <summary>
        /// Sobrecarga de operador '+' que suma los atributos 'numero' de los valores de tipo Operando recibidos.
        /// </summary>
        /// <param name="n1">Valor de tipo Operando</param>
        /// <param name="n2">Valor de tipo Operando</param>
        /// <returns>Suma de los atributos 'numero' de n1 y n2</returns>
        public static double operator + (Operando n1, Operando n2)
        {
            return Math.Round((n1.numero + n2.numero), 4);
        }

        /// <summary>
        /// Sobrecarga de operador '*' que multiplica los atributos 'numero' de los valores de tipo Operando recibidos.
        /// </summary>
        /// <param name="n1">Valor de tipo Operando</param>
        /// <param name="n2">Valor de tipo Operando</param>
        /// <returns>Producto de los atributos 'numero' de n1 y n2</returns>
        public static double operator * (Operando n1, Operando n2)
        {
            return Math.Round((n1.numero * n2.numero), 4);
        }

        /// <summary>
        /// Sobrecarga de operador '/' que divide, de ser posible, los atributos 'numero' 
        /// de los valores de tipo Operando recibidos.
        /// </summary>
        /// <param name="n1">Divisor de tipo Operando</param>
        /// <param name="n2">Dividendo de tipo Operando</param>
        /// <returns>
        /// De ser posible realizar la división, retorna el cociente de los atributos 'numero' de n1 y n2.
        /// Caso contrario, retorna double.MinValue.
        /// </returns>
        public static double operator / (Operando n1, Operando n2)
        {
            double ret;
            if (n2.numero == 0)
            {
                ret = double.MinValue;
            }
            else
            {
                ret = Math.Round((n1.numero / n2.numero), 4);
            }
            return ret;
        }
    }
}
