using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;


namespace ProyectoACOES
{
    public class Beneficiario
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int codigo;
        private string nombre;
        private string apellidos;
        private string estado;
        private string beca;
        private string sexo;
        private Agente agente;
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

        public Beneficiario(int c)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("select * from Beneficiario where Codigo = " + c + ";")[0];

            codigo = c;
            nombre = (string)tupla[1];
            if (tupla[2] != DBNull.Value) apellidos = (string)tupla[2];
            if (tupla[3] != DBNull.Value) estado = (string)tupla[3];
            if (tupla[4] != DBNull.Value) beca = (string)tupla[4];
            sexo = (string)tupla[5];
            if(tupla[6] != DBNull.Value) agente = new Agente(Convert.ToInt32(tupla[6]));
            if(tupla[7] != DBNull.Value) fechaNacimiento = Convert.ToDateTime(tupla[7]);
            if(tupla[8] != DBNull.Value) fechaEntradaAcoes = Convert.ToDateTime(tupla[8]);
            if(tupla[9] != DBNull.Value) proyecto = tupla[9].ToString();
            if(tupla[10] != DBNull.Value) fechaEntradaProyecto = Convert.ToDateTime(tupla[10]);
            if(tupla[11] != DBNull.Value) fechaSalidaProyecto = Convert.ToDateTime(tupla[11]);
            if(tupla[12] != DBNull.Value) fechaAlta = Convert.ToDateTime(tupla[12]);
            if(tupla[13] != DBNull.Value) fechaSalidaAcoes = Convert.ToDateTime(tupla[13]);
            if(tupla[14] != DBNull.Value) curso = (string)tupla[14];
            if(tupla[15] != DBNull.Value) comunidadProc = (string)tupla[15];
            if(tupla[16] != DBNull.Value) comunidadAct = (string)tupla[16];
            if(tupla[17] != DBNull.Value) observaciones = (string)tupla[17];
        }
        
        public Beneficiario(string n, string ap, string e, string b, string s, Agente a, 
            DateTime fN, DateTime fEA, string p, DateTime fEP, DateTime fSP, DateTime fA, DateTime fSA, string co, string cP,
            string cA, string o)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            if (a == null && p!="")
            {
                miBD.Insert("insert into Beneficiario values('" + n + "', '" + ap + "','" + e + "','" + b + "','" + s + "',null,'" + fN.ToString("yyyy - MM - dd") + "','" +
               fEA.ToString("yyyy-MM-dd") + "'," + Int32.Parse(p) + ",'" + fEP.ToString("yyyy-MM-dd") + "','" + fSP.ToString("yyyy-MM-dd") + "','" + fA.ToString("yyyy - MM - dd") + "', '" +
               fSA.ToString("yyyy-MM-dd") + "','" + co + "','" + cP + "','" + cA + "','" + o + "');");
            }
            else if(p == "" && a==null)
            {
                miBD.Insert("insert into Beneficiario values('" + n + "', '" + ap + "','" + e + "','" + b + "','" + s + "',null,'" + fN.ToString("yyyy - MM - dd") + "','" +
               fEA.ToString("yyyy-MM-dd") + "',null,'" + fEP.ToString("yyyy-MM-dd") + "','" + fSP.ToString("yyyy-MM-dd") + "','" + fA.ToString("yyyy - MM - dd") +"', '"+
               fSA.ToString("yyyy-MM-dd") + "','" + co + "','" + cP + "','" + cA + "','" + o + "');");
            }else if(p=="" && a != null)
            {
                miBD.Insert("insert into Beneficiario values('" + n + "', '" + ap + "','" + e + "','" + b + "','" + s + "'," + a.Codigo + ",'" + fN.ToString("yyyy - MM - dd") + "','" +
                fEA.ToString("yyyy-MM-dd") + "',null,'" + fEP.ToString("yyyy-MM-dd") + "','" + fSP.ToString("yyyy-MM-dd") + "','" + fA.ToString("yyyy - MM - dd") + "', '" +
                fSA.ToString("yyyy-MM-dd") + "','" + co + "','" + cP + "','" + cA + "','" + o + "');");
            }
            else
            {
                miBD.Insert("insert into Beneficiario values('" + n + "', '" + ap + "','" + e + "','" + b + "','" + s + "','" + a.Codigo + "','" + fN.ToString("yyyy - MM - dd") + "','" +
               fEA.ToString("yyyy-MM-dd") + "','" + Int32.Parse(p) + "','" + fEP.ToString("yyyy-MM-dd") + "','" + fSP.ToString("yyyy-MM-dd") + "','" + fA.ToString("yyyy - MM - dd") + "', '" +
               fSA.ToString("yyyy-MM-dd") + "','" + co + "','" + cP + "','" + cA + "','" + o + "');");
            }

            codigo = Convert.ToInt32(miBD.Select("select max(Codigo) from Beneficiario;")[0][0]);
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

        public int codigo_Beneficiario
        {
            get
            {
                return codigo;
            }
        }

        public string nombre_Beneficiario
        {
            get
            {
                return nombre;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set Nombre = '" + value + "' where Codigo=" + codigo + ";");
                nombre = value;
            }
        }

        public string apellidos_Beneficiario
        {
            get
            {
                return apellidos;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set Apellidos = '" + value + "' where Codigo=" + codigo + ";");
                apellidos = value;
            }
        }

        public string estado_Beneficiario
        {
            get
            {
                return estado;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set Nombre = '" + value + "' where Codigo=" + codigo + ";");
                estado = value;
            }
        }

        public string beca_Beneficiario
        {
            get
            {
                return beca;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set Beca = '" + value + "' where Codigo=" + codigo + ";");
                beca = value;
            }
        }

        public string sexo_Beneficiario
        {
            get
            {
                return sexo;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set Sexo = '" + value + "' where Codigo=" + codigo + ";");
                sexo = value;
            }
        }

        public Agente agente_Beneficiario
        {
            get
            {
                return agente;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set Agente = '" + value.Codigo + "' where Codigo=" + codigo + ";");
                agente = value;
            }
        }

        public DateTime fechaNacimiento_Beneficiario
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set FechaNacimiento = '" + value + "' where Codigo=" + codigo + ";");
                fechaNacimiento = value;
            }
        }

        public DateTime fechaEntradaAcoes_Beneficiario
        {
            get
            {
                return fechaEntradaAcoes;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set FechaEntradaAcoes = '" + value + "' where Codigo=" + codigo + ";");
                fechaEntradaAcoes = value;
            }
        }

        public string proyecto_Beneficiario
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
                    miBD.Update("update Beneficiario set Proyecto = " + Int32.Parse(value) + " where Codigo=" + codigo + ";");
                    proyecto = value;
                }

            }
        }

        public DateTime fechaEntradaProyecto_Beneficiario
        {
            get
            {
                return fechaEntradaProyecto;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set FechaEntradaProyecto = '" + value + "' where Codigo=" + codigo + ";");
                fechaEntradaProyecto = value;
            }
        }

        public DateTime fechaSalidaProyecto_Beneficiario
        {
            get
            {
                return fechaSalidaProyecto;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set FechaSalidaProyecto = '" + value + "' where Codigo=" + codigo + ";");
                fechaSalidaProyecto = value;
            }
        }

        public DateTime fechaAlta_Beneficiario
        {
            get
            {
                return fechaAlta;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set FechaAlta = '" + value + "' where Codigo=" + codigo + ";");
                fechaAlta = value;
            }
        }

        public DateTime fechaSalidaAcoes_Beneficiario
        {
            get
            {
                return fechaSalidaAcoes;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set FechaSalidaAcoes = '" + value + "' where Codigo=" + codigo + ";");
                fechaSalidaAcoes = value;
            }
        }

        public string curso_Beneficiario
        {
            get
            {
                return curso;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set Curso = " + Int32.Parse(value) + " where Codigo=" + codigo + ";");
                curso = value;
            }
        }

        public string comunidadProc_Beneficiario
        {
            get
            {
                return comunidadProc;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set ComunidadProc = '" + value + "' where Codigo=" + codigo + ";");
                comunidadProc = value;
            }
        }

        public string comunidadAct_Beneficiario
        {
            get
            {
                return comunidadAct;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set ComunidadAct = '" + value + "' where Codigo=" + codigo + ";");
                comunidadAct = value;
            }
        }

        public string observaciones_Beneficiario
        {
            get
            {
                return observaciones;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("update Beneficiario set Observacioes = '" + value + "' where Codigo=" + codigo + ";");
                observaciones = value;
            }
        }

        public void BorrarPaciente()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("delete Beneficiario where Codigo =" + codigo + ";");

            codigo = -1;
            nombre = null;
            apellidos = null;
            estado = null;
            beca = null;
            sexo = null;
            agente = null;
            proyecto = null;           
            curso = null;
            comunidadProc = null;
            comunidadAct = null;
            observaciones = null;
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
