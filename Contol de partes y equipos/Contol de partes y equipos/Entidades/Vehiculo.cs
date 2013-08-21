using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contol_de_partes_y_equipos.Entidades
{
    class Vehiculo
    {
        public int Vehiculo_Codigo {get;set;}
        public string Vehiculo_Placa {get;set;}
        public int Parame_MarcaV {get;set;}
        public int Pardet_MarcaV {get;set;}
        public int Parame_Modelo {get;set;}
        public int Pardet_Modelo {get;set;}
        public int Parame_SubModelo {get;set;}
        public int Pardet_SubModelo {get;set;}
        public int Vehiculo_Anio {get;set;}
        public string Vehiculo_NoMotor {get;set;}
        public string Vehiculo_Observacion {get;set;}
    }
}
