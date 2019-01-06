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
        public GestionarApadrinamientos()
        {
            InitializeComponent();
        }

        private void GestionarApadrinamientos_Load(object sender, EventArgs e)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string consultaSelect = "SELECT concat(s.nombre , concat (' ',  s.apellidos)) \"Socio\", concat(n.nombre , concat (' ',  n.apellidos)) \"Niño\", a.nif \"Agente\", ap.dinero \"Dinero\" FROM Apadrinamiento ap, Socio s, Ninio n, Usuario a where ap.socio=s.codigo and ap.ninio=n.codigo and ap.agente=a.nif and ap.eliminado=0;";
            DataTable tablaN = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consultaSelect, bd.cadenaConexionSQLNCLI);
            adaptador.Fill(tablaN);
            dataGridView1.DataSource = tablaN;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     }
}

