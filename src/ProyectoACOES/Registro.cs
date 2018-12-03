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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox5.Text == "CG001" || textBox5.Text == "R001" || textBox5.Text == "C001" || textBox5.Text == "A001")
            {
                Usuario user = new Usuario(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text);
                refresh();
                irLogin();
            }
        }

        private void irLogin()
        {
            this.Close();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void refresh()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
