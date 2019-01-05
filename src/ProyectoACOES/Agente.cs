using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoACOES
{
    public class Agente
    {
        private int codigo;
        private string nombre, apellidos;

        public Agente(int v)
        {
            this.codigo = v;
        }

        public Agente(string n, string ap)
        {
            nombre = n;
            apellidos = ap;
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }
        }


    }
}
