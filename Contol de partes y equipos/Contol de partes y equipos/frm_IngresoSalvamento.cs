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
    public partial class frm_IngresoSalvamento : Form

    {
        Negocios.Dal_Savamento dalSalvam = new Negocios.Dal_Savamento();

        public frm_IngresoSalvamento()
        {
            InitializeComponent();
        }

        private void frm_IngresoSalvamento_Load(object sender, EventArgs e)
        {
            dalSalvam.llenarReclamo(cbo_Reclamo);
            dalSalvam.llenarTaller(cbo_Taller);
            dalSalvam.llenarCodigo(txt_Codigo);
            dalSalvam.llenarVehiculo(cbo_vehiculo);
            dalSalvam.llenarConjunto(cbo_Conjunto);
            dalSalvam.llenarMarca(cbo_Marca);
            
        }

        private void chk_vehiculo_CheckedChanged(object sender, EventArgs e)
        {
            cbo_vehiculo.Visible = true;
        }

        private void cbo_Conjunto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int conjunto = Convert.ToInt32(cbo_Conjunto.SelectedValue);
            dalSalvam.llenarAccesorio(cbo_Accesorio,conjunto);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                dalSalvam.guardarSalvamento(txt_Descripcion.Text, txt_Observacion.Text, Convert.ToInt32(cbo_vehiculo.SelectedValue), 
                    Program.parame_Conjunto,  Convert.ToInt32(cbo_Conjunto.SelectedValue), Program.parame_Accesorio,
                    Convert.ToInt32(cbo_Accesorio.SelectedValue), Program.parame_Marca, Convert.ToInt32(cbo_Marca.SelectedValue),
                    txt_Modelo.Text, txt_NoSerie.Text, Convert.ToInt32(cbo_Reclamo.SelectedValue), Convert.ToInt32(cbo_Taller.SelectedValue));
                MessageBox.Show("Salvamento guardado con exito");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString());}
        }

        
    }
}
