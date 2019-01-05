using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;


namespace ProyectoACOES
{
    class Socio
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int codigo;
        private string nombre;
        private string apellidos;
        private string estado;
        private string nif;
        private string direccion;
        private string poblacion;
        private int codigoPostal;
        private string provincia;
        private int tlf;
        private int tlfSecundario;
        private string email;
        private Agente agente;
        private string relacion;
        private Boolean certificado;
        private string sector;
        private DateTime fechaAlta;
        private DateTime fechaBaja;
        private string observaciones;
        private string numCuenta;
        private Boolean eliminado;

        public Socio(int c)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("select * from Socio where Codigo = " + c + ";")[0];

            if (!Convert.ToBoolean(tupla[20])) {
                codigo = c;
                nombre = (string)tupla[1];
                if (tupla[2] != DBNull.Value) apellidos = (string)tupla[2];
                if (tupla[3] != DBNull.Value) estado = (string)tupla[3];
                if (tupla[4] != DBNull.Value) nif = (string)tupla[4];
                if (tupla[5] != DBNull.Value) direccion = (string)tupla[5];
                if (tupla[6] != DBNull.Value) poblacion = (string)tupla[6];
                if (tupla[7] != DBNull.Value) codigoPostal = (int)tupla[7];
                if (tupla[8] != DBNull.Value) provincia = (string)tupla[8];
                tlf = (int)tupla[9];
                if (tupla[10] != DBNull.Value) tlfSecundario = (int)tupla[10];
                if (tupla[11] != DBNull.Value) email = (string)tupla[11];
                agente = new Agente(Convert.ToInt32(tupla[12]));
                if (tupla[13] != DBNull.Value) relacion = (string)tupla[13];
                if (tupla[14] != DBNull.Value) certificado = Convert.ToBoolean(tupla[14]);
                if (tupla[15] != DBNull.Value) sector = (string)tupla[15];
                if (tupla[16] != DBNull.Value) fechaAlta = Convert.ToDateTime(tupla[16]);
                if (tupla[17] != DBNull.Value) fechaBaja = Convert.ToDateTime(tupla[17]);
                if (tupla[18] != DBNull.Value) observaciones = (string)tupla[18];
                if (tupla[19] != DBNull.Value) numCuenta = (string)tupla[19];
                eliminado = false;
            }
        }

        public Socio(string n, string ap, string e, string nif, string dir, string pob, int cp, string prov, 
            int tlf, int tlf2, string em, Agente ag, string rel, Boolean cer, string sec, DateTime fA, DateTime fB, string ob, string numC)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

          miBD.Insert("insert into Socio values('" + n + "', '" + ap + "'," + e + "', '" + nif + "', '" + dir + "', '" + pob + "', " +
               cp + ", '" + prov + "', " + tlf + ", " + tlf2 + ", '" + em + ","+ag.Codigo+"," + rel + "', '" + cer + "', '" + sec + "', " + fA.ToString("yyyy-MM-dd") + "', '" +
               fB.ToString("yyyy-MM-dd") + "', " + ob + "', '" + numC + "', 0);");

            codigo = Convert.ToInt32(miBD.Select("select max(Codigo) from Socio;")[0][0]);
            nombre = n;
            apellidos = ap;
            estado = e;
            this.nif = nif;
            direccion = dir;
            poblacion = pob;
            cp = codigoPostal;
            provincia = prov;
            this.tlf = tlf;
            tlfSecundario = tlf2;
            email = em;
            agente = ag;
            relacion = rel;
            certificado = cer;
            sector = sec;
            fechaAlta = fA;
            fechaBaja = fB;
            observaciones = ob;
            numCuenta = numC;
        }

        public int codigo_socio
        {
            get
            {
                return codigo;
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
                    miBD.Update("update Socio set Nombre = '" + value + "' where Codigo=" + codigo + ";");
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
                    miBD.Update("update Socio set apellidos = '" + value + "' where Codigo=" + codigo + ";");
                    apellidos = value;
                }
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                if (value != estado)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set estado = '" + value + "' where Codigo=" + codigo + ";");
                    estado = value;
                }

            }
        }
        public string Nif
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
                    miBD.Update("update Socio set nif = '" + value + "' where Codigo=" + codigo + ";");
                    nif = value;
                }

            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                if (direccion != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set direccion = '" + value + "' where Codigo=" + codigo + ";");
                    direccion = value;
                }
                
            }
        }

        public string Poblacion
        {
            get
            {
                return poblacion;
            }
            set
            {
                if (direccion != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set poblacion = '" + value + "' where Codigo=" + codigo + ";");
                    poblacion = value;
                }
            }
        }

        public int CodigoPostal
        {
            get
            {
                return codigoPostal;
            }
            set
            {
                if (codigoPostal != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set codigoPostal = '" + value + "' where Codigo=" + codigo + ";");
                    codigoPostal = value;
                }
                
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }
            set
            {
                if (provincia != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set provincia = '" + value + "' where Codigo=" + codigo + ";");
                    provincia = value;
                }
                
            }
        }

        public int Tlf
        {
            get
            {
                return tlf;
            }
            set
            {
                if (tlf != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set tlf = '" + value + "' where Codigo=" + codigo + ";");
                    tlf = value;
                }
                
            }
        }

        public int TlfSecundario
        {
            get
            {
                return tlfSecundario;
            }
            set
            {
                if (tlfSecundario != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set tlfSecundario = '" + value + "' where Codigo=" + codigo + ";");
                    tlfSecundario = value;
                }
                
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set email = '" + value + "' where Codigo=" + codigo + ";");
                    email = value;
                }
                
            }
        }
        public Agente Agente
        {
            get
            {
                return agente;
            }
            set
            {
                if (!agente.Equals(value))
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set agente = '" + value.Codigo + "' where Codigo=" + codigo + ";");
                    agente = value;
                }
                
            }
        }
        public string Relacion
        {
            get
            {
                return relacion;
            }
            set
            {
                if(relacion != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set relacion = '" + value + "' where Codigo=" + codigo + ";");
                    relacion = value;
                }
                
            }
        }
        public Boolean Certificado
        {
            get
            {
                return certificado;
            }
            set
            {
                if (value != certificado)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set certificado = '" + value + "' where Codigo=" + codigo + ";");
                    certificado = value;
                }
                
            }
        }
        public string Sector
        {
            get
            {
                return sector;
            }
            set
            {
                if (sector != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set sector = '" + value + "' where Codigo=" + codigo + ";");
                    sector = value;
                }
                
            }
        }
        public DateTime FechaAlta
        {
            get
            {
                return fechaAlta;
            }
            set
            {
                if (fechaAlta != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set fechaAlta = '" + value + "' where Codigo=" + codigo + ";");
                    fechaAlta = value;
                }
                
            }
        }
        public DateTime FechaBaja
        {
            get
            {
                return fechaBaja;
            }
            set
            {
                if (fechaBaja != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set fechaBaja = '" + value + "' where Codigo=" + codigo + ";");
                    fechaBaja = value;
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
                if (observaciones != value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set observaciones = '" + value + "' where Codigo=" + codigo + ";");
                    observaciones = value;
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
                if (numCuenta!=value)
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Socio set numCuenta = '" + value + "' where Codigo=" + codigo + ";");
                    numCuenta = value;
                }
                
            }
        }
        public void BorrarSocio()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Update("update Socio set eliminado = 1 where codigo =" + codigo + ";");
            eliminado = true;
        }

        public override bool Equals(object obj)
        {
            var socio = obj as Socio;
            return socio != null &&
                   codigo == socio.codigo &&
                   nombre == socio.nombre &&
                   apellidos == socio.apellidos &&
                   estado == socio.estado &&
                   nif == socio.nif &&
                   direccion == socio.direccion &&
                   poblacion == socio.poblacion &&
                   codigoPostal == socio.codigoPostal &&
                   provincia == socio.provincia &&
                   tlf == socio.tlf &&
                   tlfSecundario == socio.tlfSecundario &&
                   email == socio.email &&
                   EqualityComparer<Agente>.Default.Equals(agente, socio.agente) &&
                   relacion == socio.relacion &&
                   certificado == socio.certificado &&
                   sector == socio.sector &&
                   fechaAlta == socio.fechaAlta &&
                   fechaBaja == socio.fechaBaja &&
                   observaciones == socio.observaciones &&
                   numCuenta == socio.numCuenta &&
                   eliminado == socio.eliminado &&
                   codigo_socio == socio.codigo_socio &&
                   Nombre == socio.Nombre &&
                   Apellidos == socio.Apellidos &&
                   Estado == socio.Estado &&
                   Nif == socio.Nif &&
                   Direccion == socio.Direccion &&
                   Poblacion == socio.Poblacion &&
                   CodigoPostal == socio.CodigoPostal &&
                   Provincia == socio.Provincia &&
                   Tlf == socio.Tlf &&
                   TlfSecundario == socio.TlfSecundario &&
                   Email == socio.Email &&
                   EqualityComparer<Agente>.Default.Equals(Agente, socio.Agente) &&
                   Relacion == socio.Relacion &&
                   Certificado == socio.Certificado &&
                   Sector == socio.Sector &&
                   FechaAlta == socio.FechaAlta &&
                   FechaBaja == socio.FechaBaja &&
                   Observaciones == socio.Observaciones &&
                   NumCuenta == socio.NumCuenta;
        }

        public override int GetHashCode()
        {
            var hashCode = 1992327797;
            hashCode = hashCode * -1521134295 + codigo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(apellidos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(estado);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nif);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(direccion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(poblacion);
            hashCode = hashCode * -1521134295 + codigoPostal.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(provincia);
            hashCode = hashCode * -1521134295 + tlf.GetHashCode();
            hashCode = hashCode * -1521134295 + tlfSecundario.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            hashCode = hashCode * -1521134295 + EqualityComparer<Agente>.Default.GetHashCode(agente);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(relacion);
            hashCode = hashCode * -1521134295 + certificado.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(sector);
            hashCode = hashCode * -1521134295 + fechaAlta.GetHashCode();
            hashCode = hashCode * -1521134295 + fechaBaja.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(observaciones);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(numCuenta);
            hashCode = hashCode * -1521134295 + eliminado.GetHashCode();
            hashCode = hashCode * -1521134295 + codigo_socio.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Estado);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nif);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Direccion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Poblacion);
            hashCode = hashCode * -1521134295 + CodigoPostal.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Provincia);
            hashCode = hashCode * -1521134295 + Tlf.GetHashCode();
            hashCode = hashCode * -1521134295 + TlfSecundario.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<Agente>.Default.GetHashCode(Agente);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Relacion);
            hashCode = hashCode * -1521134295 + Certificado.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sector);
            hashCode = hashCode * -1521134295 + FechaAlta.GetHashCode();
            hashCode = hashCode * -1521134295 + FechaBaja.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Observaciones);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NumCuenta);
            return hashCode;
        }
    }
}
