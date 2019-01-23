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
    public partial class GestionSocios : Form
    {
        private Socio seleccionado = null;
        private Usuario usuario;

        public GestionSocios()
        {
            InitializeComponent();
        }
        public GestionSocios(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void GestionSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aCOESDataSet.Socio' Puede moverla o quitarla según sea necesario.
            this.socioTableAdapter.Fill(this.aCOESDataSet.Socio);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int codigo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Socio(codigo);
                RefrescaDatos();
            }
        }

        private void RefrescaDatos()
        {
            if (seleccionado == null)
            {
                tNombre.Text = "";
                tApellido.Text = "";
                tEstado.Text = "";
                tNIF.Text = "";
                tDireccion.Text = "";
                tPoblacion.Text = "";
                tCodigoPostal.Text = "";
                tProvincia.Text = "";
                tTelefonoFijo.Text = "";
                tTelefonoMovil.Text = "";
                tCorreoElectronico.Text = "";
                tAgente.Text = "";
                tRelacion.Text = "";
                tSector.Text = "";
                tObservaciones.Text = "";
                tNumeroCuenta.Text = "";
                tCertificado.Checked = false;
            }
            else
            {
                int cp = 0, tlf2 = 0;
                if (tCodigoPostal.Text != "") cp = Convert.ToInt32(tCodigoPostal.Text);
                if (tTelefonoMovil.Text != "") tlf2 = Convert.ToInt32(tTelefonoMovil.Text);
                tNombre.Text = seleccionado.Nombre;
                tApellido.Text = seleccionado.Apellidos;
                tEstado.Text = seleccionado.Estado;
                tNIF.Text = seleccionado.Nif;
                tDireccion.Text = seleccionado.Direccion;
                tPoblacion.Text = seleccionado.Poblacion;
                if (seleccionado.CodigoPostal != 0) tCodigoPostal.Text = Convert.ToString(seleccionado.CodigoPostal);
                else tCodigoPostal.Text = "";
                tProvincia.Text = seleccionado.Provincia;
                tTelefonoFijo.Text = Convert.ToString(seleccionado.Tlf);
                if (seleccionado.TlfSecundario != 0) tTelefonoMovil.Text = Convert.ToString(seleccionado.TlfSecundario);
                else tTelefonoMovil.Text = "";
                tCorreoElectronico.Text = Convert.ToString(seleccionado.Email);
                tAgente.Text = seleccionado.Agente.nif_usuario;
                tRelacion.Text = seleccionado.Relacion;
                tSector.Text = seleccionado.Sector;
                tFechaAlta.Value = seleccionado.FechaAlta;
                tFechaBaja.Value = seleccionado.FechaBaja;
                tObservaciones.Text = seleccionado.Observaciones;
                tCertificado.Checked = seleccionado.Certificado;
                tNumeroCuenta.Text = seleccionado.NumCuenta;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int cp = 0, tlf2 = 0;
                if (tCodigoPostal.Text != "") cp = Convert.ToInt32(tCodigoPostal.Text);
                if (tTelefonoMovil.Text != "") tlf2 = Convert.ToInt32(tTelefonoMovil.Text);
                if (tTelefonoFijo.Text == "") MessageBox.Show("Es obligatorio introducir un telefono fijo.");
                if (tNIF.Text == "") MessageBox.Show("Es obligatorio introducir un NIF");
                seleccionado = new Socio(tNombre.Text, tApellido.Text, tEstado.Text, tNIF.Text, tDireccion.Text, tPoblacion.Text,
                    cp, tProvincia.Text, Convert.ToInt32(tTelefonoFijo.Text), tlf2,
                    tCorreoElectronico.Text, usuario, tRelacion.Text, tCertificado.Checked, tSector.Text, tFechaAlta.Value,
                    tFechaBaja.Value, tObservaciones.Text, tNumeroCuenta.Text);

                this.socioTableAdapter.Fill(this.aCOESDataSet.Socio);
                RefrescaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado.Nombre = tNombre.Text;
                seleccionado.Apellidos = tApellido.Text;
                seleccionado.Estado = tEstado.Text;
                seleccionado.Nif = tNIF.Text;
                seleccionado.Direccion = tDireccion.Text;
                seleccionado.Poblacion = tPoblacion.Text;
                if ("" != tCodigoPostal.Text) seleccionado.CodigoPostal = Convert.ToInt32(tCodigoPostal.Text);
                seleccionado.Provincia = tProvincia.Text;
                if ("" != tTelefonoFijo.Text) seleccionado.Tlf = Convert.ToInt32(tTelefonoFijo.Text);
                if ("" != tTelefonoMovil.Text) seleccionado.TlfSecundario = Convert.ToInt32(tTelefonoMovil.Text);
                seleccionado.Email = tCorreoElectronico.Text;
                seleccionado.Agente = usuario;
                seleccionado.Relacion = tRelacion.Text;
                seleccionado.Certificado = tCertificado.Checked;
                seleccionado.Sector = tSector.Text;
                seleccionado.FechaAlta = tFechaAlta.Value;
                seleccionado.FechaBaja = tFechaBaja.Value;
                seleccionado.Observaciones = tSector.Text;
                seleccionado.NumCuenta = tNumeroCuenta.Text;

                this.socioTableAdapter.Fill(this.aCOESDataSet.Socio);
                RefrescaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado.BorrarSocio();
                seleccionado = null;
                this.socioTableAdapter.Fill(this.aCOESDataSet.Socio);
                RefrescaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            seleccionado = null;
            RefrescaDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Socios socios = new Socios(usuario);
            socios.ShowDialog();
        }
    }
}
