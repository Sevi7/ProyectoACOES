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
    public partial class InicioResponsable : Form
    {
        private Usuario user1;

        public InicioResponsable(Usuario user)
        {
            InitializeComponent();
            user1 = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            GestionEconomica form1 = new GestionEconomica(user1);
            form1.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            GestionBeneficiario form1 = new GestionBeneficiario(user1);
            form1.ShowDialog();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Login l = new Login();
            l.ShowDialog();
        }
    }
}
