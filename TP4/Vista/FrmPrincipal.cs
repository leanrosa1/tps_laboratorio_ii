using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    /// <summary>
    /// Unidades 16 y 17 – Bases de Datos 
    /// Unidades 18, 19 y 17 – Delegados, hilos y eventos 
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        private List<Reclamo> reclamos;
        private ReclamoDAO reclamoDAO;
        private FrmCargarReclamo frmCargarReclamo;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.reclamoDAO = new ReclamoDAO();
            this.frmCargarReclamo = new FrmCargarReclamo();
            this.reclamoDAO.OnFinalizoLeer += OnFinalizoCargaDeReclamos;
            this.frmCargarReclamo.OnNuevoReclamo += RecargarReclamos;
        }

        private void btnCargarVecino_Click(object sender, EventArgs e)
        {
            FrmCargarVecino form = new FrmCargarVecino();
            form.ShowDialog();
        }

        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            FrmCargarEmpleado form = new FrmCargarEmpleado();
            form.ShowDialog();
        }

        private void btnCargarReclamo_Click(object sender, EventArgs e)
        {
            this.frmCargarReclamo.ShowDialog();
        }

        private void btnVerInfoVecino_Click(object sender, EventArgs e)
        {
            FrmVerInfoVecino form = new FrmVerInfoVecino();
            form.ShowDialog();
        }

        private void OnFinalizoCargaDeReclamos()
        {
            if (this.InvokeRequired)
            {
                Action delegado = OnFinalizoCargaDeReclamos;
                this.Invoke(delegado);
            }
            else
            {
                this.btnVerReclamos.Enabled = true;
            }
        }

        private void btnVerReclamos_Click(object sender, EventArgs e)
        {
            FrmVerReclamos form = new FrmVerReclamos(this.reclamos);
            form.ShowDialog();
        }

        private void RecargarReclamos()
        {
            Task.Run(() =>
            {
                this.reclamos = this.reclamoDAO.Leer();
            });
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.RecargarReclamos();
        }
    }
}
