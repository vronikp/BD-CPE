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
        public frm_IngresoSalvamento()
        {
            InitializeComponent();
        }

        private void frm_IngresoSalvamento_Load(object sender, EventArgs e)
        {

        }

        private void chk_vehiculo_CheckedChanged(object sender, EventArgs e)
        {
            cbo_vehiculo.Visible = true;
        }

        
    }
}
