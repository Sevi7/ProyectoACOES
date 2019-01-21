using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDLibrary;

namespace ProyectoACOES
{
    public partial class GestionComunidades : Form
    {
        private Comunidad seleccionado;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public GestionComunidades()
        {
            InitializeComponent();
        }

        private void Comunidades_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        public void cargarGrid(string buscador){
            dataGridView1.Rows.Clear();
            foreach (Comunidad c in Comunidad.ListaComunidades(buscador))
            {
                dataGridView1.Rows.Add(c.NOMBRE, c.DESCRIPCION);
            }
        }

        public void cargarGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Comunidad c in Comunidad.ListaComunidades())
            {
                dataGridView1.Rows.Add(c.NOMBRE, c.DESCRIPCION);
            }
        }

        private void buscadorChanged(object sender, EventArgs e)
        {
            cargarGrid(tBuscador.Text);
        }

        private void dataGridSelected(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string name = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Comunidad(name);
                refrescarDatos();
            }
        }

        public void refrescarDatos()
        {
            if (seleccionado == null)
            {
                tNombre.Text = "";
                tDescripcion.Text = "";
            }
            else
            {
                tNombre.Text = seleccionado.NOMBRE;
                tDescripcion.Text = seleccionado.DESCRIPCION;
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado == null)
                {
                    seleccionado = new Comunidad(tNombre.Text, tDescripcion.Text);
                    cargarGrid();
                    refrescarDatos();
                }
                else
                {
                    MessageBox.Show("No puedes tener una Comunidad seleccionada al insertar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar Comunidad: " + ex.Message);
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null)
                {
                    if (tDescripcion.Text != seleccionado.DESCRIPCION) seleccionado.DESCRIPCION = tDescripcion.Text;
                    if (tNombre.Text != seleccionado.NOMBRE) seleccionado.NOMBRE = tNombre.Text;
                    cargarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar Comunidad: " + ex.Message);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null)
                {
                    seleccionado.borrar();
                    seleccionado = null;
                    cargarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar Comunidad: " + ex.Message);
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            seleccionado = null;
            cargarGrid();
        }

        

       
    }
}
