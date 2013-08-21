using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Contol_de_partes_y_equipos.Datos
{
    class Dat_Reclamo
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["miCadenaConexion"].ConnectionString;

        public DataTable llenar_cboCiaSeguros()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Reclamo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "ccs");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable llenar_cboRamo()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Reclamo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "cr");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable llenar_cboCobertura()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Reclamo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "cc");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void guardarReclamo(Entidades.Reclamo reclamo)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("proc_Reclamo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "i");
            cmd.Parameters.AddWithValue("@Reclamo_Numero", reclamo.Reclamo_Numero);
            cmd.Parameters.AddWithValue("@CiaSeguros_Codigo", reclamo.CiaSeguros_Codigo);
            cmd.Parameters.AddWithValue("@Parame_Ramo", reclamo.Parame_Ramo);
            cmd.Parameters.AddWithValue("@Pardet_Ramo", reclamo.Pardet_Ramo);
            cmd.Parameters.AddWithValue("@Parame_Cobertura", reclamo.Parame_Cobertura);
            cmd.Parameters.AddWithValue("@Pardet_Cobertura", reclamo.Pardet_Cobertura);
            cmd.Parameters.AddWithValue("@Reclamo_Cliente", reclamo.Reclamo_Cliente);
            cmd.Parameters.AddWithValue("@Reclamo_Observacion", reclamo.Reclamo_Observacion);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch { throw; }
        }
    }
}
