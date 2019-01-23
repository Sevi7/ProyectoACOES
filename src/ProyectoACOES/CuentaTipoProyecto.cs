using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ProyectoACOES
{
    class CuentaTipoProyecto
    {

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int id;
        private string nombre;


        public CuentaTipoProyecto(int c, string tp)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            bd.Insert("Insert into CuentaTipoProyecto values(" + c + ",'" + tp + "');");
            this.id = c;
            this.nombre = tp;
        }
    }
}
