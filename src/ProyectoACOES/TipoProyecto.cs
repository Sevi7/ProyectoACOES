using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ProyectoACOES
{
    class TipoProyecto
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private string nombre;
        private string descripcion;
        private Usuario coordinador;
        private Usuario responsable;
        private List<Socio> sociosdonantes;

        public TipoProyecto(string n, string d, Usuario c, Usuario r, List<Socio> socios)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            bd.Insert("INSERT into TipoProyecto values ('" + n + "','" + d + "','" + c.nif_usuario + "','" + r.nif_usuario + "');");
            //insertar todos los socios
            this.nombre=n;
            descripcion=d;
            coordinador=c;
            responsable=r;
            sociosdonantes=socios;
        }
        public TipoProyecto(string n)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach(Object[] tupla in  bd.Select("SELECT * FROM TipoProyecto where nombre='" + n + "';"))
            {
                nombre = (string)tupla[0];
                descripcion = (string)tupla[1];
                coordinador = new Usuario((string)tupla[2]);
                responsable = new Usuario((string)tupla[3]);
                //coger socios
            }
        }
        
        public string nombre_tipoproyecto
        {
            get
            {
                return nombre;
            }
        }




    }
}
