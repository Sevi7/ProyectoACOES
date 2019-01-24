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
    public partial class GestionEconomica : Form
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private Usuario us;
        DataTable dt;
        SqlDataAdapter da;
        private Cuenta seleccionado = null;


        public GestionEconomica(Usuario user1)
        {
            us = user1;
            InitializeComponent();
            inicializar();
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            consultar2();
        }
        private void inicializar()
        {
            SqlConnection sql = new SqlConnection("Data Source=" + BD_SERVER + ";" + " Initial Catalog =" + BD_NAME + "; Integrated Security = True");
            SqlCommand cm = new SqlCommand("Select nombre, apellidos from Beneficiario;", sql);
            sql.Open();
            SqlDataReader rd = cm.ExecuteReader();

            while (rd.Read() == true)
            {
                string p = (string)rd[0] +" "+ rd[1];
                ben.Items.Add(p);
            }
            sql.Close();

            cat.Items.Add("Educación");
            cat.Items.Add("Nutrición");
            cat.Items.Add("Admón");
            cat.Items.Add("Suministros");
            cat.Items.Add("Ayuda por Col");
            cat.Items.Add("Transporte");
            cat.Items.Add("Higiene y Salud");
            cat.Items.Add("Mantenimiento del edificio");
            cat.Items.Add("Alquileres");
            cat.Items.Add("Material de oficina");
            cat.Items.Add("Impuestos y Contribuciones");
            cat.Items.Add("Servicios Contratados");
            cat.Items.Add("Varios");

            tipo.Items.Add("Ingreso");
            tipo.Items.Add("Gasto");
            tipo.Items.Add("Ambos");




        }

        private void añadir_Click(object sender, EventArgs e)
        {

            try
            {

                string tp = comboBox1.SelectedItem.ToString();
                string p = comboBox2.SelectedItem.ToString();
                string a1 = tipo.SelectedItem.ToString();
                string a2 = ben.SelectedItem.ToString();
                string a3 = cat.SelectedItem.ToString();
                double a4 = Convert.ToDouble(cant.Text);
                DateTime a5 = Convert.ToDateTime(date.Text); ;
                string a6 = des.Text;

                Cuenta c = new Cuenta(a1, a2, a3, a4, a5, a6);


                if (p == "Tipo Proyecto")
                {

                    CuentaTipoProyecto ctp = new CuentaTipoProyecto(c.Id, tp);
                }
                else
                {
                    SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    Object[] ob = bd.Select("Select id from Proyecto where nombre = '" + p + "' and tipo_proyecto= '" + tp + "';")[0];
                    int id = Convert.ToInt32(ob[0]);
                    CuentaProyecto cp = new CuentaProyecto(id, c.Id);
                }
                consultar2();
                refrescarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                refrescarDatos();
            }


        }

        public void refrescarDatos()
        {

            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            tipo.Text = "";
            cat.Text = "";
            cant.Text = "";
            des.Text = "";
            ben.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            refrescarDatos();
            dataGridView1.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            var id = this.dataGridView1.CurrentRow.Cells[0].Value;
            int i = Convert.ToInt32(id);
            seleccionado = new Cuenta(i);
            seleccionado.borrarCuenta();
            seleccionado = null;
            consultar2();





        }

        public void consultar2()
        {
            try
            {
                dt = new DataTable();
                dataGridView1.DataSource = null;
                SqlConnection sql = new SqlConnection("Data Source=" + BD_SERVER + ";" + " Initial Catalog =" + BD_NAME + "; Integrated Security = True");
                string tproyecto = comboBox1.SelectedItem.ToString();
                string proyecto = comboBox2.SelectedItem.ToString();
                string t = tipo.SelectedItem.ToString();
                if (proyecto == "Tipo Proyecto") //Para los tipos proyecto
                {
                    if (t == "Ambos")
                    {
                        da = new SqlDataAdapter("Select c.* from Cuenta c,(Select cuenta from CuentaTipoProyecto where tipoProyecto = '" + tproyecto + "') t where t.cuenta = c.id and validado = 1;", sql);

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        da = new SqlDataAdapter("Select c.* from Cuenta c,(Select cuenta from CuentaTipoProyecto where tipoProyecto = '" + tproyecto + "') t where t.cuenta = c.id and c.tipo= '" + t + "'and validado = 1;", sql);

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }

                }
                else //Proyecto
                {
                    SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    Object[] ob = bd.Select("Select id from Proyecto where nombre = '" + proyecto + "' and tipo_proyecto= '" + tproyecto + "';")[0];
                    int id = Convert.ToInt32(ob[0]);

                    if (t == "Ambos")
                    {

                        da = new SqlDataAdapter("Select c.* from Cuenta c,(Select cuenta from CuentaProyecto where id = " + id + ") t where t.cuenta = c.id and validado = 1;", sql);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        da = new SqlDataAdapter("Select c.* from Cuenta c,(Select cuenta from CuentaProyecto where id = '" + id + "') t where t.cuenta = c.id and c.tipo= '" + t + "'and validado = 1;", sql);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }


                }





            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                refrescarDatos();
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=" + BD_SERVER + ";" + " Initial Catalog =" + BD_NAME + "; Integrated Security = True");
            SqlCommand cm = new SqlCommand("Select nombre from TipoProyecto;", sql);
            sql.Open();
            SqlDataReader rd = cm.ExecuteReader();

            while (rd.Read() == true)
            {
                comboBox1.Items.Add(rd[0]);
            }
            sql.Close();
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            string tipo = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedItem != null)
            {
                SqlConnection sql = new SqlConnection("Data Source=" + BD_SERVER + ";" + " Initial Catalog =" + BD_NAME + "; Integrated Security = True");
                SqlCommand cm = new SqlCommand("Select nombre from Proyecto where tipo_proyecto = '" + tipo + "';", sql);
                sql.Open();
                SqlDataReader rd = cm.ExecuteReader();

                while (rd.Read() == true)
                {
                    comboBox2.Items.Add(rd[0]);
                }
                comboBox2.Items.Add("Tipo Proyecto");
                sql.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            InicioResponsable i = new InicioResponsable(us);
            i.ShowDialog();
        }


    }
}

