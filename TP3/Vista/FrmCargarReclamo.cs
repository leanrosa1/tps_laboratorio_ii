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
    public partial class FrmCargarReclamo : Form
    {
        private static Serializador<Reclamo> serializador;
        private static Serializador<Empleado> serializadorEmpleado;
        private static Serializador<Vecino> serializadorVecino;
        private static char separador;
        private static string rutaBase;
        private static string rutaBaseVecinos;
        private static string rutaBaseEmpleados;
        private Vecino vecino;
        private Empleado empleado;

        static FrmCargarReclamo()
        {
            serializador = new Serializador<Reclamo>();
            serializadorEmpleado = new Serializador<Empleado>();
            serializadorVecino = new Serializador<Vecino>();
            separador = Path.DirectorySeparatorChar;
            rutaBase = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}{separador}Leandro_Rosa{separador}Reclamos{separador}";
            rutaBaseVecinos = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}{separador}Leandro_Rosa{separador}Vecinos{separador}";
            rutaBaseEmpleados = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}{separador}Leandro_Rosa{separador}Empleados{separador}";
            Directory.CreateDirectory(rutaBase);
        }
        public FrmCargarReclamo()
        {
            InitializeComponent();
            this.cmbTipo.DataSource = Enum.GetValues(typeof(TipoDeReclamo));
            this.dtpFecha.MaxDate = DateTime.Today;
            this.dtpFecha.MinDate = DateTime.Today.AddMonths(-1);
        }

        private bool ValidarSiCamposEstanCompletos()
        {
            return !(string.IsNullOrEmpty(this.rtbObservacion.Text) ||
                (this.cmbTipo.SelectedValue == null) ||
                (this.empleado == null) ||
                (this.vecino == null)
                );
        }

        private Reclamo ObtenerReclamoDesdeFrm()
        {
            DateTime fecha = this.dtpFecha.Value;
            string empleadoNombre = this.empleado.NombreCompleto;
            TipoDeReclamo tipo = (TipoDeReclamo)this.cmbTipo.SelectedIndex;
            string observacion = this.rtbObservacion.Text;
            Guid id = Guid.NewGuid();
            return new Reclamo(fecha, empleadoNombre, tipo, observacion, id);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool puedeGuardar = this.ValidarSiCamposEstanCompletos();
            if (puedeGuardar)
            {
                  Reclamo reclamo = this.ObtenerReclamoDesdeFrm();
                if (reclamo != null)
                {
                    string fileName = $"{reclamo.Identificador}";
                    serializador.SerializarJsonYGuardar($"{rutaBase}{fileName}.txt", reclamo);
                    agregarReclamoAlVecinoYActualizarFile(reclamo);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionarVecino_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = rutaBaseVecinos;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                try
                {
                    this.vecino = serializadorVecino.LeerJson(filePath);
                    if (string.IsNullOrEmpty(this.vecino.Direccion))
                    {
                        throw new Exception();
                    }
                    else
                    {
                        this.lblVecino.Text = $"{this.vecino.NombreCompleto}";
                    }
                }
                catch
                {
                    MessageBox.Show("No se pudo obtener vecino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = rutaBaseEmpleados;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                try
                {
                    this.empleado = serializadorEmpleado.LeerJson(filePath);
                    this.lblEmpleado.Text = $"{this.empleado.NombreCompleto}";
                }
                catch
                {
                    MessageBox.Show("No se pudo obtener empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void agregarReclamoAlVecinoYActualizarFile(Reclamo reclamo)
        {
            this.vecino.AgregarReclamo(reclamo);
            string fileName = $"{rutaBaseVecinos}{this.vecino.Dni}.txt";
            serializadorVecino.SerializarJsonYGuardar(fileName, this.vecino);
        }
    }
}
