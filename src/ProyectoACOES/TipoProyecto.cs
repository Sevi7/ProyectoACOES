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
            foreach(Socio s in socios){
                bd.Insert("INSERT into Socio_TipoProyecto values (" + s.codigo_socio + ", '" + n + "');");
            }
            this.nombre=n;
            descripcion=d;
            coordinador=c;
            responsable=r;
            sociosdonantes=socios;
        }
        public TipoProyecto(string n)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Object[]> consulta = bd.Select("SELECT * FROM TipoProyecto where nombre='" + n + "';");
            if (consulta.Count == 0)
            {
                throw new Error("El tipo de proyecto " + n + " no se encuentra en el sistema");
            }
            foreach(Object[] tupla in  bd.Select("SELECT * FROM TipoProyecto where nombre='" + n + "';"))
            {
                nombre = (string)tupla[0];
                descripcion = (string)tupla[1];
                coordinador = new Usuario(tupla[2].ToString());
                responsable = new Usuario(tupla[3].ToString());
                foreach(Object[] so in bd.Select("Select * from Socio_TipoProyecto where tipoProyecto='"+nombre+"';")){
                    //sociosdonantes.Add(new Socio(Int32.Parse(so[0].ToString())));
                }
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
