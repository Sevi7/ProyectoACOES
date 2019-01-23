using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ProyectoACOES
{
    class Comunidad
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string nombre;
        private string desc;

        public static List<Comunidad> ListaComunidades()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Comunidad> lista = new List<Comunidad>();

            foreach(Object[] tupla in miBD.Select("SELECT * FROM Comunidad;")){
                lista.Add(new Comunidad ((string) tupla[0]));
            }

            return lista;
        }

        public static List<Comunidad> ListaComunidades(string buscador)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Comunidad> lista = new List<Comunidad>();

            foreach (Object[] tupla in miBD.Select("SELECT * FROM Comunidad WHERE nombre like '%" + buscador + "%';"))
            {
                lista.Add(new Comunidad((string)tupla[0]));
            }

            return lista;
        }

        public Comunidad(string name)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tupla = miBD.Select("SELECT * FROM Comunidad WHERE nombre ='" + name + "';")[0];
            nombre = (string)tupla[0];
            desc = (string)tupla[1];
        }

        public Comunidad(string name, string d)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT into Comunidad VALUES ('" + name + "', '" + d + "');");
            nombre = name;
            desc = d;
        }

        public string NOMBRE 
        {
            get {
                return nombre;
            }
            set{
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Comunidad SET nombre = '" + value + "' WHERE nombre = '" + nombre + "';");
                nombre = value;
            }
        }

        public string DESCRIPCION
        {
            get
            {
                return desc;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE Comunidad SET descripcion = '" + value + "' WHERE nombre = '" + nombre + "';");
                desc = value;
            }
        }

        public void borrar()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM Comunidad WHERE nombre = '" + nombre + "';");
            nombre = null;
            desc = null;
        }
    }
}
