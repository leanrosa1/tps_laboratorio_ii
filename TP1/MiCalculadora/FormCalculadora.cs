using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        #region Constructors
        /// <summary>
        /// Inicializa el formulario llamando a InitializeComponent()
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Borra los valores de txtNumero1, txtNumero2, cmbOperador y lblResultado  
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "";
        }

        /// <summary>
        /// Calcula, de ser posible, el número resultante de los parámetros recibidos
        /// </summary>
        /// <param name="numero1">Valor de tipo string que representa el primer operando</param>
        /// <param name="numero2">Valor de tipo string que representa el segundo operando</param>
        /// <param name="operador">Valor de tipo string que representa el operador</param>
        /// <returns> Valor de tipo double con el resultado </returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            return Calculadora.Operar(operando1, operando2, operador.ToCharArray()[0]);
        }
        #endregion

        #region Events

        /// <summary>
        /// Al dispararse el evento Load en FormCalculadora, invoca a la función Limpiar()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Al dispararse el evento Click en btnLimpiar, invoca a la función Limpiar()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Al dispararse el evento Click en btnOperar , realiza la operación y muestra el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = this.txtNumero1.Text.Replace(".", ",");
            string numero2 = this.txtNumero2.Text.Replace(".", ",");
            string operador = this.cmbOperador.Text;
            double resultado = Operar(numero1, numero2, operador);

            string operadorAMostrar = operador == " " ? "+" : operador;
            string numero1AMostrar = numero1;
            string numero2AMostrar = numero2;
            string resultadoAMostrar = resultado.ToString();

            if (numero1 == "" || !double.TryParse(numero1, out double n)) numero1AMostrar = "0";
            if (numero2 == "" || !double.TryParse(numero2, out n)) numero2AMostrar = "0";
            if (numero2.StartsWith("-")) numero2AMostrar = $"({numero2})";
            if ((resultado == double.MinValue && operador == "/")) resultadoAMostrar = "Inválido";
            
            this.lblResultado.Text = resultadoAMostrar;
            this.lstOperaciones.Items.Add($"{numero1AMostrar} {operadorAMostrar} {numero2AMostrar} = {resultadoAMostrar}");
        }

        /// <summary>
        /// Al dispararse el evento Click en btnConvertirABinario, convierte -de ser posible- el resultado
        /// en su representación binaria y lo muestra en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = this.lblResultado.Text;

            if (resultado != "")
            {
                Operando operando = new Operando(resultado);
                string binario = operando.DecimalBinario(resultado);
                if (binario.ToLower() == "valor inválido")
                {
                    binario = "Inválido";
                }
                this.lblResultado.Text = binario;
            }
        }

        /// <summary>
        /// Al dispararse el evento Click en btnConvertirADecimal, convierte -de ser posible- el resultado
        /// en su representación decimal y lo muestra en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = this.lblResultado.Text;

            if (resultado != "")
            {
                Operando operando = new Operando(resultado);
                string decimalResult = operando.BinarioDecimal(resultado);
                if (decimalResult.ToLower() == "valor inválido")
                {
                    decimalResult = "Inválido";
                }
                this.lblResultado.Text = decimalResult;
            }
        }

        /// <summary>
        /// Al dispararse el evento FormClosing en FormCalculadora, muestra un MessageBox para
        /// que el usuario confirme si efectivamente desea cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Al dispararse el evento Click en btnCerrar, cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    
    }
}
