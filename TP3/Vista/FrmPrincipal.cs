using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

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
            FrmCargarReclamo form = new FrmCargarReclamo();
            form.ShowDialog();
        }

        private void btnVerInfoVecino_Click(object sender, EventArgs e)
        {
            FrmVerInfoVecino form = new FrmVerInfoVecino();
            form.ShowDialog();
        }
    }
}
