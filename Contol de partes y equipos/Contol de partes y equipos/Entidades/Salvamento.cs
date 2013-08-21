using System;
using System.Collections.Generic;
using System.Text;

namespace Contol_de_partes_y_equipos.Entidades
{
    class Salvamento
    {
        public int Salvam_Codigo {get; set;}
        public string Salvam_Descripcion {get; set;}
	    public string Salvam_Observacion {get; set;}
        public int Vehiculo_Codigo {get; set;}
        public int Parame_Conjunto { get; set; }
        public int Pardet_Conjunto { get; set; }
        public int Parame_Accesorio { get; set; }
        public int Pardet_Accesorio { get; set; }
        public int Parame_Marca {get; set;}
	    public int Pardet_Marca {get; set;}
	    public string Salvam_Modelo {get; set;}
	    public string Salvam_Serie {get; set;}
	    public int Reclamo_Codigo {get; set;}
	    public int Taller_Codigo {get; set;}
	    public string Usuario_Codigo {get; set;}
        public DateTime Salvam_FechaIngreso { get; set; }
    }
}
