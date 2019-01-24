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
    public partial class CrearNuevoTipoProyecto : Form
    {
        private List<Socio> sociosdonantes= new List<Socio>();
        
        
        public CrearNuevoTipoProyecto()
        {
            InitializeComponent();
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                Socio s = new Socio(Convert.ToInt32(tSocio.Text));
                tSocio.Text = "";
                sociosdonantes.Add(s);
                listaSocios.Items.Add(s.codigo_socio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            try
            {
                new TipoProyecto(tNombre.Text, tDescripcion.Text, new Usuario(tCoordinador.Text), new Usuario(tResponsable.Text), sociosdonantes);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }

        private void CrearNuevoTipoProyecto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inicio i = new Inicio();
            i.ShowDialog()
        }
    }
}
