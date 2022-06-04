using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCargarVecino : Form
    {
        private static Serializador<Vecino> serializador;
        private static string rutaBase;
        
        static FrmCargarVecino()
        {
            serializador = new Serializador<Vecino>();
            char separador = Path.DirectorySeparatorChar;
            rutaBase = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}{separador}Leandro_Rosa{separador}Vecinos{separador}";
            Directory.CreateDirectory(rutaBase);
        }
        public FrmCargarVecino()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool puedeGuardar = this.ValidarSiCamposEstanCompletos();
            if (puedeGuardar)
            {
                Vecino vecino = this.ObtenerVecinoDesdeFrm();
                if (vecino != null)
                {
                    serializador.SerializarJsonYGuardar($"{rutaBase}{vecino.Dni}.txt", vecino);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarSiCamposEstanCompletos()
        {
            return !(string.IsNullOrEmpty(this.txtNombre.Text) ||
                string.IsNullOrEmpty(this.txtApellido.Text) ||
                string.IsNullOrEmpty(this.txtDireccion.Text) ||
                string.IsNullOrEmpty(this.txtDni.Text));
        }

        private Vecino ObtenerVecinoDesdeFrm()
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string direccion = this.txtDireccion.Text;
            DateTime fechaDeNacimiento = this.dtpFecha.Value;
            int dni;
            try
            {
                dni = int.Parse(this.txtDni.Text);
            }
            catch
            {
                MessageBox.Show("Dni inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return new Vecino(nombre, apellido, direccion, fechaDeNacimiento, dni);
        }
    }
}
