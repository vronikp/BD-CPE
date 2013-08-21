using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contol_de_partes_y_equipos.Entidades
{
    class Entidad
    {
        public int Entidad_Codigo {get; set;}
        public string Entidad_Ruc{get; set;}
        public string Entidad_RazonSocial{get; set;}
        public string Entidad_NombreComercial {get; set;}
        public string Entidad_Telefono {get; set;}
        public string Entidad_NombreContacto {get; set;}
        public int Parame_Ciudad {get; set;}
        public int Pardet_Ciudad {get; set;}
        public int Parame_TipoEnt {get; set;}
        public int Pardet_TipoEnt {get; set;}
    }
}
