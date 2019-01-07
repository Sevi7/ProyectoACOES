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
using System.Data.SqlClient;

namespace ProyectoACOES
{
    public partial class GestionarApadrinamientos : Form
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private Usuario usuario;
        public GestionarApadrinamientos()
        {
            InitializeComponent();
        }
        public GestionarApadrinamientos(Usuario u)
        {
            usuario = u;
            InitializeComponent();
        }

        private void GestionarApadrinamientos_Load(object sender, EventArgs e)
        {
            actualizarTabla();
               
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bApadrinar_Click(object sender, EventArgs e)
        {
            try
            {
                new Apadrinamiento(new Socio(Int32.Parse(tSocio.Text)), new Ninio(Int32.Parse(tNiño.Text)), new Usuario(tAgente.Text), Int32.Parse(tDinero.Text));
                tSocio.Text = "";
                tNiño.Text = "";
                tDinero.Text = "";
                tAgente.Text = "";
                actualizarTabla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bDesapadrinar_Click(object sender, EventArgs e)
        {
            try
            {
            Apadrinamiento seleccionado = new Apadrinamiento(new Socio(Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString())), new Ninio(Int32.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString())), new Usuario(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()));
            seleccionado.eliminarApadrinamiento(usuario);
            tSocio.Text = "";
            tNiño.Text = "";
            tDinero.Text = "";
            tAgente.Text = "";
            actualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void actualizarTabla ()
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string consultaSelect = "SELECT concat(s.nombre , concat (' ',  s.apellidos)) \"Socio\", s.codigo \"Codigo\", concat(n.nombre , concat (' ',  n.apellidos)) \"Niño\", n.codigo \"Codigo\", a.nif \"Agente\", ap.dinero \"Dinero\" FROM Apadrinamiento ap, Socio s, Ninio n, Usuario a where ap.socio=s.codigo and ap.ninio=n.codigo and ap.agente=a.nif and ap.eliminado=0;";
            DataTable tablaN = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consultaSelect, bd.cadenaConexionSQLNCLI);
            adaptador.Fill(tablaN);
            dataGridView1.DataSource = tablaN;
        }

     }
}

