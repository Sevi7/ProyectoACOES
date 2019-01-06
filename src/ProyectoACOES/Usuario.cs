using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace ProyectoACOES
{
    public class Usuario
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string nif;
        private string alias;
        private string contraseña;
        private string correo;
        private string rol;


        public Usuario(string usu, string contraseña)
        {

            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            if (miBD.Select("Select * from Usuario where alias='" + usu + "' and contraseña='" + contraseña + "';").Capacity > 0)
            {
                object[] tupla = miBD.Select("Select * from Usuario where alias='" + usu + "' and contraseña='" + contraseña + "';")[0];
                this.nif = (string) tupla[0];
                this.alias = usu;
                this.contraseña = contraseña;
                this.correo = (string)tupla[3];
                this.rol = (string)tupla[4];

            }
            else
            {
                throw new Error("no se encuentra en la base de datos");
            }



        }

        public Usuario(string nif)
        {
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            List<Object[]> consulta = bd.Select("SELECT * FROM Usuario where nif='" + nif + "';");
            if (consulta.Count==0)
            {
                throw new Error("El N.I.F. " + nif + " no se encuentra en el sistema");
            }
            foreach (Object[] tupla in consulta)
            {
                this.nif = (string)tupla[0];
                this.alias = (string)tupla[1];
                this.contraseña = (string) tupla[2];
                this.correo = (string)tupla[3];
                this.rol = (string)tupla[4];
            }

        }

        public Usuario(string id, string alias, string contraseña, string correo, string rol)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            if (id == "")
            {
                throw new Error("N.I.F. es obligartrio");
            }
            miBD.Insert("Insert into Usuario values('" + id + "','" + alias + "','" + contraseña + "','" + correo + "','" + rol+"');");
            this.nif = id;
            this.alias = alias;
            this.contraseña = contraseña;
            this.correo = correo;
            this.rol = rol;
        }

        public string nif_usuario
        {
            get
            {
                return this.nif;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Usuario set nif = '" + value + "' where nif='" + this.nif + "';");
                this.nif = value;
            }
        }
        public string alias_usuario
        {
            get
            {
                return this.alias;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Usuario set alias = '" + value + "' where nif='" + this.nif + "';");
                this.alias = value;
            }
        }
        public string contraseña_usuario
        {
            get
            {
                return this.contraseña;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Usuario set contraseña = '" + value + "' where nif='" + this.nif + "';");
                this.contraseña = value;
            }
        }
        public string rol_usuario
        {
            get
            {
                return this.rol;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Usuario set rol = '" + value + "' where nif='" + this.nif + "';");
                this.rol = value;
            }
        }
        public string correo_usuario
        {
            get
            {
                return this.correo;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Usuario set correo = '" + value + "' where nif='" + this.nif + "';");
                this.correo = value;
            }
        }
        public void borrarUsuario()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("delete Usuario where nif='"+this.nif+"';");
            this.nif = null;
            this.alias = null;
            this.contraseña = null;
            this.rol = null;
            this.correo = null;

        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
