using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;
namespace ProyectoACOES
{
    class Proyecto
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private string nombre;
        private TipoProyecto tipoproyecto;
        private Usuario coordinador;
        private Usuario responsable;
        private string localidad;
        private List<Socio> sociosparticipantes;
        private List<Beneficiario> beneficiarios;

        public Proyecto(string n, TipoProyecto tp, Usuario c, Usuario r, string l, List<Socio> socios, List<Beneficiario> b)
        {
            SQLSERVERDB bd = new SQLSERVERDB (BD_SERVER,BD_NAME);
            bd.Insert("INSERT into Proyecto values ('"+n+"','"+tp.nombre_tipoproyecto+"','"+c.nif_usuario+"','"+r.nif_usuario+"','"+l+"')");
            foreach(Socio s in socios){
                bd.Update("UPDATE Socio set proyecto='"+tp.nombre_tipoproyecto+"' where codigo="+s.codigo_socio+";");
            }
            nombre=n;
            tipoproyecto=tp;
            coordinador=c;
            responsable=r;
            localidad=l;
            sociosparticipantes=socios;
            beneficiarios=b;
        }

    }
}
