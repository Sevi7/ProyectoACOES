﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;
namespace ProyectoACOES
{
    class Proyecto
    {
        private int id;
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private string nombre;
        private TipoProyecto tipoproyecto;
        private Usuario coordinador;
        private Usuario responsable;
        private string localidad;
        private List<Socio> sociosparticipantes;
        private List<Beneficiario> beneficiarios;

        public Proyecto(string n, TipoProyecto tp, Usuario c, Usuario r, string l, List<Socio> socios, List<Beneficiario> bf)
        {
            SQLSERVERDB bd = new SQLSERVERDB (BD_SERVER,BD_NAME);
            bd.Insert("INSERT into Proyecto values ('"+n+"','"+tp.nombre_tipoproyecto+"','"+c.nif_usuario+"','"+r.nif_usuario+"','"+l+"')");
            id=Int32.Parse(bd.Select("SELECT MAX (id) FROM Proyecto;")[0][0].ToString());
            /*
            foreach(Socio s in socios){
                
            }
            */

            foreach(Beneficiario b in bf)
            {
                bd.Update("UPDATE Beneficiario set proyecto=" + id + " where codigo=" + b.codigo_Beneficiario + ";");
            }
            nombre=n;
            tipoproyecto=tp;
            coordinador=c;
            responsable=r;
            localidad=l;
            sociosparticipantes=socios;
            beneficiarios=bf;
        }

    }
}
