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
    public partial class EliminarBeneficiario : Form
    {
        public EliminarBeneficiario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                new Beneficiario(Convert.ToInt32(textBox1.Text)).BorrarPaciente();
                refrescarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void refrescarDatos()
        {
            textBox1.Text = "";
        }

        private void EliminarBeneficiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aCOESDataSet.Beneficiario' Puede moverla o quitarla según sea necesario.
            this.beneficiarioTableAdapter.Fill(this.aCOESDataSet.Beneficiario);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int cod = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Beneficiario seleccionado = new Beneficiario(cod);
                    seleccionado.BorrarPaciente();
                    refrescarDatos();
                    this.beneficiarioTableAdapter.Fill(this.aCOESDataSet.Beneficiario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
