using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public class FormBase : Form
    {
        protected void MostrarMensajeDeError(string titulo, string mensaje)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected virtual bool ValidarSiCamposEstanCompletos()
        {
            return true;
        }
    }
}
