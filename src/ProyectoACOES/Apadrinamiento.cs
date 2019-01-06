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
            bd.Insert("INSERT into Apadrinamiento values (" + s.codigo_socio + "," + n.codigo_Beneficiario + ",'" + a.nif_usuario + "'," + d +", "+0+");");
            socio = s;
            ninio = n;
            agente = a;
            dinero = d;
            eliminado = false;
        }
        public Apadrinamiento(Socio s, Ninio n, Usuario u)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Object[]> consulta = bd.Select("SELECT * FROM Apadrinamiento where socio=" + s + " and ninio=" + n + ";");
            if (consulta.Count == 0)
            {
                throw new Error("El apadrinamiento no se encuentra en el sistema");
            }
            Object[] tupla = consulta[0];
            if(u.rol_usuario.Equals("A001") && !((String)tupla[3]).Equals(u.nif_usuario)){
                throw new Error("El apadrinamiento corresponde a otro agente, usted no puede intervenir");
            }
            if((bool) tupla[4]==true){
                throw new Error("El apadrinamiento no se encuentra en el sistema");
            }
            socio = new Socio(Int32.Parse((string)tupla[0]));
            ninio = new Ninio (Int32.Parse((string)tupla[1]));
            agente = new Usuario((string)tupla[2]);
            dinero = Int32.Parse((string)tupla[3]);
            eliminado= false;
        }

        public void eliminarApadrinamiento(Usuario u)
        {
            if (u.rol_usuario.Equals("A001") && !(agente.nif_usuario).Equals(u.nif_usuario))
            {
                throw new Error("El apadrinamiento corresponde a otro agente, usted no puede intervenir");
            }
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Update("update set eliminado = 1 where socio=" + socio.codigo_socio + " and ninio=" + ninio.codigo_Beneficiario + ";");
            eliminado = true;

        }
    }
}
