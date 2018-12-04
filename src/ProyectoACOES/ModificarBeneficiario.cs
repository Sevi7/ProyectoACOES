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
    public partial class ModificarBeneficiario : Form
    {
        private Beneficiario beneficiario = null;
        public ModificarBeneficiario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != beneficiario.nombre_Beneficiario)
                {
                    beneficiario.nombre_Beneficiario = textBox1.Text;
                }
                if (textBox2.Text != beneficiario.apellidos_Beneficiario)
                {
                    beneficiario.apellidos_Beneficiario = textBox2.Text;
                }
                if (textBox3.Text != beneficiario.estado_Beneficiario)
                {
                    beneficiario.estado_Beneficiario = textBox3.Text;
                }
                if (textBox4.Text != beneficiario.sexo_Beneficiario)
                {
                    beneficiario.sexo_Beneficiario = textBox4.Text;
                }
                if (textBox5.Text != beneficiario.beca_Beneficiario)
                {
                    beneficiario.beca_Beneficiario = textBox5.Text;
                }
                if (textBox6.Text != beneficiario.curso_Beneficiario)
                {
                    beneficiario.curso_Beneficiario = textBox6.Text;
                }
                if (textBox7.Text != beneficiario.proyecto_Beneficiario)
                {
                    beneficiario.proyecto_Beneficiario = textBox7.Text;
                }
                if (textBox8.Text != "")
                {
                    if (textBox8.Text != Convert.ToString(beneficiario.agente_Beneficiario.Codigo))
                    {
                        beneficiario.agente_Beneficiario = new Agente(Convert.ToInt32(textBox8.Text));
                    }
                }
                if (textBox9.Text != beneficiario.comunidadAct_Beneficiario)
                {
                    beneficiario.comunidadAct_Beneficiario = textBox9.Text;
                }
                if (textBox10.Text != beneficiario.comunidadProc_Beneficiario)
                {
                    beneficiario.comunidadProc_Beneficiario = textBox10.Text;
                }
                if (textBox11.Text != beneficiario.observaciones_Beneficiario)
                {
                    beneficiario.observaciones_Beneficiario = textBox11.Text;
                }
                if (dateTimePicker1.Value != beneficiario.fechaNacimiento_Beneficiario)
                {
                    beneficiario.fechaNacimiento_Beneficiario = dateTimePicker1.Value;
                }
                if (dateTimePicker2.Value != beneficiario.fechaEntradaAcoes_Beneficiario)
                {
                    beneficiario.fechaEntradaAcoes_Beneficiario = dateTimePicker2.Value;
                }
                if (dateTimePicker3.Value != beneficiario.fechaEntradaProyecto_Beneficiario)
                {
                    beneficiario.fechaEntradaProyecto_Beneficiario = dateTimePicker3.Value;
                }
                if (dateTimePicker4.Value != beneficiario.fechaSalidaProyecto_Beneficiario)
                {
                    beneficiario.fechaSalidaProyecto_Beneficiario = dateTimePicker4.Value;
                }
                if (dateTimePicker5.Value != beneficiario.fechaAlta_Beneficiario)
                {
                    beneficiario.fechaAlta_Beneficiario = dateTimePicker5.Value;
                }
                if (dateTimePicker6.Value != beneficiario.fechaSalidaAcoes_Beneficiario)
                {
                    beneficiario.fechaSalidaAcoes_Beneficiario = dateTimePicker6.Value;
                }
                refrescarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void refrescarDatos()
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

        private void bBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                beneficiario = new Beneficiario(Int32.Parse(tCodigo.Text));
                textBox1.Text = beneficiario.nombre_Beneficiario;
                textBox2.Text = beneficiario.apellidos_Beneficiario;
                textBox3.Text = beneficiario.estado_Beneficiario;
                textBox4.Text = beneficiario.sexo_Beneficiario;
                textBox5.Text = beneficiario.beca_Beneficiario;
                textBox6.Text = beneficiario.curso_Beneficiario;
                textBox7.Text = beneficiario.proyecto_Beneficiario;
                if (textBox8.Text != "") textBox8.Text = Convert.ToString(beneficiario.agente_Beneficiario.Codigo);
                textBox9.Text = beneficiario.comunidadAct_Beneficiario;
                textBox10.Text = beneficiario.comunidadProc_Beneficiario;
                textBox11.Text = beneficiario.observaciones_Beneficiario;
                dateTimePicker1.Value = beneficiario.fechaNacimiento_Beneficiario;
                dateTimePicker2.Value = beneficiario.fechaEntradaAcoes_Beneficiario;
                dateTimePicker3.Value = beneficiario.fechaEntradaProyecto_Beneficiario;
                dateTimePicker4.Value = beneficiario.fechaSalidaProyecto_Beneficiario;
                dateTimePicker5.Value = beneficiario.fechaAlta_Beneficiario;
                dateTimePicker6.Value = beneficiario.fechaSalidaAcoes_Beneficiario;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
