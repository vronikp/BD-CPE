﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contol_de_partes_y_equipos
{
    public partial class frm_Principal : Form
    {
        
        public static int codigo = -1;

        public frm_Principal()
        {
            InitializeComponent();
            
        }

        private void mi_ingresoReclamo_Click(object sender, EventArgs e)
        {
            frm_TransReclamo frm_IngReclamo = new frm_TransReclamo();
            frm_IngReclamo.MdiParent = this;
            frm_IngReclamo.Show();
        }

        private void mi_ingresoVehiculo_Click(object sender, EventArgs e)
        {
            frm_TransVehiculo frm_IngVehiculo = new frm_TransVehiculo();
            frm_IngVehiculo.MdiParent = this;
            frm_IngVehiculo.Show();
        }

        private void mi_ingresoSalvamento_Click(object sender, EventArgs e)
        {
            frm_TransSalvamento frm_IngSalvamento = new frm_TransSalvamento();
            frm_IngSalvamento.MdiParent = this;
            frm_IngSalvamento.Show();
        }

       
        private void mi_rprSalvamentoCia_Click(object sender, EventArgs e)
        {
            frm_RepSalvamentoPorCia frm_repSalvCia = new frm_RepSalvamentoPorCia();
            frm_repSalvCia.MdiParent = this;
            frm_repSalvCia.Show();
        }

        private void mi_rprSalvamentoReclamo_Click(object sender, EventArgs e)
        {
            frm_RepSalvamentoPorReclamo frm_repSalvReclamo = new frm_RepSalvamentoPorReclamo();
            frm_repSalvReclamo.MdiParent = this;
            frm_repSalvReclamo.Show();
        }

        private void mi_rprSalvamentoTaller_Click(object sender, EventArgs e)
        {
            frm_RepSalvamentoPorTaller frm_repSalvTaller = new frm_RepSalvamentoPorTaller();
            frm_repSalvTaller.MdiParent = this;
            frm_repSalvTaller.Show();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void mi_rprSalvamento_Click(object sender, EventArgs e)
        {
            frm_RprSalvamentos frm_rprSalv = new frm_RprSalvamentos();
            frm_rprSalv.MdiParent = this;
            frm_rprSalv.Show();
        }

        
    }
}
