using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ProyectoACOES
{
    class Calificacion
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private Ninio Ninio;
        private int nota;
        private String asignatura;
        private DateTime fecha;

        public Calificacion(Ninio b, String a, DateTime f){
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("select * from Calificacion where Asignatura = '" + a  + "' and Fecha = '" + f + "' and Ninio = " + b.codigo_Beneficiario + ";")[0];

            Ninio = new Ninio((int)tupla[0]);
            nota = (int)tupla[1];
            asignatura = (String)tupla[2];
            fecha = f;
        }

        public Calificacion(int b, int n,  String a, DateTime f){
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("Insert into Calificacion values(" + b + ", " + n + ", '" + a + "', '" + f.ToString("yyyy-MM-dd") + "');");
            Ninio = new Ninio(b);
            nota = n;

        }
    }


}
