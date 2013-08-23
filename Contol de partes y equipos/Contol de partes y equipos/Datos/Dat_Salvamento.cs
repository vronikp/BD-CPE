using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Contol_de_partes_y_equipos.Datos
{
    class Dat_Salvamento
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["miCadenaConexion"].ConnectionString;

        public string llenar_codigo()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Salvamento", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "codigo");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows[0][0].ToString();
        }

        public DataTable llenar_cboReclamo(){
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Salvamento",conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion","cr");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable llenar_cboTaller()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Salvamento", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "ct");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable llenar_cboVehiculo()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Salvamento", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "cv");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable llenar_cboConjunto()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Salvamento", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "cc");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable llenar_cboAccesorio(int conjunto)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Salvamento", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "ca");
            cmd.Parameters.AddWithValue("@pardet_Conjunto",conjunto);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable llenar_cboMarca()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Salvamento", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "cm");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void guardarSalvamento(Entidades.Salvamento salvamento)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("proc_Salvamento", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "i");
            cmd.Parameters.AddWithValue("@Salvam_Descripcion",salvamento.Salvam_Descripcion);
            cmd.Parameters.AddWithValue("@Salvam_Observacion", salvamento.Salvam_Observacion);
            cmd.Parameters.AddWithValue("@Vehiculo_Codigo", salvamento.Vehiculo_Codigo);
            cmd.Parameters.AddWithValue("@Parame_Conjunto", salvamento.Parame_Conjunto);
            cmd.Parameters.AddWithValue("@Pardet_Conjunto", salvamento.Pardet_Conjunto);
            cmd.Parameters.AddWithValue("@Parame_Accesorio", salvamento.Parame_Accesorio);
            cmd.Parameters.AddWithValue("@Pardet_Accesorio", salvamento.Pardet_Accesorio);
            cmd.Parameters.AddWithValue("@Parame_Marca", salvamento.Parame_Marca);
            cmd.Parameters.AddWithValue("@Pardet_Marca", salvamento.Pardet_Marca);
            cmd.Parameters.AddWithValue("@Salvam_Modelo", salvamento.Salvam_Modelo);
            cmd.Parameters.AddWithValue("@Salvam_Serie", salvamento.Salvam_Serie);
            cmd.Parameters.AddWithValue("@Reclamo_Codigo", salvamento.Reclamo_Codigo);
            cmd.Parameters.AddWithValue("@Taller_Codigo", salvamento.Taller_Codigo);
            cmd.Parameters.AddWithValue("@Usuario_Codigo", salvamento.Usuario_Codigo);
            cmd.Parameters.AddWithValue("@Salvam_FechaIngreso", salvamento.Salvam_FechaIngreso);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch { throw; }
        }

        public DataTable llenar_Reporte(int ciaSeguros, string fechaInicio, string fechaFin)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Salvamento", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "rs");
            cmd.Parameters.AddWithValue("@CiaSeguros_Codigo", ciaSeguros);
            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

    }
}
