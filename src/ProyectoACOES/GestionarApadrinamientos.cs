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
            try
            {
                actualizarTabla();
                SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
                if (usuario.rol_usuario.Equals("A001"))
                {
                    tAgente.Visible = false;
                    label3.Visible = false;
                }
                else
                {
                    foreach (Object[] tupla in bd.Select("SELECT * from Usuario where rol='A001';"))
                    {
                        tAgente.AutoCompleteCustomSource.Add(tupla[0].ToString());
                    }
                    tAgente.AutoCompleteMode = AutoCompleteMode.Suggest;
                    tAgente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                
                foreach(Object[] tupla in bd.Select("SELECT * from Socio"))
                {
                    tSocio.AutoCompleteCustomSource.Add(tupla[1].ToString()+" "+tupla[2].ToString());
                }
                tSocio.AutoCompleteMode = AutoCompleteMode.Suggest;
                tSocio.AutoCompleteSource = AutoCompleteSource.CustomSource;

                foreach (Object[] tupla in bd.Select("SELECT * from Ninio"))
                {
                    tNiño.AutoCompleteCustomSource.Add(tupla[1].ToString() + " " + tupla[2].ToString());
                }
                tNiño.AutoCompleteMode = AutoCompleteMode.Suggest;
                tNiño.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo autocompletar el TextBox "+ex.ToString());
            }
               
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bApadrinar_Click(object sender, EventArgs e)
        {
            try
            {
                SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string snombre=tSocio.Text.Substring(0,tSocio.Text.IndexOf(','));
                string sapellidos=tSocio.Text.Substring(tSocio.Text.IndexOf(',')+1);
                List<Object[]> consulta = bd.Select("SELECT * FROM SOCIO where nombre='" + snombre + "' and apellidos='" + sapellidos +"';");
                if (consulta.Count == 0){
                    throw new Error ("El socio no se encuentra en el sistema");
                }
                string nnombre = tNiño.Text.Substring(0, tNiño.Text.IndexOf(','));
                string napellidos = tNiño.Text.Substring(tNiño.Text.IndexOf(',') + 1);
                List<Object[]> consulta2 = bd.Select("SELECT * FROM Ninio where nombre='" + nnombre + "' and apellidos='" + napellidos + "';");
                if (consulta2.Count == 0)
                {
                    throw new Error("El niño no se encuentra en el sistema");
                }
                if (usuario.rol_usuario.Equals("A001")){
                    new Apadrinamiento(new Socio(Int32.Parse((string)consulta[0][0])), new Ninio(Int32.Parse((string)consulta2[0][0])), usuario, Int32.Parse(tDinero.Text));
                }else{
                    new Apadrinamiento(new Socio(Int32.Parse((string)consulta[0][0])), new Ninio(Int32.Parse((string)consulta2[0][0])), new Usuario(tAgente.Text), Int32.Parse(tDinero.Text));

                }
                
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
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    string snombre=tSocio.Text.Substring(0,tSocio.Text.IndexOf(','));
                    string sapellidos=tSocio.Text.Substring(tSocio.Text.IndexOf(',')+1);
                    List<Object[]> consulta = bd.Select("SELECT * FROM SOCIO where nombre='" + snombre + "' and apellidos='" + sapellidos +"';");
                    if (consulta.Count == 0){
                        throw new Error ("El socio no se encuentra en el sistema");
                    }
                    string nnombre = tNiño.Text.Substring(0, tNiño.Text.IndexOf(','));
                    string napellidos = tNiño.Text.Substring(tNiño.Text.IndexOf(',') + 1);
                    List<Object[]> consulta2 = bd.Select("SELECT * FROM Ninio where nombre='" + nnombre + "' and apellidos='" + napellidos + "';");
                    if (consulta2.Count == 0)
                    {
                        throw new Error("El niño no se encuentra en el sistema");
                    }
                    Apadrinamiento ap = new Apadrinamiento(new Socio(Int32.Parse((string)consulta[0][0])), new Ninio(Int32.Parse((string)consulta2[0][0])), usuario);
                    ap.eliminarApadrinamiento(usuario);
                    tSocio.Text = "";
                    tNiño.Text = "";
                    tDinero.Text = "";
                    tAgente.Text = "";
                    actualizarTabla();
                    
                }
                else
                {
                    Apadrinamiento seleccionado = new Apadrinamiento(new Socio(Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString())), new Ninio(Int32.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString())), usuario);
                    seleccionado.eliminarApadrinamiento(usuario);
                    tSocio.Text = "";
                    tNiño.Text = "";
                    tDinero.Text = "";
                    tAgente.Text = "";
                    actualizarTabla();
                }
            
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

