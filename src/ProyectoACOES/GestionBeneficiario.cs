using BDLibrary;
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
    public partial class GestionBeneficiario : Form
    {
        private Beneficiario seleccionado;
        private Usuario usuario;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public GestionBeneficiario(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void GestionBeneficiario_Load(object sender, EventArgs e)
        {
            this.beneficiarioTableAdapter.Fill(this.aCOESDataSet.Beneficiario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado = new Beneficiario(tNIF.Text, tNombre.Text, tApellidos.Text, tObservaciones.Text, usuario, tNumeroCuenta.Text);
                this.beneficiarioTableAdapter.Fill(this.aCOESDataSet.Beneficiario);
                RefrescaDatos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado.BorrarBeneficiario();
                seleccionado = null;
                this.beneficiarioTableAdapter.Fill(this.aCOESDataSet.Beneficiario);
                RefrescaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nif = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Beneficiario(nif);
                RefrescaDatos();
            }
        }

        public void RefrescaDatos()
        {
            if (seleccionado != null)
            {
                tNIF.Text = seleccionado.NIF;
                tNombre.Text = seleccionado.Nombre;
                tApellidos.Text = seleccionado.Apellidos;
                tNumeroCuenta.Text = seleccionado.NumCuenta;
                tObservaciones.Text = seleccionado.Observaciones;
            }
            else
            {
                tNIF.Text = "";
                tNombre.Text = "";
                tApellidos.Text = "";
                tNumeroCuenta.Text = "";
                tObservaciones.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InicioResponsable form1 = new InicioResponsable(usuario);
            form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seleccionado = null;
            RefrescaDatos();
            this.beneficiarioTableAdapter.Fill(this.aCOESDataSet.Beneficiario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado.NIF = tNIF.Text;
                seleccionado.Nombre = tNombre.Text;
                seleccionado.Apellidos = tApellidos.Text;
                seleccionado.NumCuenta = tNumeroCuenta.Text;
                seleccionado.Resposable = usuario;
                seleccionado.Observaciones = tObservaciones.Text;
                this.beneficiarioTableAdapter.Fill(this.aCOESDataSet.Beneficiario);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
