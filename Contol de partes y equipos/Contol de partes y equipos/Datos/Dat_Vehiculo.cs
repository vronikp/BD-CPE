using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Contol_de_partes_y_equipos.Datos
{
    class Dat_Vehiculo
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["miCadenaConexion"].ConnectionString;

        public DataTable llenar_cboMarcaV()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Vehiculo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "cmv");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable llenar_cboModelo(int marcaV)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Vehiculo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "cm");
            cmd.Parameters.AddWithValue("@pardet_MarcaV", marcaV);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable llenar_cboSubmodelo(int modelo)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("proc_Vehiculo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "cs");
            cmd.Parameters.AddWithValue("@pardet_Modelo", modelo);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void guardarVehiculo(Entidades.Vehiculo vehiculo)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("proc_Vehiculo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accion", "i");
            cmd.Parameters.AddWithValue("@Vehiculo_Placa", vehiculo.Vehiculo_Placa);
            cmd.Parameters.AddWithValue("@Parame_MarcaV", vehiculo.Parame_MarcaV);
            cmd.Parameters.AddWithValue("@Pardet_MarcaV", vehiculo.Pardet_MarcaV);
            cmd.Parameters.AddWithValue("@Parame_Modelo", vehiculo.Parame_Modelo);
            cmd.Parameters.AddWithValue("@Pardet_Modelo", vehiculo.Pardet_Modelo);
            cmd.Parameters.AddWithValue("@Parame_SubModelo", vehiculo.Parame_SubModelo);
            cmd.Parameters.AddWithValue("@Pardet_SubModelo", vehiculo.Pardet_SubModelo);
            cmd.Parameters.AddWithValue("@Vehiculo_Anio", vehiculo.Vehiculo_Anio);
            cmd.Parameters.AddWithValue("@Vehiculo_NoMotor", vehiculo.Vehiculo_NoMotor);
            cmd.Parameters.AddWithValue("@Vehiculo_Observacion", vehiculo.Vehiculo_Observacion);

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
