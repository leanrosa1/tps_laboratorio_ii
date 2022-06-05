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
    public partial class FrmCargarEmpleado : FormBase
    {
        private static Serializador<Empleado> serializador;
        private static string rutaBase;
        static FrmCargarEmpleado()
        {
            serializador = new Serializador<Empleado>();
            char separador = Path.DirectorySeparatorChar;
            rutaBase = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}{separador}Leandro_Rosa{separador}Empleados{separador}";
            Directory.CreateDirectory(rutaBase);
        }
        public FrmCargarEmpleado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Unidad 10 – Excepciones 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool puedeGuardar = this.ValidarSiCamposEstanCompletos();
            if (puedeGuardar)
            {
                Empleado empleado = this.ObtenerEmpleadoDesdeFrm();
                if (empleado != null)
                {
                    try
                    {
                        serializador.SerializarJsonYGuardar($"{rutaBase}{empleado.Dni}.txt", empleado);
                        this.Close();
                    }
                    catch
                    {
                        MostrarMensajeDeError("Error", "Ocurrió un error al intentar guardar el archivo");
                    }
                }
            }
            else
            {
                MostrarMensajeDeError("Error", "Complete todos los campos");
            }
        }

        protected override bool ValidarSiCamposEstanCompletos()
        {
            return !(string.IsNullOrEmpty(this.txtNombre.Text) ||
                string.IsNullOrEmpty(this.txtApellido.Text));
        }

        /// <summary>
        /// Unidad 10 – Excepciones 
        /// </summary>
        /// <returns></returns>
        private Empleado ObtenerEmpleadoDesdeFrm()
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            int dni;
            try
            {
                dni = int.Parse(this.txtDni.Text);
            }
            catch
            {
                MostrarMensajeDeError("Error", "Dni inválido");
                return null;
            }
            return new Empleado(nombre, apellido, dni);
        }
    }
}
