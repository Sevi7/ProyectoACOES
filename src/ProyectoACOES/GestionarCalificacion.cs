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
using System.Data.SqlClient;

namespace ProyectoACOES
{
    public partial class GestionarCalificacion : Form
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private Ninio seleccionado = null;
        private Calificacion nota = null;

        public GestionarCalificacion()
        {
            InitializeComponent();
        }

        private void GestionarCalificacion_Load(object sender, EventArgs e)
        {
            iniciarTabla();
        }

        private void iniciarTabla()
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string consultaSelect = "SELECT Codigo, Nombre, Apellidos, fechaNacimiento, Curso FROM Ninio WHERE eliminado = 0;";
            DataTable tablaN = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consultaSelect, bd.cadenaConexionSQLNCLI);
            adaptador.Fill(tablaN);
            dataGridViewAlumnos.DataSource = tablaN;
        }

        private void alumnoSeleccionado(object sender, EventArgs e)
        {
            if (dataGridViewAlumnos.SelectedRows.Count > 0)
            {
                int codigo = (int)dataGridViewAlumnos.SelectedRows[0].Cells[0].Value;
                seleccionado = new Ninio(codigo);
                cargarCalificaciones();
            }
        }



        private void cargarCalificaciones()
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string consulta2Select;
            if (seleccionado != null)
            {
                consulta2Select = "SELECT Asignatura, Nota, Fecha FROM Calificacion WHERE ninio = " + seleccionado.Codigo + ";";
            }
            else
            {
                consulta2Select = "SELECT Asignatura, Nota, Fecha FROM Calificacion WHERE 1 = 2;";
            }
            DataTable tablaN = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta2Select, bd.cadenaConexionSQLNCLI);
            adaptador.Fill(tablaN);
            dataGridViewCalificaciones.DataSource = tablaN;
        }

        private void calificacionSeleccionada(object sender, EventArgs e)
        {
            if (dataGridViewCalificaciones.SelectedRows.Count > 0)
            {
                string asig = (string)dataGridViewCalificaciones.SelectedRows[0].Cells[0].Value;
                DateTime f = (DateTime)dataGridViewCalificaciones.SelectedRows[0].Cells[2].Value;
                nota = new Calificacion(seleccionado,asig,f);
                tAsignatura.Text = asig;
                tNota.Text = Convert.ToString(nota.Nota);
                dFecha.Value = f;
            }
        }

        private void bInsertar_click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null && nota == null && tAsignatura.Text != "" && tNota.Text != "")
                {
                    if(Convert.ToInt32(tNota.Text) >= 0 && Convert.ToInt32(tNota.Text) <= 10){
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    new Calificacion(seleccionado.Codigo, Convert.ToInt32(tNota.Text), tAsignatura.Text, dFecha.Value);
                    clean();
                    cargarCalificaciones();
                    } else {
                        throw new Error("Nota fuera de los valores permitidos");
                    }
                } else if (seleccionado == null){
                    throw new Error("No has seleccionado ningún alumno");
                } else if (nota != null){
                    throw new Error("No puedes tener seleccionada una calificacion al insertar una");
                } else if (tAsignatura.Text == "")
                {
                    throw new Error("Debes rellenar el campo: Asignatura");
                } else if (tNota.Text == "")
                {
                    throw new Error("Debes rellenar el campo: Nota");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bModificar_click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null && nota != null && tAsignatura.Text != "" && tNota.Text != "")
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    if (tAsignatura.Text != nota.Asignatura) nota.Asignatura = tAsignatura.Text;
                    if (Convert.ToInt32(tNota.Text) != nota.Nota) nota.Nota = Convert.ToInt32(tNota.Text);
                    if (dFecha.Value != nota.Fecha) nota.Fecha = dFecha.Value;
                    clean();
                    nota = null;
                    cargarCalificaciones();
                }
                else if (seleccionado == null)
                {
                    throw new Error("No has seleccionado ningún alumno");
                }
                else if (nota != null)
                {
                    throw new Error("No puedes tener seleccionada una calificacion al insertar una");
                }
                else if (tAsignatura.Text == "")
                {
                    throw new Error("Debes rellenar el campo: Asignatura");
                }
                else if (tNota.Text == "")
                {
                    throw new Error("Debes rellenar el campo: Nota");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bEliminar_click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionado != null && nota != null)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("DELETE FROM Calificacion WHERE ninio = " + seleccionado.Codigo + " and asignatura = '"+ nota.Asignatura + "' and fecha = '" + nota.Fecha + "';");
                    clean();
                    nota = null;
                    cargarCalificaciones();
                }
                else if (seleccionado == null)
                {
                    throw new Error("No has seleccionado ningún alumno");
                }
                else if (nota == null)
                {
                    throw new Error("No has seleccionado ninguna calificacion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bLimpiar_click(object sender, EventArgs e)
        {
            seleccionado = null;
            cargarCalificaciones();
            clean();
            
        }

        private void clean()
        {
            tAsignatura.Text = "";
            tNota.Text = "";
            dFecha.Value = Convert.ToDateTime("01/01/2019");
            nota = null;
            dataGridViewAlumnos.ClearSelection();
            dataGridViewCalificaciones.ClearSelection();
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inicio form1 = new Inicio();
            form1.ShowDialog();
        }
    }
}
