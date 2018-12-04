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
            label1.Visible = false;

        }

        private void b_login_Click(object sender, EventArgs e) 
        {
            try
            {
                Usuario user1 = new Usuario(usu.Text, contra.Text);
                if (user1.rol_usuario == "C001")
                {
                    formularioCoordiandor();
                }else if(user1.rol_usuario == "CG001")
                {
                    formularioCoordiandor();
                }else if(user1.rol_usuario == "R001")
                {

                }else if(user1.rol_usuario == "A001")
                {

                }else if(user1.rol_usuario == "administrador")
                {
                    formularioCoordiandor();
                }

            }
            catch (Error) { label1.Visible = true; }

             
        }
        public void refresh()
        {
            usu.Text = "";
            contra.Text = "";
        }
        public void formularioCoordiandor()
        {
            this.Visible=false;
            Inicio form1 = new Inicio();
            form1.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible=false;
            Registro form2 = new Registro();
            form2.ShowDialog();
        }
    }
}
