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
    public partial class FrmVerReclamos : FormBase
    {
        private List<Reclamo> reclamos;

        public FrmVerReclamos(List<Reclamo> reclamos)
        {
            InitializeComponent();
            this.reclamos = reclamos;
            MostrarReclamos();
        }

        protected override bool ValidarSiCamposEstanCompletos()
        {
            throw new NotImplementedException();
        }

        private void MostrarReclamos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Reclamo reclamo in this.reclamos)
            {
                sb.AppendLine(reclamo.ObtenerInformacion());
            }
            this.rtbReclamos.Text = sb.ToString();
        }
    }
}
