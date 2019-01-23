using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProyectoACOES
{
    public partial class Validacion : Form
    {
        DataTable dt;
        SqlDataAdapter da;
        private Cuenta seleccionado = null;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        public Validacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aCOESDataSet.Cuenta' Puede moverla o quitarla según sea necesario.
            dt = new DataTable();
            dataGridView1.DataSource = null;
            SqlConnection sql = new SqlConnection("Data Source=" + BD_SERVER + ";" + " Initial Catalog =" + BD_NAME + "; Integrated Security = True");
            da = new SqlDataAdapter("Select * from Cuenta  where  validado = 0;", sql);
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void bComunidades_Click(object sender, EventArgs e)
        {
            var id = this.dataGridView1.CurrentRow.Cells[0].Value;
            int i = Convert.ToInt32(id);
            seleccionado = new Cuenta(i);
            seleccionado.Validacion = 1;
            seleccionado = null;
            dt = new DataTable();
            dataGridView1.DataSource = null;
            SqlConnection sql = new SqlConnection("Data Source=" + BD_SERVER + ";" + " Initial Catalog =" + BD_NAME + "; Integrated Security = True");
            da = new SqlDataAdapter("Select * from Cuenta  where validado = 0;", sql);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Inicio I = new Inicio();
            I.ShowDialog();
        }
    }
}
