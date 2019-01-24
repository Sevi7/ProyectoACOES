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
    public partial class InicioAgente : Form
    {
        private Usuario usuario;
        public InicioAgente()
        {
            InitializeComponent();
        }
        public InicioAgente(Usuario u)
        {
            usuario = u;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GestionSocios socios = new GestionSocios(usuario);
            socios.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GestionarApadrinamientos ap = new GestionarApadrinamientos(usuario);
            ap.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ENVIOS en = new ENVIOS(usuario);
            en.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login log = new Login();
            log.ShowDialog();
        }
    }
}
