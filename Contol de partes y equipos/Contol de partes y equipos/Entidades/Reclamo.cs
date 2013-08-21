using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contol_de_partes_y_equipos.Entidades
{
    class Reclamo
    {
        public int Reclamo_Codigo {get;set;}
        public string Reclamo_Numero {get;set;}
        public int CiaSeguros_Codigo {get;set;}
        public int Parame_Ramo {get;set;}
        public int Pardet_Ramo {get;set;}
        public int Parame_Cobertura {get;set;}
        public int Pardet_Cobertura {get;set;}
        public string Reclamo_Cliente { get; set; }
        public string Reclamo_Observacion { get; set; }
    }
}
