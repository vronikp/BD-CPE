using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contol_de_partes_y_equipos.Negocios
{
    class Dal_Savamento
    {
        Datos.Dat_Salvamento dSalvam = new Datos.Dat_Salvamento();
        Entidades.Salvamento salvamento = new Entidades.Salvamento();

        public TextBox llenarCodigo(TextBox codigo)
        {
            int c;
            string codigoText = dSalvam.llenar_codigo();
            c = Convert.ToInt32(codigoText);
            codigo.Text=c.ToString("000000");
            return codigo;
        }

        public ComboBox llenarReclamo(ComboBox reclamo)
        {
            reclamo.DataSource = dSalvam.llenar_cboReclamo();
            reclamo.ValueMember = "Reclamo_Codigo";
            reclamo.DisplayMember = "Reclamo_Numero";
            return reclamo;
        }

        public ComboBox llenarTaller(ComboBox taller)
        {
            taller.DataSource = dSalvam.llenar_cboTaller();
            taller.ValueMember = "Entidad_Codigo";
            taller.DisplayMember = "Entidad_NombreComercial";
            return taller;
        }

        public ComboBox llenarVehiculo(ComboBox vehiculo)
        {
            vehiculo.DataSource = dSalvam.llenar_cboVehiculo();
            vehiculo.ValueMember = "Vehiculo_Codigo";
            vehiculo.DisplayMember = "Vehiculo_Placa";
            return vehiculo;
        }

        public ComboBox llenarConjunto(ComboBox conjunto)
        {
            conjunto.DataSource = dSalvam.llenar_cboConjunto();
            conjunto.ValueMember = "Pardet_Secuencia";
            conjunto.DisplayMember = "Pardet_Descripcion";
            return conjunto;
        }

        public ComboBox llenarAccesorio(ComboBox accesorio, int conjunto)
        {
            accesorio.DataSource = dSalvam.llenar_cboAccesorio(conjunto);
            accesorio.ValueMember = "Pardet_Secuencia";
            accesorio.DisplayMember = "Pardet_Descripcion";
            return accesorio;
        }

        public ComboBox llenarMarca(ComboBox marca)
        {
            marca.DataSource = dSalvam.llenar_cboMarca();
            marca.ValueMember = "Pardet_Secuencia";
            marca.DisplayMember = "Pardet_Descripcion";
            return marca;
        }

        public void guardarSalvamento(string Salvam_Descripcion, string Salvam_Observacion, int Vehiculo_Codigo, int Parame_Conjunto, 
            int Pardet_Conjunto, int Parame_Accesorio, int Pardet_Accesorio, int Parame_Marca, int Pardet_Marca, 
            string Salvam_Modelo, string Salvam_Serie, int Reclamo_Codigo, int Taller_Codigo)
        {
            salvamento.Salvam_Descripcion = Salvam_Descripcion;
            salvamento.Salvam_Observacion = Salvam_Observacion;
            salvamento.Vehiculo_Codigo = Vehiculo_Codigo;
            salvamento.Parame_Conjunto = Parame_Conjunto;
            salvamento.Pardet_Conjunto = Pardet_Conjunto;
            salvamento.Parame_Accesorio = Parame_Accesorio;
            salvamento.Pardet_Accesorio = Pardet_Accesorio;
            salvamento.Parame_Marca = Parame_Marca;
            salvamento.Pardet_Marca = Pardet_Marca;
            salvamento.Salvam_Modelo = Salvam_Modelo;
            salvamento.Salvam_Serie = Salvam_Serie;
            salvamento.Reclamo_Codigo = Reclamo_Codigo;
            salvamento.Taller_Codigo = Taller_Codigo;
            salvamento.Usuario_Codigo = Program.usuario;
            salvamento.Salvam_FechaIngreso = DateTime.Now;

            try
            {
                dSalvam.guardarSalvamento(salvamento);
            }
            catch { throw; }
        }
    }
}
