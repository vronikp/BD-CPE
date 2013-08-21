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
    public partial class frm_IngresoReclamo : Form
    {
        Negocios.Dal_Reclamo dalReclamo = new Negocios.Dal_Reclamo();

        public frm_IngresoReclamo()
        {
            InitializeComponent();
        }

        private void frm_IngresoReclamo_Load(object sender, EventArgs e)
        {
            dalReclamo.llenarCiaSeguros(cbo_CiaSeguros);
            dalReclamo.llenarCobertura(cbo_Cobertura);
            dalReclamo.llenarRamo(cbo_Ramo);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                dalReclamo.guardarReclamo(txt_NoReclamo.Text, Convert.ToInt32(cbo_CiaSeguros.SelectedValue), Convert.ToInt32(cbo_Ramo.SelectedValue),
                    Convert.ToInt32(cbo_Cobertura.SelectedValue), txt_Cliente.Text, txt_Observacion.Text);
                MessageBox.Show("Reclamo guardado con exito");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



    }
}
