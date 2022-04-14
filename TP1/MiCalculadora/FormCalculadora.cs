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
        public FormCalculadora()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "";
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            return Calculadora.Operar(operando1, operando2, operador.ToCharArray()[0]);
        }
        #endregion

        #region Events
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = this.txtNumero1.Text.Replace(".", ",");
            string numero2 = this.txtNumero2.Text.Replace(".", ",");
            string operador = this.cmbOperador.Text;
            string operadorAMostrar = operador == " " ? "+" : operador;
            string numero1AMostrar = numero1;
            string numero2AMostrar = numero2;
            if (numero1 == "")
            {
                numero1AMostrar = "0";
            }
            if (numero2 == "")
            {
                numero2AMostrar = "0";
            }
            numero2AMostrar = numero2.StartsWith("-") == true ? $"({numero2})" : numero2AMostrar;
            double resultado = Operar(numero1, numero2, operador);
            string resultadoAMostrar = resultado.ToString();
            if (resultado == double.MinValue && operador == "/")
            {
                resultadoAMostrar = "Inválido";
            }
            this.lblResultado.Text = resultadoAMostrar;
            this.lstOperaciones.Items.Add($"{numero1AMostrar} {operadorAMostrar} {numero2AMostrar} = {resultadoAMostrar}");
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = this.lblResultado.Text;

            if (resultado != "")
            {
                Operando operando = new Operando(resultado);
                this.lblResultado.Text = operando.DecimalBinario(resultado);
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = this.lblResultado.Text;

            if (resultado != "")
            {
                Operando operando = new Operando(resultado);
                this.lblResultado.Text = operando.BinarioDecimal(resultado);
            }
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    
    }
}
