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

        private Beneficiario beneficiario;
        private int nota;
        private String asignatura;
        private DateTime fecha;

        public Calificacion(Beneficiario b, String a, DateTime f){
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("select * from Calificacion where Asignatura = '" + a  + "' and Fecha = '" + f + "' and Beneficiario = " + b.codigo_Beneficiario + ";")[0];

            beneficiario = new Beneficiario((int)tupla[0]);
            nota = (int)tupla[1];
            asignatura = (String)tupla[2];
            fecha = f;
        }

        public Calificacion(int b, int n,  String a, DateTime f){
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("Insert into Calificacion values(" + b + ", " + n + ", '" + a + "', '" + f.ToString("yyyy-MM-dd") + "');");
            beneficiario = new Beneficiario(b);
            nota = n;

        }
    }


}
