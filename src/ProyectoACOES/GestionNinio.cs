using BDLibrary;
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
    public partial class GestionNinio : Form
    {
        private Ninio seleccionado = null;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public GestionNinio()
        {
            InitializeComponent();
        }

        private void GestionNinio_Load(object sender, EventArgs e)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            // TODO: esta línea de código carga datos en la tabla 'aCOESDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.ninioTableAdapter.Fill(this.aCOESDataSet.Ninio);

            foreach (Object[] tupla in bd.Select("SELECT * from Usuario where rol='A001';"))
            {
                tAgente.AutoCompleteCustomSource.Add(tupla[0].ToString());
            }
            tAgente.AutoCompleteMode = AutoCompleteMode.Suggest;
            tAgente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int codigo = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                seleccionado = new Ninio(codigo);
                RefrescaDatos();
            }
        }

        private void RefrescaDatos()
        {
            if (seleccionado == null)
            {
                tNombre.Text = "";
                tApellido.Text = "";
                tEstado.Text = "";
                tBeca.Text = "";
                tProyecto.Text = "";
                tComunidadA.Text = "";
                tComunidadP.Text = "";
                tObservaciones.Text = "";
            }
            else
            {
                tNombre.Text = seleccionado.Nombre;
                tApellido.Text = seleccionado.Apellidos;
                tEstado.Text = seleccionado.Estado;
                tBeca.Text = seleccionado.Beca;
                tSexo.SelectedItem = seleccionado.Sexo;
                tProyecto.Text = seleccionado.Proyecto;
                tComunidadA.Text = seleccionado.ComunidadAct;
                tComunidadP.Text = seleccionado.ComunidadProc;
                tFechaEntradaACOES.Value = seleccionado.FechaEntradaAcoes;
                tFechaEntradaP.Value = seleccionado.FechaEntradaProyecto;
                tFechaNacimiento.Value = seleccionado.FechaNacimiento;
                tFechaSalidACOES.Value = seleccionado.FechaSalidaAcoes;
                tFechaSalidaP.Value = seleccionado.FechaSalidaProyecto;
                tFechaAlta.Value = seleccionado.FechaAlta;
                if(seleccionado.Agente!=null)tAgente.Text = seleccionado.Agente.nif_usuario;
                tObservaciones.Text = seleccionado.Observaciones;
                tCurso.Value = Convert.ToDecimal(seleccionado.Curso);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario a = null;
                if (tAgente.Text != "") a = new Usuario(tAgente.Text);
                seleccionado = new Ninio(tNombre.Text, tApellido.Text, tEstado.Text, tBeca.Text, Convert.ToString(tSexo.SelectedItem), a,
                    tFechaNacimiento.Value, tFechaEntradaACOES.Value, tProyecto.Text, tFechaEntradaP.Value, tFechaSalidaP.Value, tFechaAlta.Value, tFechaSalidACOES.Value,
                    Convert.ToString(tCurso.Value), tComunidadP.Text, tComunidadA.Text, tObservaciones.Text);

                this.ninioTableAdapter.Fill(this.aCOESDataSet.Ninio);
                RefrescaDatos();
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario a = null;
                if (tAgente.Text != "") a = new Usuario(tAgente.Text);
                if (tNombre.Text != seleccionado.Nombre) seleccionado.Nombre = tNombre.Text;
                if (tApellido.Text != seleccionado.Apellidos) seleccionado.Apellidos = tApellido.Text;
                if (tEstado.Text != seleccionado.Estado) seleccionado.Estado = tEstado.Text;
                if (tBeca.Text != seleccionado.Beca) seleccionado.Beca = tBeca.Text;
                if ((string)tSexo.SelectedItem != seleccionado.Sexo) seleccionado.Sexo = (string)tSexo.SelectedItem;
                if (tProyecto.Text != seleccionado.Proyecto) seleccionado.Proyecto = tProyecto.Text;
                if (tComunidadA.Text != seleccionado.ComunidadAct) seleccionado.ComunidadAct = tComunidadA.Text;
                if (tComunidadP.Text != seleccionado.ComunidadProc) seleccionado.ComunidadProc = tComunidadP.Text;
                if (tFechaEntradaACOES.Value != seleccionado.FechaEntradaAcoes) seleccionado.FechaEntradaAcoes = tFechaEntradaACOES.Value;
                if (tFechaEntradaP.Value != seleccionado.FechaEntradaProyecto) seleccionado.FechaEntradaProyecto = tFechaEntradaP.Value;
                if (tFechaNacimiento.Value != seleccionado.FechaNacimiento) seleccionado.FechaNacimiento = tFechaNacimiento.Value;
                if (tFechaSalidACOES.Value != seleccionado.FechaSalidaAcoes) seleccionado.FechaSalidaAcoes = tFechaSalidACOES.Value;
                if (tFechaSalidaP.Value != seleccionado.FechaSalidaProyecto) seleccionado.FechaSalidaProyecto = tFechaSalidaP.Value;
                if (tFechaAlta.Value != seleccionado.FechaAlta) seleccionado.FechaAlta = tFechaAlta.Value;
                if (a != seleccionado.Agente) seleccionado.Agente = a;
                if (tObservaciones.Text != seleccionado.Observaciones) seleccionado.Observaciones = tObservaciones.Text;
                if (tCurso.Value != Convert.ToDecimal(seleccionado.Curso)) seleccionado.Curso = Convert.ToString(tCurso.Value);

                this.ninioTableAdapter.Fill(this.aCOESDataSet.Ninio);
                RefrescaDatos();
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                seleccionado.BorrarNinio();
                seleccionado = null;
                this.ninioTableAdapter.Fill(this.aCOESDataSet.Ninio);
                RefrescaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seleccionado = null;
            RefrescaDatos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inicio form1 = new Inicio();
            form1.ShowDialog();
        }
    }
}
