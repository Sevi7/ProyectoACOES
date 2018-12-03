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
    public partial class ConsultarBeneficiario : Form
    {
        public ConsultarBeneficiario()
        {
            InitializeComponent();
        }

        private void ConsultarBeneficiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aCOESDataSet.Beneficiario' Puede moverla o quitarla según sea necesario.
            this.beneficiarioTableAdapter.Fill(this.aCOESDataSet.Beneficiario);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = (DataSet)dataGridView1.DataSource;
            DataTable dt = ds.Tables[dataGridView1.DataMember];

            DataRow[] resultSet = dt.Select("select * from beneficiario where codigo=" + textBox1.Text + ";");
        }
    }
}
