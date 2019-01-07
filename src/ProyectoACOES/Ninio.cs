using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;


namespace ProyectoACOES
{
    public class Ninio
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private int codigo;
        private string nombre;
        private string apellidos;
        private string estado;
        private string beca;
        private string sexo;
        private Usuario agente;
        private DateTime fechaNacimiento;
        private DateTime fechaEntradaAcoes;
        private string proyecto;
        private DateTime fechaEntradaProyecto;
        private DateTime fechaSalidaProyecto;
        private DateTime fechaAlta;
        private DateTime fechaSalidaAcoes;
        private string curso;
        private string comunidadProc;
        private string comunidadAct;
        private string observaciones;

        public Ninio(int c)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("select * from Ninio where Codigo = " + c + ";")[0];

            codigo = c;
            nombre = (string)tupla[1];
            if (tupla[2] != DBNull.Value) apellidos = (string)tupla[2];
            if (tupla[3] != DBNull.Value) estado = (string)tupla[3];
            if (tupla[4] != DBNull.Value) beca = (string)tupla[4];
            sexo = (string)tupla[5];
            if (tupla[6] != DBNull.Value) agente = new Usuario((string)tupla[6]);
            if (tupla[7] != DBNull.Value) fechaNacimiento = Convert.ToDateTime(tupla[7]);
            if (tupla[8] != DBNull.Value) fechaEntradaAcoes = Convert.ToDateTime(tupla[8]);
            if (tupla[9] != DBNull.Value) proyecto = tupla[9].ToString();
            if (tupla[10] != DBNull.Value) fechaEntradaProyecto = Convert.ToDateTime(tupla[10]);
            if (tupla[11] != DBNull.Value) fechaSalidaProyecto = Convert.ToDateTime(tupla[11]);
            if (tupla[12] != DBNull.Value) fechaAlta = Convert.ToDateTime(tupla[12]);
            if (tupla[13] != DBNull.Value) fechaSalidaAcoes = Convert.ToDateTime(tupla[13]);
            if (tupla[14] != DBNull.Value) curso = (string)tupla[14];
            if (tupla[15] != DBNull.Value) comunidadProc = (string)tupla[15];
            if (tupla[16] != DBNull.Value) comunidadAct = (string)tupla[16];
            if (tupla[17] != DBNull.Value) observaciones = (string)tupla[17];
        }

        public Ninio(string n, string ap, string e, string b, string s, Usuario a,
             DateTime fN, DateTime fEA, string p, DateTime fEP, DateTime fSP, DateTime fA, DateTime fSA, string co, string cP,
             string cA, string o)
         {
             SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
             if (a == null && p != "")
             {
                 miBD.Insert("insert into Ninio values('" + n + "', '" + ap + "','" + e + "','" + b + "','" + s + "',null,'" + fN.ToString("yyyy - MM - dd") + "','" +
                fEA.ToString("yyyy-MM-dd") + "'," + Int32.Parse(p) + ",'" + fEP.ToString("yyyy-MM-dd") + "','" + fSP.ToString("yyyy-MM-dd") + "','" + fA.ToString("yyyy - MM - dd") + "', '" +
                fSA.ToString("yyyy-MM-dd") + "','" + co + "','" + cP + "','" + cA + "','" + o + "',0);");
             }
             else if (p == "" && a == null)
             {
                 miBD.Insert("insert into Ninio values('" + n + "', '" + ap + "','" + e + "','" + b + "','" + s + "',null,'" + fN.ToString("yyyy - MM - dd") + "','" +
                fEA.ToString("yyyy-MM-dd") + "',null,'" + fEP.ToString("yyyy-MM-dd") + "','" + fSP.ToString("yyyy-MM-dd") + "','" + fA.ToString("yyyy - MM - dd") + "', '" +
                fSA.ToString("yyyy-MM-dd") + "','" + co + "','" + cP + "','" + cA + "','" + o + "',0);");
             }
             else if (p == "" && a != null)
             {
                 miBD.Insert("insert into Ninio values('" + n + "', '" + ap + "','" + e + "','" + b + "','" + s + "'," + a.nif_usuario + ",'" + fN.ToString("yyyy - MM - dd") + "','" +
                 fEA.ToString("yyyy-MM-dd") + "',null,'" + fEP.ToString("yyyy-MM-dd") + "','" + fSP.ToString("yyyy-MM-dd") + "','" + fA.ToString("yyyy - MM - dd") + "', '" +
                 fSA.ToString("yyyy-MM-dd") + "','" + co + "','" + cP + "','" + cA + "','" + o + "',0);");
             }
             else
             {
                 miBD.Insert("insert into Ninio values('" + n + "', '" + ap + "','" + e + "','" + b + "','" + s + "','" + a.nif_usuario + "','" + fN.ToString("yyyy - MM - dd") + "','" +
                fEA.ToString("yyyy-MM-dd") + "','" + Int32.Parse(p) + "','" + fEP.ToString("yyyy-MM-dd") + "','" + fSP.ToString("yyyy-MM-dd") + "','" + fA.ToString("yyyy - MM - dd") + "', '" +
                fSA.ToString("yyyy-MM-dd") + "','" + co + "','" + cP + "','" + cA + "','" + o + "',0);");
             }

             codigo = Convert.ToInt32(miBD.Select("select max(Codigo) from Ninio;")[0][0]);
             nombre = n;
             apellidos = ap;
             estado = e;
             beca = b;
             sexo = s;
             agente = a;
             fechaNacimiento = fN;
             fechaEntradaAcoes = fEA;
             proyecto = p;
             fechaEntradaProyecto = fEP;
             fechaSalidaProyecto = fSP;
             fechaAlta = fA;
             fechaSalidaAcoes = fSA;
             curso = co;
             comunidadProc = cP;
             comunidadAct = cA;
             observaciones = o;

         }

        public int Codigo 
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set Nombre = '" + value + "' where Codigo=" + Codigo + ";");
                nombre = value;
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set Apellidos = '" + value + "' where Codigo=" + Codigo + ";");
                apellidos = value;
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set Estado = '" + value + "' where Codigo=" + Codigo + ";");
                estado = value;
            }
        }

        public string Beca
        {
            get
            {
                return beca;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set Beca = '" + value + "' where Codigo=" + Codigo + ";");
                beca = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set Sexo = '" + value + "' where Codigo=" + Codigo + ";");
                sexo = value;
            }
        }

        public Usuario Agente
          {
              get
              {
                  return agente;
              }
              set
              {
                  SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                  miBD.Update("update Ninio set Agente = '" + value.nif_usuario + "' where Codigo=" + Codigo + ";");
                  agente = value;
              }
          }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set FechaNacimiento = '" + value + "' where Codigo=" + Codigo + ";");
                fechaNacimiento = value;
            }
        }

        public DateTime FechaEntradaAcoes
        {
            get
            {
                return fechaEntradaAcoes;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set FechaEntradaAcoes = '" + value + "' where Codigo=" + Codigo + ";");
                fechaEntradaAcoes = value;
            }
        }

        public string Proyecto
        {
            get
            {
                return proyecto;
            }
            set
            {

                if (value != "")
                {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("update Ninio set Proyecto = " + Int32.Parse(value) + " where Codigo=" + Codigo + ";");
                    proyecto = value;
                }

            }
        }

        public DateTime FechaEntradaProyecto
        {
            get
            {
                return fechaEntradaProyecto;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set FechaEntradaProyecto = '" + value + "' where Codigo=" + Codigo + ";");
                fechaEntradaProyecto = value;
            }
        }

        public DateTime FechaSalidaProyecto
        {
            get
            {
                return fechaSalidaProyecto;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set FechaSalidaProyecto = '" + value + "' where Codigo=" + Codigo + ";");
                fechaSalidaProyecto = value;
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set FechaAlta = '" + value + "' where Codigo=" + Codigo + ";");
                fechaAlta = value;
            }
        }

        public DateTime FechaSalidaAcoes
        {
            get
            {
                return fechaSalidaAcoes;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set FechaSalidaAcoes = '" + value + "' where Codigo=" + Codigo + ";");
                fechaSalidaAcoes = value;
            }
        }

        public string Curso
        {
            get
            {
                return curso;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set Curso ='" + value + "' where Codigo=" + Codigo + ";");
                curso = value;
            }
        }

        public string ComunidadProc
        {
            get
            {
                return comunidadProc;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set ComunidadProc = '" + value + "' where Codigo=" + Codigo + ";");
                comunidadProc = value;
            }
        }

        public string ComunidadAct
        {
            get
            {
                return comunidadAct;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set ComunidadAct = '" + value + "' where Codigo=" + Codigo + ";");
                comunidadAct = value;
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
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Ninio set Observacioes = '" + value + "' where Codigo=" + Codigo + ";");
                observaciones = value;
            }
        }

        public void BorrarNinio()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Update("update Ninio set eliminado = 1 where codigo =" + Codigo + ";");
        }

    }
}