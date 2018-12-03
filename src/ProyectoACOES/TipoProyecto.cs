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
            nombre=n;
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
                nombre = (string)tupla[1];
                descripcion = (string)tupla[1];
                coordinador = new Usuario((string)tupla[1]);
                responsable = new Usuario((string)tupla[1]);
                //coger socios
            }
        }

        public void añadirSociosTipoProyecto(List<Socio> socios)
        {
            sociosdonantes=socios;
        }

        public void añadirSocioTipoProyecto (string NIF)
        {
            sociosdonantes.Add(new Socio(NIF));
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
