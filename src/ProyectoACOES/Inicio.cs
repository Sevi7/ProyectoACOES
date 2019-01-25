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
    public partial class Inicio : Form
    {
        private Usuario usuario;
        public Inicio()
        {
            InitializeComponent();
        }
        public Inicio(Usuario u)
        {
            usuario = u;
            InitializeComponent();
        }

        private void crearTipoProyecto_Click(object sender, EventArgs e)
        {
            Hide();
            CrearNuevoTipoProyecto tipoProyecto = new CrearNuevoTipoProyecto(usuario);
            tipoProyecto.ShowDialog();
            
        }

        private void crearProyecto_Click(object sender, EventArgs e)
        {
            Hide();
            CrearNuevoProyecto nuevo = new CrearNuevoProyecto(usuario);
            nuevo.ShowDialog();
            

        }

        private void bNota_Click(object sender, EventArgs e)
        {
            Hide();
            GestionarCalificacion nota = new GestionarCalificacion();
            nota.ShowDialog();
            
        }

        private void bApadrinamientos_Click(object sender, EventArgs e)
        {
            Hide();
            GestionarApadrinamientos ga = new GestionarApadrinamientos(usuario);
            ga.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GestionNinio ninios = new GestionNinio();
            ninios.ShowDialog();
            
        }

        private void bComunidades_Click(object sender, EventArgs e)
        {
            Hide();
            GestionComunidades gc = new GestionComunidades();
            gc.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Validacion v = new Validacion();
            v.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Login l = new Login();
            l.ShowDialog();
        }
    }
}
