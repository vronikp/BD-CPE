using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Contol_de_partes_y_equipos
{
    public partial class frm_InicioSesion : Form
    {
        string miCadenaConexion = ConfigurationManager.ConnectionStrings["miCadenaConexion"].ConnectionString;

        public frm_InicioSesion()
        {
            InitializeComponent();

        }

        private void frm_InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (verificaUsuario(text_usuario.Text, text_clave.Text))
            {
                this.Hide();
                frm_Principal frmPrincipal = new frm_Principal();
                frmPrincipal.Show();
            }
        }

        private bool verificaUsuario(String usuario, String contraseña)
        {
            SqlConnection conexion = new SqlConnection(miCadenaConexion);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Usuario WHERE Usuario_Codigo = '" +usuario + "' AND Usuario_Clave = '" + contraseña + "'", conexion);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("Usuario y/o clave incorrectos", "Error de inicio de sesion");
                return false;
            } /*else 
            {
                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Usuario_Activo FROM Usuario WHERE Usuario_Codigo = '" + usuario + "' AND Usuario_Clave = '" + contraseña + "'", conexion);
                DataTable dt2 = new DataTable();
                if (dt2.Rows[0][0].ToString() == "False")
                {
                    MessageBox.Show("Usuario inactivo. Solicite permisos al administrador.", "Error de inicio de sesion");
                    return false;
                }
            }*/
            return true;
        }
    }
}
