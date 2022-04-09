using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar (Operando num1, Operando num2, char operador)
        {
            double ret = 0;
            operador = ValidarOperador(operador);
            
            // PREGUNTAR
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
