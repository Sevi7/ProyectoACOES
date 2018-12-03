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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarBeneficiario elim = new EliminarBeneficiario();
            elim.ShowDialog();
        }

        private void insertBen_Click(object sender, EventArgs e)
        {
            InsertarBeneficiario insert = new InsertarBeneficiario();
            insert.ShowDialog();
        }

        private void crearTipoProyecto_Click(object sender, EventArgs e)
        {
            CrearNuevoTipoProyecto tipoProyecto = new CrearNuevoTipoProyecto();
            tipoProyecto.ShowDialog();
        }

        private void crearProyecto_Click(object sender, EventArgs e)
        {
            CrearNuevoProyecto nuevo = new CrearNuevoProyecto();
            nuevo.ShowDialog();

        }
    }
}
