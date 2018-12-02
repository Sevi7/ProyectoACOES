using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoACOES
{
    class Proyecto
    {
        private string nombre;
        private TipoProyecto tipoproyecto;
        private (algo) coordinador;
        private (algo) responsable;
        private (algo) localidad;
        private List<Socio> sociosparticipantes;
        private List<Beneficiario> beneficiarios;

        public Proyecto(string n, TipoProyecto tp, (algo) c, (algo) r, (algo) l, List<Socio> socios, List<Beneficiario> b)
        {
            nombre=n;
            TipoProyecto=tp;
            coordinador=c;
            responsable=r;
            localidad=l;
            sociosparticipantes=socios;
            beneficiarios=b;
        }

    }
}
