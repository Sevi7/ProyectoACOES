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
    public partial class ENVIOS : Form
    {
        private tEnvio selec = null;
        private string id_selec =null;
        private Usuario usuario;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public ENVIOS(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void ENVIOS_Load(object sender, EventArgs e)
        {
            try
            {
                BDLINQDataContext bd = new BDLINQDataContext();
                dgEnvios.DataSource = from en in bd.tEnvio join s in bd.tSocio on en.socio equals s.codigo join n in bd.tNinio on en.niño equals n.codigo select new { Remitente = en.remitente, NombreSocio = s.nombre + " " + s.apellidos, NombreNiño = n.nombre + " " + n.apellidos, Código = en.etiqueta, DireccionSocio = s.direccion + ", " + s.codigoPostal + ", " + s.provincia, DireccionNiño = n.proyecto + ", " + n.comunidadAct };
                cbRemitente.Items.Add("Socio");
                cbRemitente.Items.Add("Niño");

                SQLSERVERDB bd2 = new SQLSERVERDB(BD_SERVER, BD_NAME);

                foreach (Object[] tupla in bd2.Select("SELECT * from Socio"))
                {
                    tSocio.AutoCompleteCustomSource.Add(tupla[1].ToString() + ", " + tupla[2].ToString());
                }
                tSocio.AutoCompleteMode = AutoCompleteMode.Suggest;
                tSocio.AutoCompleteSource = AutoCompleteSource.CustomSource;

                foreach (Object[] tupla in bd2.Select("SELECT * from Ninio"))
                {
                    tNiño.AutoCompleteCustomSource.Add(tupla[1].ToString() + ", " + tupla[2].ToString());
                }
                tNiño.AutoCompleteMode = AutoCompleteMode.Suggest;
                tNiño.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void bInsertar_Click(object sender, EventArgs e)
        {
            try
            {  
            BDLINQDataContext bd = new BDLINQDataContext();
            selec = new tEnvio();
            selec.remitente = cbRemitente.SelectedItem.ToString();
            string snombre = tSocio.Text.Substring(0, tSocio.Text.IndexOf(','));
            string sapellidos = tSocio.Text.Substring(tSocio.Text.IndexOf(',') + 2);
            selec.socio = bd.tSocio.First(s=>s.nombre==snombre && s.apellidos==sapellidos).codigo;
            string nnombre = tNiño.Text.Substring(0, tNiño.Text.IndexOf(','));
            string napellidos = tNiño.Text.Substring(tNiño.Text.IndexOf(',') + 2);
            selec.niño = bd.tNinio.First(n => n.nombre == nnombre && n.apellidos == napellidos).codigo;
            new Apadrinamiento(new Socio(selec.socio), new Ninio(selec.niño),usuario);
            selec.etiqueta = tCodigo.Text;
            bd.tEnvio.InsertOnSubmit(selec);
            bd.SubmitChanges();
            dgEnvios.DataSource = from en in bd.tEnvio join s in bd.tSocio on en.socio equals s.codigo join n in bd.tNinio on en.niño equals n.codigo select new { Remitente = en.remitente, NombreSocio = s.nombre + " " + s.apellidos, NombreNiño = n.nombre + " " + n.apellidos, Código = en.etiqueta, DireccionSocio = s.direccion + ", " + s.codigoPostal + ", " + s.provincia, DireccionNiño = n.proyecto + ", " + n.comunidadAct };
            }
            catch (Exception ex)
            {
                  MessageBox.Show(ex.Message);
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try { 
            BDLINQDataContext bd = new BDLINQDataContext();
            tEnvio nuevo = new tEnvio();
            selec = (tEnvio)bd.tEnvio.First(en => en.etiqueta == id_selec);
            if (tCodigo.Text != id_selec)
            {
                nuevo.remitente = cbRemitente.SelectedItem.ToString();
                string snombre = tSocio.Text.Substring(0, tSocio.Text.IndexOf(','));
                string sapellidos = tSocio.Text.Substring(tSocio.Text.IndexOf(',') + 2);
                nuevo.socio = bd.tSocio.First(s => s.nombre == snombre && s.apellidos == sapellidos).codigo;
                string nnombre = tNiño.Text.Substring(0, tNiño.Text.IndexOf(','));
                string napellidos = tNiño.Text.Substring(tNiño.Text.IndexOf(',') + 2);
                nuevo.niño = bd.tNinio.First(n => n.nombre == nnombre && n.apellidos == napellidos).codigo;
                nuevo.etiqueta = tCodigo.Text;
                id_selec = nuevo.etiqueta;
                new Apadrinamiento(new Socio(selec.socio), new Ninio(selec.niño), usuario);
                bd.tEnvio.InsertOnSubmit(nuevo);
                bd.tEnvio.DeleteOnSubmit(selec);
                bd.SubmitChanges();
                selec = nuevo;
            }
            else
            {
                selec.remitente = cbRemitente.SelectedItem.ToString();
                string snombre = tSocio.Text.Substring(0, tSocio.Text.IndexOf(','));
                string sapellidos = tSocio.Text.Substring(tSocio.Text.IndexOf(',') + 2);
                selec.socio = bd.tSocio.First(s => s.nombre == snombre && s.apellidos == sapellidos).codigo;
                string nnombre = tNiño.Text.Substring(0, tNiño.Text.IndexOf(','));
                string napellidos = tNiño.Text.Substring(tNiño.Text.IndexOf(',') + 2);
                selec.niño = bd.tNinio.First(n => n.nombre == nnombre && n.apellidos == napellidos).codigo;
                new Apadrinamiento(new Socio(selec.socio), new Ninio(selec.niño), usuario);
                bd.SubmitChanges();
            }
            
            dgEnvios.DataSource = from en in bd.tEnvio join s in bd.tSocio on en.socio equals s.codigo join n in bd.tNinio on en.niño equals n.codigo select new { Remitente = en.remitente, NombreSocio = s.nombre + " " + s.apellidos, NombreNiño = n.nombre + " " + n.apellidos, Código = en.etiqueta, DireccionSocio = s.direccion + ", " + s.codigoPostal + ", " + s.provincia, DireccionNiño = n.proyecto + ", " + n.comunidadAct };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BDLINQDataContext bd = new BDLINQDataContext();
                selec = (tEnvio)bd.tEnvio.First(en => en.etiqueta == id_selec);
                bd.tEnvio.DeleteOnSubmit(selec);
                bd.SubmitChanges();
                dgEnvios.DataSource = from en in bd.tEnvio join s in bd.tSocio on en.socio equals s.codigo join n in bd.tNinio on en.niño equals n.codigo select new { Remitente = en.remitente, NombreSocio = s.nombre + " " + s.apellidos, NombreNiño = n.nombre + " " + n.apellidos, Código = en.etiqueta, DireccionSocio = s.direccion + ", " + s.codigoPostal + ", " + s.provincia, DireccionNiño = n.proyecto + ", " + n.comunidadAct };
                bLimpiar_Click(null,null);
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

        }
        private void dgEnvios_SelectionChanged(object sender, EventArgs e)
        {
            try { 
            if (dgEnvios.SelectedRows.Count > 0)
            {
                id_selec = dgEnvios.SelectedRows[0].Cells[3].Value.ToString();
                BDLINQDataContext bd = new BDLINQDataContext();
                selec = (tEnvio)bd.tEnvio.First(en => en.etiqueta == id_selec);
                cbRemitente.SelectedIndex = cbRemitente.FindStringExact(selec.remitente);
                tSocio.Text = bd.tSocio.First(s => s.codigo == selec.socio).nombre + ", " + bd.tSocio.First(s => s.codigo == selec.socio).apellidos;
                tNiño.Text = bd.tNinio.First(n => n.codigo == selec.niño).nombre + ", " + bd.tNinio.First(n => n.codigo == selec.niño).apellidos;
                tCodigo.Text = selec.etiqueta;


            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            cbRemitente.SelectedItem = null;
            tSocio.Text = "";
            tNiño.Text = "";
            tCodigo.Text = "";
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InicioAgente socios = new InicioAgente(usuario);
            socios.ShowDialog();
        }


    }
}
