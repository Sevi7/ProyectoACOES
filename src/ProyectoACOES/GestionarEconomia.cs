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
    public partial class GestionarEconomia : Form
    {
        
        private Cuenta seleccionado = null;
        public GestionarEconomia()
        {
            InitializeComponent();
        }
        
        private void añadir_Click(object sender, EventArgs e)
        {

            Cuenta c = new Cuenta(p1.Text, p2.Text, p3.Text, Convert.ToDouble(p4.Text), p5.Value, p8.Text);
            this.cuentaTableAdapter1.Fill(this.aCOESDataSet.Cuenta);
            refrescarDatos();
            e3.sele
            
        }

        public void refrescarDatos()
        {
            p1.Text = "";
            p2.Text = "";
            p3.Text = "";
            p4.Text = "";
            p5.Text = "";
            p8.Text = "";
            
        }

        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int codigo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Cuenta(codigo);
                refrescarDatos();
            }
        }

        private void GestionarEconomia_Load(object sender, EventArgs e)
        {
            this.cuentaTableAdapter1.Fill(this.aCOESDataSet.Cuenta);
        }
    }
}
