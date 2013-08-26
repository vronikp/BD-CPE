using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contol_de_partes_y_equipos
{
    public partial class frm_TransVehiculo : Form
    {
        Negocios.Dal_Vehiculo dalVehiculo = new Negocios.Dal_Vehiculo();

        public frm_TransVehiculo()
        {
            InitializeComponent();
        }

        private void frm_IngresoVehiculo_Load(object sender, EventArgs e)
        {
            dalVehiculo.llenarMarcaV(cbo_MarcaV);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                dalVehiculo.guardarVehiculo(txt_Placa.Text, Convert.ToInt32(cbo_MarcaV.SelectedValue), Convert.ToInt32(cbo_Modelo.SelectedValue),
                    Convert.ToInt32(cbo_Submodelo.SelectedValue), Convert.ToInt32(txt_Anio.Text), txt_NoMotor.Text, txt_Observacion.Text);
                MessageBox.Show("Vehiculo guardado con exito");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbo_MarcaV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int marcaV = Convert.ToInt32(cbo_MarcaV.SelectedValue);
            dalVehiculo.llenarModelo(cbo_Modelo, marcaV);
        }

        private void cbo_Modelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int modelo = Convert.ToInt32(cbo_Modelo.SelectedValue);
            dalVehiculo.llenarModelo(cbo_Submodelo, modelo);
        }
    }
}
