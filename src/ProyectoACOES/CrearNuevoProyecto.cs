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
    public partial class CrearNuevoProyecto : Form
    {
        private List<Socio> socios = new List<Socio>();
        private List<Beneficiario> beneficiarios = new List<Beneficiario>();


        public CrearNuevoProyecto()
        {
            InitializeComponent();
        }

        private void bAñadirSocio_Click(object sender, EventArgs e)
        {
            Socio s = new Socio(tSocio.Text);
            socios.Add(s);
            tSocio.Text = "";
            listaSocios.Items.Add(s.NIF);
        }

        private void bAñadirBeneficiario_Click(object sender, EventArgs e)
        {
            Beneficiario b = new Beneficiario(tBeneficiario.Text);
            beneficiarios.Add(b);
            tBeneficiario.Text = "";
            listaBeneficiarios.Items.Add(b.NIF);

        }

        private void bCrearProyecto_Click(object sender, EventArgs e)
        {
            new Proyecto(tNombre.Text, tTipoProyecto.Text, tCoordinador.Text, tResponsable.Text, tLocalidad.Text, socios, beneficiarios);

        }



    }
}
