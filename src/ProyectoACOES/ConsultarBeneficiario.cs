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
        private Beneficiario beneficiario = null;

        public ConsultarBeneficiario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tCodigo.Text = "";
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
                beneficiario = new Beneficiario(Convert.ToInt32(tCodigo.Text));
                textBox1.Text = beneficiario.nombre_Beneficiario;
                textBox2.Text = beneficiario.apellidos_Beneficiario;
                textBox3.Text = beneficiario.estado_Beneficiario;
                textBox4.Text = beneficiario.sexo_Beneficiario;
                textBox5.Text = beneficiario.beca_Beneficiario;
                textBox6.Text = beneficiario.curso_Beneficiario;
                textBox7.Text = beneficiario.proyecto_Beneficiario;
                textBox8.Text = Convert.ToString(beneficiario.agente_Beneficiario.Codigo);
                textBox9.Text = beneficiario.comunidadAct_Beneficiario;
                textBox10.Text = beneficiario.comunidadProc_Beneficiario;
                textBox11.Text = beneficiario.observaciones_Beneficiario;
                dateTimePicker1.Value = beneficiario.fechaNacimiento_Beneficiario;
                dateTimePicker2.Value = beneficiario.fechaEntradaAcoes_Beneficiario;
                dateTimePicker3.Value = beneficiario.fechaEntradaProyecto_Beneficiario;
                dateTimePicker4.Value = beneficiario.fechaSalidaProyecto_Beneficiario;
                dateTimePicker5.Value = beneficiario.fechaAlta_Beneficiario;
                dateTimePicker6.Value = beneficiario.fechaSalidaAcoes_Beneficiario;
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
                            
            }
    }
}
