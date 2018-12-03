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
           Socio s = new Socio(tSocio.Text);
           tSocio.Text = "";
           sociosdonantes.Add(s);
           listaSocios.Items.Add(s.codigo_socio);

        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            new TipoProyecto(tNombre.Text, tDescripcion.Text, new Usuario(tCoordinador.Text), new Usuario(tResponsable.Text), sociosdonantes);
        }






    }
}
