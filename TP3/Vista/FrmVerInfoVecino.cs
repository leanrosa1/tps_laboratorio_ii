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
    public partial class FrmVerInfoVecino : FormBase
    {
        private static Serializador<Vecino> serializador;
        private static char separador;
        private static string rutaBase;

        static FrmVerInfoVecino()
        {
            serializador = new Serializador<Vecino>();
            separador = Path.DirectorySeparatorChar;
            rutaBase =  $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}{separador}Leandro_Rosa{separador}Vecinos{separador}";
        }
        public FrmVerInfoVecino()
        {
            InitializeComponent();
        }

        protected override bool ValidarSiCamposEstanCompletos()
        {
            throw new NotImplementedException();
        }

        private void btnSeleccionarVecino_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = rutaBase;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                try
                {
                    Vecino vecino = serializador.LeerJson(filePath);
                    if (string.IsNullOrEmpty(vecino.Direccion))
                    {
                        throw new Exception();
                    }
                    else
                    {
                        this.lblVecino.Text = $"{vecino.NombreCompleto}";
                        mostrarVecinoEnRtb(vecino);
                    }
                }
                catch
                {
                    MostrarMensajeDeError("Error", "No se pudo obtener vecino");
                }
            }
        }

        private void mostrarVecinoEnRtb(Vecino vecino)
        {
            this.rtbInfoVecino.Text = vecino.Ficha;
        }
    }
}
