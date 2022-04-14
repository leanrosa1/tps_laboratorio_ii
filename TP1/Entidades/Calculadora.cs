using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza, de ser posible, la operación con los valores recibidos por parámetro.
        /// </summary>
        /// <param name="num1">Valor de tipo Operando</param>
        /// <param name="num2">Valor de tipo Operando</param>
        /// <param name="operador">Valor de tipo Char que representa la operación a realizar</param>
        /// <returns>
        /// De ser válido el parámetro 'operador' recibido, retorna el resultado de la operación indicada.
        /// Caso contrario, retorna la suma entre los valores.
        /// </returns>
        public static double Operar (Operando num1, Operando num2, char operador)
        {
            double ret = 0;
            operador = ValidarOperador(operador);
            
            switch (operador)
            {
                case '+':
                    ret = num1 + num2;
                    break;
                case '-':
                    ret = num1 - num2;
                    break;
                case '/':
                    ret = num1 / num2;
                    break;
                case '*':
                    ret = num1 * num2;
                    break;
            }
            return ret;
        }

        /// <summary>
        /// Valida si el valor tipo Char recibido por parámetro es '+', '-', '*' ó '/'
        /// </summary>
        /// <param name="operador">Valor tipo Char que representa el operado a validar</param>
        /// <returns> De ser un operador válido, lo retorna. Caso contrario, retorna el operador '+'</returns>
        private static char ValidarOperador (char operador)
        {
            char ret;
            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                ret = '+';
            }
            else
            {
                ret = operador;
            }
            return ret;
        }
    }
}
