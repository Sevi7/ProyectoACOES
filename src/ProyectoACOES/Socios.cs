﻿using System;
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
    public partial class Socios : Form
    {
        private Usuario usuario;
        public Socios()
        {
            InitializeComponent();
        }
        public Socios(Usuario u)
        {
            usuario = u;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GestionSocios socios = new GestionSocios();
            socios.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GestionarApadrinamientos ap = new GestionarApadrinamientos(usuario);
            ap.ShowDialog();

        }
    }
}