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
            try
            {          
            if(textBox4.Text == "CG001" || textBox4.Text == "R001" || textBox4.Text == "C001" || textBox4.Text == "A001")
            {
                Usuario user = new Usuario(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text);
                refresh();
                irLogin();
            }else
            {
                MessageBox.Show("Código incorrecto, no puede registrarse como usuario del sistema");
            }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void irLogin()
        {
            this.Visible=false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login log = new Login();
            log.ShowDialog();
        }
    }
}
