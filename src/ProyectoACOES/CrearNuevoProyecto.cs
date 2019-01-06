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
        private List<Ninio> ninios = new List<Ninio>();


        public CrearNuevoProyecto()
        {
            InitializeComponent();
        }

        private void bAñadirSocio_Click(object sender, EventArgs e)
        {
            try
            {
                Socio s = new Socio(Convert.ToInt32(tSocio.Text));
                socios.Add(s);
                tSocio.Text = "";
                listaSocios.Items.Add(s.codigo_socio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void bAñadirBeneficiario_Click(object sender, EventArgs e)
        {
            try
            {
                Ninio b = new Ninio(Int32.Parse(tBeneficiario.Text));
                ninios.Add(b);
                tBeneficiario.Text = "";
                listaBeneficiarios.Items.Add(b.Codigo);
                //listaBeneficiarios.Items.Add(b_codigo_beneficiario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bCrearProyecto_Click(object sender, EventArgs e)
        {
            try{
                new Proyecto(tNombre.Text, new TipoProyecto(tTipoProyecto.Text), new Usuario(tCoordinador.Text), new Usuario(tResponsable.Text), tLocalidad.Text, socios, ninios);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }



    }
}
