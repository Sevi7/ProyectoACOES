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
            try
            {
                Socio s = new Socio(tSocio.Text);
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
            //try
            {
                Beneficiario b = new Beneficiario(Int32.Parse(tBeneficiario.Text));
                beneficiarios.Add(b);
                tBeneficiario.Text = "";
                listaBeneficiarios.Items.Add(b.codigo_Beneficiario);
                //listaBeneficiarios.Items.Add(b_codigo_beneficiario);
            }
            //catch (Exception ex)
            {
               // MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bCrearProyecto_Click(object sender, EventArgs e)
        {
            try{
                new Proyecto(tNombre.Text, new TipoProyecto(tTipoProyecto.Text), new Usuario(tCoordinador.Text), new Usuario(tResponsable.Text), tLocalidad.Text, socios, beneficiarios);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }



    }
}
