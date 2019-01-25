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
    public partial class CrearNuevoTipoProyecto : Form
    {
        private List<Socio> sociosdonantes= new List<Socio>();
        private Usuario usuario;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        
        public CrearNuevoTipoProyecto(Usuario u)
        {
            usuario = u;
            InitializeComponent();
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                Socio s = new Socio(Convert.ToInt32(tSocio.Text));
                tSocio.Text = "";
                sociosdonantes.Add(s);
                listaSocios.Items.Add(s.codigo_socio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            try
            {
                new TipoProyecto(tNombre.Text, tDescripcion.Text, new Usuario(tCoordinador.Text), new Usuario(tResponsable.Text), sociosdonantes);
                this.Visible = false;
                Inicio form1 = new Inicio();
                form1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }

        private void CrearNuevoTipoProyecto_Load(object sender, EventArgs e)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (Object[] tupla in bd.Select("SELECT * from Socio"))
            {
                tSocio.AutoCompleteCustomSource.Add(tupla[0].ToString());
            }
            tSocio.AutoCompleteMode = AutoCompleteMode.Suggest;
            tSocio.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (Object[] tupla in bd.Select("SELECT * from Usuario where rol='" + "R001" + "';"))
            {
                tResponsable.AutoCompleteCustomSource.Add(tupla[0].ToString());
            }
            tResponsable.AutoCompleteMode = AutoCompleteMode.Suggest;
            tResponsable.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (Object[] tupla in bd.Select("SELECT * from Usuario where rol='" + "CG001" + "';"))
            {
                tCoordinador.AutoCompleteCustomSource.Add(tupla[0].ToString());
            }
            tCoordinador.AutoCompleteMode = AutoCompleteMode.Suggest;
            tCoordinador.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inicio i = new Inicio();
            i.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
