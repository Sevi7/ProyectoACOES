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
    public partial class InsertarBeneficiario : Form
    {
        public InsertarBeneficiario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != ""){ new Beneficiario(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text, new Agente(Convert.ToInt32(textBox8.Text)),
               dateTimePicker1.Value, dateTimePicker2.Value, textBox7.Text, dateTimePicker4.Value, dateTimePicker3.Value, dateTimePicker6.Value, dateTimePicker5.Value,
                textBox6.Text, textBox9.Text, textBox10.Text, textBox11.Text);
            }
            else
            {
                new Beneficiario(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text, null,
                dateTimePicker1.Value, dateTimePicker2.Value, textBox7.Text, dateTimePicker4.Value, dateTimePicker3.Value, dateTimePicker6.Value, dateTimePicker5.Value,
                textBox6.Text, textBox9.Text, textBox10.Text, textBox11.Text);
            }

            refrescarDatos();
        }
        private void refrescarDatos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";

        }

    }
}
