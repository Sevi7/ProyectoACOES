using BDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoACOES
{
    class Beneficiario
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private String nif;
        private String nombre;
        private String apellidos;
        private String observaciones;
        private Usuario resposanble;
        private String numCuenta;
        
        public Beneficiario(string nif)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("select * from beneficiario where nif ='" + nif + "';")[0];

            this.nif = (string)tupla[0];
            nombre = (string)tupla[1];
            apellidos = (string)tupla[2];
            observaciones = (string)tupla[3];
            resposanble = new Usuario((string)tupla[4]);
            numCuenta = (string)tupla[5];
        }

        public Beneficiario(String n, String nom, String a, String ob, Usuario res, String num)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            miBD.Insert("insert into Beneficiario values('" + n + "', '" + nom + "', '" + a + "', '" + ob + "', '" + res.nif_usuario + "', '" + num + "', 0);");

            nif = n;
            nombre = nom;
            apellidos = a;
            observaciones = ob;
            resposanble = res;
            numCuenta = num;
        }

        public void BorrarBeneficiario()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Update("update Beneficiario set eliminado = " + 1 + " where NIF='" + nif + "';");
        }


        public string NIF
        {
            get
            {
                return nif;
            }
            set
            {
                if (value != nif)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Beneficario set nif = '" + value + "' where nif='" + nif + "';");
                    nif = value;
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
                    miBD.Update("update Beneficiario set Nombre = '" + value + "' where NIF='" + nif + "';");
                    nombre = value;
                }
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                if (value != apellidos)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Beneficiario set apellidos = '" + value + "' where NIF='" + nif + "';");
                    apellidos = value;
                }
            }
        }

        public string Observaciones
        {
            get
            {
                return observaciones;
            }
            set
            {
                if (value != observaciones)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Beneficiario set observaciones = '" + value + "' where NIF='" + nif + "';");
                    observaciones = value;
                }
            }
        }

        public Usuario Resposable
        {
            get
            {
                return resposanble;
            }
            set
            {
                if (!value.Equals(resposanble))
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Beneficiario set responsable = '" + value.nif_usuario + "' where NIF='" + nif + "';");
                    resposanble = value;
                }
            }
        }

        public string NumCuenta
        {
            get
            {
                return numCuenta;
            }
            set
            {
                if (value != numCuenta)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Beneficiario set numCuenta = '" + value + "' where NIF='" + nif + "';");
                    numCuenta = value;
                }
            }
        }
    }
}
