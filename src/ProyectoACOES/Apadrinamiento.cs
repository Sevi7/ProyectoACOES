using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ProyectoACOES
{
    class Apadrinamiento
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private Socio socio;
        private Ninio ninio;
        private Usuario agente;
        private int dinero;
        private bool eliminado;


        public Apadrinamiento(Socio s, Ninio n, Usuario a, int d)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            bd.Insert("INSERT into Apadrinamiento values (" + s.codigo_socio + "," + n.Codigo + ",'" + a.nif_usuario + "'," + d +", "+0+");");
            socio = s;
            ninio = n;
            agente = a;
            dinero = d;
            eliminado = false;
        }
        public Apadrinamiento(Socio s, Ninio n, Usuario u)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Object[]> consulta = bd.Select("SELECT * FROM Apadrinamiento where socio=" + s.codigo_socio + " and ninio=" + n.Codigo + ";");
            if (consulta.Count == 0)
            {
                throw new Error("El apadrinamiento no se encuentra en el sistema");
            }
            Object[] tupla = consulta[0];
            if(u.rol_usuario.Equals("A001") && !(tupla[2].ToString()).Equals(u.nif_usuario)){
                throw new Error("El apadrinamiento corresponde a otro agente, usted no puede intervenir");
            }
            if((bool) tupla[4]==true){
                throw new Error("El apadrinamiento no se encuentra en el sistema");
            }
            socio = new Socio(Int32.Parse(tupla[0].ToString()));
            ninio = new Ninio (Int32.Parse(tupla[1].ToString()));
            agente = new Usuario(tupla[2].ToString());
            dinero = Int32.Parse(tupla[3].ToString());
            eliminado= false;
        }

        public void eliminarApadrinamiento(Usuario u)
        {
            if (u.rol_usuario.Equals("A001") && !(agente.nif_usuario).Equals(u.nif_usuario))
            {
                throw new Error("El apadrinamiento corresponde a otro agente, usted no puede intervenir");
            }
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Update("update Apadrinamiento set eliminado = 1 where socio=" + socio.codigo_socio + " and ninio=" + ninio.Codigo + ";");
            eliminado = true;

        }
    }
}
