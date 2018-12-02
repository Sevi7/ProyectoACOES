using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoACOES
{
    class TipoProyecto
    {
        private string nombre;
        private string descripcion;
        private (algo) coordinador;
        private (algo) responsable;
        private List<Socio> sociosdonantes;

        public TipoProyecto(string n, string d, (algo) c, (algo) r, List<Socio> socios)
        {
            nombre=n;
            descripcion=d;
            coordinador=c;
            responsable=r;
            sociosdonantes=socios;
        }

        public void añadirSociosTipoProyecto(List<Socio> socios)
        {
            sociosdonantes=socios;
        }

        public void añadirSocioTipoProyecto (string NIF)
        {
            sociosdonantes.Add(new Socio(NIF));
        }




    }
}
