using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoACOES
{
    public partial class AñadirNota : Form
    {
        public AñadirNota()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tAsignatura.Text != "" && tNota.Text != "" && tCodigo.Text != "")
            {
                new Calificacion(Convert.ToInt32(tCodigo.Text), Convert.ToInt32(tNota.Text), tAsignatura.Text,  dFecha.Value);
            }
        }
    }
}
