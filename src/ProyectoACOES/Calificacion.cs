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

        private Ninio ninio;
        private int nota;
        private String asignatura;
        private DateTime fecha;

        public Calificacion(Ninio b, String a, DateTime f)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("select * from Calificacion where Asignatura = '" + a + "' and Fecha = '" + f.ToString("yyyy-MM-dd") + "' and Ninio = " + b.Codigo + ";")[0];

            ninio = new Ninio((int)tupla[0]);
            nota = (int)tupla[1];
            asignatura = (String)tupla[2];
            fecha = f;
        }

        public Calificacion(int b, int n, String a, DateTime f)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("Insert into Calificacion values(" + b + ", " + n + ", '" + a + "', '" + f.ToString("yyyy-MM-dd") + "');");
            ninio = new Ninio(b);
            nota = n;

        }

        public Ninio Ninio
        {
            get 
            { 
                return ninio; 
            }
        }

        public int Nota
        {
            get
            {
                return nota;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Calificacion set nota = '" + value + "' where ninio= " + ninio.Codigo + " and asignatura = '" + asignatura + "' and fecha = '" + fecha.ToString("yyyy-MM-dd") + "';");
                nota = value;
            }
        }

        public string Asignatura
        {
            get
            {
                return asignatura;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Calificacion set Asignatura = '" + value + "' where ninio= " + ninio.Codigo + " and fecha = '" + fecha.ToString("yyyy-MM-dd") + "';");
                asignatura = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Calificacion set fecha = '" + value.ToString("yyyy-MM-dd") + "' where ninio= " + ninio.Codigo + " and asignatura = '" + asignatura + "';");
                fecha = value;
            }
        }
    }
}
