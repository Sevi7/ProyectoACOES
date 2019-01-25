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
    public partial class CrearNuevoProyecto : Form
    {
        private List<Socio> socios = new List<Socio>();
        private List<Ninio> ninios = new List<Ninio>();
        private Usuario usuario;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;


        public CrearNuevoProyecto(Usuario u)
        {
            InitializeComponent();
            usuario = u;
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

        private void bAñadirNiño_Click(object sender, EventArgs e)
        {
            try
            {
                Ninio b = new Ninio(Int32.Parse(tNiño.Text));
                ninios.Add(b);
                tNiño.Text = "";
                listaNiños.Items.Add(b.Codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bCrearProyecto_Click(object sender, EventArgs e)
        {
            try{
                new Proyecto(tNombre.Text, new TipoProyecto(tTipoProyecto.Text), new Usuario(tCoordinador.Text), new Usuario(tResponsable.Text), tLocalidad.Text, this.socios, ninios);
                this.Visible = false;
                Inicio form1 = new Inicio();
                form1.ShowDialog();
            }
           catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inicio form1 = new Inicio();
            form1.ShowDialog();
        }

        private void CrearNuevoProyecto_Load(object sender, EventArgs e)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (Object[] tupla in bd.Select("SELECT * from Socio"))
            {
                tSocio.AutoCompleteCustomSource.Add(tupla[0].ToString());
            }
            tSocio.AutoCompleteMode = AutoCompleteMode.Suggest;
            tSocio.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (Object[] tupla in bd.Select("SELECT * from Ninio"))
            {
                tNiño.AutoCompleteCustomSource.Add(tupla[0].ToString());
            }
            tNiño.AutoCompleteMode = AutoCompleteMode.Suggest;
            tNiño.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (Object[] tupla in bd.Select("SELECT * from Usuario where rol='"+"R001"+"';"))
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
            
            foreach (Object[] tupla in bd.Select("SELECT * from TipoProyecto"))
            {
                tTipoProyecto.AutoCompleteCustomSource.Add(tupla[0].ToString());
            }
            tTipoProyecto.AutoCompleteMode = AutoCompleteMode.Suggest;
            tTipoProyecto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
