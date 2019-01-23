using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ProyectoACOES
{
    class CuentaProyecto
    {

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int proyecto;
        private int cuenta;

        public CuentaProyecto(int p, int c)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            bd.Insert("Insert into CuentaProyecto values(" + p + "," + c + ");");
            this.proyecto = p;
            this.cuenta = c;

        }
    }
}
