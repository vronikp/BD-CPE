using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Contol_de_partes_y_equipos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public static string usuario;
        public static int parame_TipoEntidad = 100;
        public static int parame_Ramo = 101;
        public static int parame_Cobertura = 102;
        public static int parame_Ciudad = 103;
        public static int parame_Marca = 200;
        public static int parame_MarcaVehiculo = 301;
        public static int parame_Modelo = 302;
        public static int parame_Submodelo = 303;
        public static int parame_Conjunto = 401;
        public static int parame_Accesorio = 402;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_InicioSesion());
        }
    }
}
