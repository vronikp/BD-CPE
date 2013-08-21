using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Contol_de_partes_y_equipos.Datos
{
    class Dat_Entidad
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["miCadenaConexion"].ConnectionString;


    }
}
