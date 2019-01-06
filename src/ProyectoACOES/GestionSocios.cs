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
        public GestionSocios()
        {
            InitializeComponent();
        }

        private void GestionSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aCOESDataSet.Socio' Puede moverla o quitarla según sea necesario.
            this.socioTableAdapter.Fill(this.aCOESDataSet.Socio);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int codigo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Socio(codigo);
                refrescaDatos();
            }
        }

        private void refrescaDatos()
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
            }
            else
            {
                tNombre.Text = seleccionado.Nombre;
                tApellido.Text = seleccionado.Apellidos;
                tEstado.Text = seleccionado.Estado;
                tNIF.Text = seleccionado.Nif;
                tDireccion.Text = seleccionado.Direccion;
                tPoblacion.Text = seleccionado.Poblacion;
                tCodigoPostal.Text = Convert.ToString(seleccionado.CodigoPostal);
                tProvincia.Text = seleccionado.Provincia;
                tTelefonoFijo.Text = Convert.ToString(seleccionado.Tlf);
                tTelefonoMovil.Text = Convert.ToString(seleccionado.TlfSecundario);
                tCorreoElectronico.Text = Convert.ToString(seleccionado.Email);
                tAgente.Text = seleccionado.Agente.Nombre +" "+ seleccionado.Agente.Apellidos;
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
            String nombreA, apellidosA;
            String[] tokens = tAgente.Text.Split(' ');
            try
            {
                nombreA = tokens[0];
                apellidosA = tokens[1];
                seleccionado = new Socio(tNombre.Text, tApellido.Text, tEstado.Text, tNIF.Text, tDireccion.Text, tPoblacion.Text,
                    Convert.ToInt32(tCodigoPostal.Text), tProvincia.Text, Convert.ToInt32(tTelefonoFijo.Text), Convert.ToInt32(tTelefonoMovil.Text),
                    tCorreoElectronico.Text, new Agente(nombreA, apellidosA), tRelacion.Text, tCertificado.Checked, tSector.Text, tFechaAlta.Value,
                    tFechaBaja.Value, tObservaciones.Text, tNumeroCuenta.Text);

            }catch(Exception ex)
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
                if (null != tCodigoPostal.Text) seleccionado.CodigoPostal = Convert.ToInt32(tCodigoPostal.Text);
                seleccionado.Provincia = tProvincia.Text;
                if (null != tTelefonoFijo.Text) seleccionado.Tlf = Convert.ToInt32(tTelefonoFijo.Text);
                if (null != tTelefonoMovil.Text) seleccionado.TlfSecundario = Convert.ToInt32(tTelefonoMovil.Text);
                seleccionado.Email = tCorreoElectronico.Text;
                if (null != tAgente.Text)
                {
                    String[] a = tAgente.Text.Split(' ');
                    seleccionado.Agente = new Agente(a[0], a[1]);
                }
                seleccionado.Relacion = tRelacion.Text;
                seleccionado.Certificado = tCertificado.Checked;
                seleccionado.Sector = tSector.Text;
                seleccionado.FechaAlta = tFechaAlta.Value;
                seleccionado.FechaBaja = tFechaBaja.Value;
                seleccionado.Observaciones = tSector.Text;
                seleccionado.NumCuenta = tNumeroCuenta.Text;

                this.socioTableAdapter.Fill(this.aCOESDataSet.Socio);
                refrescaDatos();
            }
            catch(Exception ex)
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
                refrescaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.socioTableAdapter.FillBy(this.aCOESDataSet.Socio);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            seleccionado = null;
            refrescaDatos();
        }
    }
}
