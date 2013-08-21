using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contol_de_partes_y_equipos.Negocios
{
    class Dal_Vehiculo
    {
        Datos.Dat_Vehiculo dVehiculo = new Datos.Dat_Vehiculo();
        Entidades.Vehiculo vehiculo = new Entidades.Vehiculo();

        public ComboBox llenarMarcaV(ComboBox marcaV)
        {
            marcaV.DataSource = dVehiculo.llenar_cboMarcaV();
            marcaV.ValueMember = "Pardet_Secuencia";
            marcaV.DisplayMember = "Pardet_Descripcion";
            return marcaV;
        }

        public ComboBox llenarModelo(ComboBox modelo, int marcaV)
        {
            modelo.DataSource = dVehiculo.llenar_cboModelo(marcaV);
            modelo.ValueMember = "Pardet_Secuencia";
            modelo.DisplayMember = "Pardet_Descripcion";
            return modelo;
        }

        public ComboBox llenarSubmodelo(ComboBox submodelo, int modelo)
        {
            submodelo.DataSource = dVehiculo.llenar_cboSubmodelo(modelo);
            submodelo.ValueMember = "Pardet_Secuencia";
            submodelo.DisplayMember = "Pardet_Descripcion";
            return submodelo;
        }

        public void guardarVehiculo(string Vehiculo_Placa, int Pardet_MarcaV, int Pardet_Modelo, int Pardet_SubModelo, 
            int Vehiculo_Anio, string Vehiculo_NoMotor, string Vehiculo_Observacion)
        {
            vehiculo.Vehiculo_Placa = Vehiculo_Placa;
            vehiculo.Parame_MarcaV = Program.parame_MarcaVehiculo;
            vehiculo.Pardet_MarcaV = Pardet_MarcaV;
            vehiculo.Parame_Modelo = Program.parame_Modelo;
            vehiculo.Pardet_Modelo = Pardet_Modelo;
            vehiculo.Parame_SubModelo = Program.parame_Submodelo;
            vehiculo.Pardet_SubModelo = Pardet_SubModelo;
            vehiculo.Vehiculo_Anio = Vehiculo_Anio;
            vehiculo.Vehiculo_NoMotor = Vehiculo_NoMotor;
            vehiculo.Vehiculo_Observacion = Vehiculo_Observacion;
            try
            {
                dVehiculo.guardarVehiculo(vehiculo);
            }
            catch { throw; }
        }
    }
}
