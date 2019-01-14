using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ProyectoACOES
{
    class Cuenta
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private readonly int id;
        private string tipo;
        private string nombre;
        private string categoria;
        private double cantidad;
        private DateTime fecha;
        private string descripcion;

        public Cuenta(int id)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] cuenta = bd.Select("Select * from Cuenta where id =" + id + ";")[0];
            this.id = id;
            this.tipo = (string)cuenta[1];
            this.nombre = (string)cuenta[2];
            this.categoria = (string)cuenta[3];
            this.cantidad =Convert.ToDouble(cuenta[4]);
            this.fecha = Convert.ToDateTime(cuenta[5]);
            this.descripcion = (string)cuenta[6];


        }

        public Cuenta(string t, string n, string cat, double cant, DateTime f, string des)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            bd.Insert("Insert into Cuenta values('" + t + "','" + n + "','" + cat + "'," + cant + ",'" + f.ToString("yyyy-MM-dd") + "','" + des + "');");
            this.id = Convert.ToInt32(bd.Select("SELECT max(id) from Cuenta")[0][0]);
            this.tipo = t;
            this.nombre = n;
            this.categoria = cat;
            this.cantidad = cant;
            this.fecha = f;


        }
        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                if (value != tipo)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Cuenta set tipo = '" + value + "' where id=" + id + ";");
                    tipo = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value != nombre)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Cuenta set nombre = '" + value + "' where id=" + id + ";");
                    nombre = value;
                }
            }
        }
        public string Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                if (value != categoria)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Cuenta set categoria = '" + value + "' where id=" + id + ";");
                    categoria = value;
                }
            }
        }
        public double Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                if (value != cantidad)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Cuenta set cantidad = " + value + " where id=" + id + ";");
                    cantidad = value;
                }
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
                if (value != fecha)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Cuenta set fecha = '" + value.ToString("yyyy-MM-dd") + "' where id=" + id + ";");
                    fecha = value;
                }
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                if (value != descripcion)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Cuenta set descripcion = '" + value + "' where id=" + id + ";");
                    descripcion = value;
                }
            }
        }

        public void borrarCuenta()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("Delete from Cuenta where id=" + this.id + ";");



        }

    }
}
