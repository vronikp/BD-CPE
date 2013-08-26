using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Contol_de_partes_y_equipos
{
    public partial class frm_RprSalvamentos : Form
    {
        Negocios.Dal_Reclamo dalReclamo = new Negocios.Dal_Reclamo();
        Negocios.Dal_Savamento dSalvam = new Negocios.Dal_Savamento();

        public frm_RprSalvamentos()
        {
            InitializeComponent();
        }

        private void frm_RprSalvamentos_Load(object sender, EventArgs e)
        {
            dalReclamo.llenarCiaSeguros(cbo_CiaSeguros);
            dalReclamo.llenarRamo(cbo_Ramo);
            dalReclamo.llenarCobertura(cbo_Cobertura);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //frm_ReporteSalvamento rpt = new frm_ReporteSalvamento();
            //rpt.ciaSeguros = Convert.ToInt32(cbo_CiaSeguros.SelectedValue);
            //rpt.fechaInicio = dtp_FechaInicio.Value.ToString("yyyy-MM-dd");
            //rpt.fechaFin = dtp_FechaFin.Value.ToString("yyyy-MM-dd");
            //rpt.ShowDialog();
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:\\Users\\user\\Documents\\GitHub\\BD-CPE\\Contol de partes y equipos\\Contol de partes y equipos\\Reportes\\rpt_Salvamento.rpt");
            rpt.SetDataSource(verReporte());
            crystalReportViewer1.ReportSource = rpt;

        }

        public DataTable verReporte()
        {
            DataTable dt = new DataTable();
            dt = dSalvam.llenar_Reporte(Convert.ToInt32(cbo_CiaSeguros.SelectedValue), 
                dtp_FechaInicio.Value.ToString("yyyy-MM-dd"), dtp_FechaFin.Value.ToString("yyyy-MM-dd"),
                Convert.ToInt32(cbo_Ramo.SelectedValue), Convert.ToInt32(cbo_Cobertura.SelectedValue));
            return dt;
        }

        private void chk_RangoFechas_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_RangoFechas.Checked == true)
            {
                dtp_FechaFin.Visible = true;
                dtp_FechaInicio.Visible = true;
            }else{
                dtp_FechaFin.Visible = false;
                dtp_FechaInicio.Visible = false;
            }
        }
    }
}
