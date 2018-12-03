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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void b_login_Click(object sender, EventArgs e) 
        {
            try
            {
                Usuario user1 = new Usuario(usu.Text, contra.Text);
                if (user1.rol_usuario == "C001")
                {
                    formularioCoordiandor();
();
                }else if(user1.rol_usuario == "CG001")
                {

                }else if(user1.rol_usuario == "R001")
                {

                }else if(user1.rol_usuario == "A001")
                {

                }
            }
            catch (Error) { }

             
        }
        public void refresh()
        {
            usu.Text = "";
            contra.Text = "";
        }
        public void formularioCoordiandor()
        {
            Inicio form1 = new Inicio();
            form1.ShowDialog();
        }


    }
}
