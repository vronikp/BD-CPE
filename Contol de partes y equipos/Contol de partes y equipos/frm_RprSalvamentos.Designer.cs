namespace Contol_de_partes_y_equipos
{
    partial class frm_RprSalvamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbo_CiaSeguros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaFin = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.chk_RangoFechas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Ramo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_Cobertura = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbo_CiaSeguros
            // 
            this.cbo_CiaSeguros.FormattingEnabled = true;
            this.cbo_CiaSeguros.Location = new System.Drawing.Point(169, 12);
            this.cbo_CiaSeguros.Name = "cbo_CiaSeguros";
            this.cbo_CiaSeguros.Size = new System.Drawing.Size(268, 25);
            this.cbo_CiaSeguros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compañia de Seguros";
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.Location = new System.Drawing.Point(549, 45);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(80, 17);
            this.lbl_FechaInicio.TabIndex = 2;
            this.lbl_FechaInicio.Text = "Fecha inicio";
            this.lbl_FechaInicio.Visible = false;
            // 
            // dtp_FechaInicio
            // 
            this.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaInicio.Location = new System.Drawing.Point(706, 39);
            this.dtp_FechaInicio.Name = "dtp_FechaInicio";
            this.dtp_FechaInicio.Size = new System.Drawing.Size(129, 24);
            this.dtp_FechaInicio.TabIndex = 3;
            this.dtp_FechaInicio.Visible = false;
            // 
            // dtp_FechaFin
            // 
            this.dtp_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaFin.Location = new System.Drawing.Point(706, 69);
            this.dtp_FechaFin.Name = "dtp_FechaFin";
            this.dtp_FechaFin.Size = new System.Drawing.Size(129, 24);
            this.dtp_FechaFin.TabIndex = 4;
            this.dtp_FechaFin.Visible = false;
            // 
            // lbl_FechaFin
            // 
            this.lbl_FechaFin.AutoSize = true;
            this.lbl_FechaFin.Location = new System.Drawing.Point(549, 75);
            this.lbl_FechaFin.Name = "lbl_FechaFin";
            this.lbl_FechaFin.Size = new System.Drawing.Size(64, 17);
            this.lbl_FechaFin.TabIndex = 5;
            this.lbl_FechaFin.Text = "Fecha fin";
            this.lbl_FechaFin.Visible = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-1, 117);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1047, 503);
            this.crystalReportViewer1.TabIndex = 8;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Image = global::Contol_de_partes_y_equipos.Properties.Resources.accept1;
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Aceptar.Location = new System.Drawing.Point(961, 12);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(41, 43);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // chk_RangoFechas
            // 
            this.chk_RangoFechas.AutoSize = true;
            this.chk_RangoFechas.Location = new System.Drawing.Point(539, 14);
            this.chk_RangoFechas.Name = "chk_RangoFechas";
            this.chk_RangoFechas.Size = new System.Drawing.Size(164, 21);
            this.chk_RangoFechas.TabIndex = 9;
            this.chk_RangoFechas.Text = "En un rango de fechas";
            this.chk_RangoFechas.UseVisualStyleBackColor = true;
            this.chk_RangoFechas.CheckedChanged += new System.EventHandler(this.chk_RangoFechas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ramo";
            // 
            // cbo_Ramo
            // 
            this.cbo_Ramo.FormattingEnabled = true;
            this.cbo_Ramo.Location = new System.Drawing.Point(169, 45);
            this.cbo_Ramo.Name = "cbo_Ramo";
            this.cbo_Ramo.Size = new System.Drawing.Size(268, 25);
            this.cbo_Ramo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cobertura";
            // 
            // cbo_Cobertura
            // 
            this.cbo_Cobertura.FormattingEnabled = true;
            this.cbo_Cobertura.Location = new System.Drawing.Point(169, 76);
            this.cbo_Cobertura.Name = "cbo_Cobertura";
            this.cbo_Cobertura.Size = new System.Drawing.Size(268, 25);
            this.cbo_Cobertura.TabIndex = 12;
            // 
            // frm_RprSalvamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 620);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_Cobertura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_Ramo);
            this.Controls.Add(this.chk_RangoFechas);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_FechaFin);
            this.Controls.Add(this.dtp_FechaFin);
            this.Controls.Add(this.dtp_FechaInicio);
            this.Controls.Add(this.lbl_FechaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_CiaSeguros);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_RprSalvamentos";
            this.Text = "Reporte de Salvamentos";
            this.Load += new System.EventHandler(this.frm_RprSalvamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_CiaSeguros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_FechaInicio;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicio;
        private System.Windows.Forms.DateTimePicker dtp_FechaFin;
        private System.Windows.Forms.Label lbl_FechaFin;
        private System.Windows.Forms.Button btn_Aceptar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.CheckBox chk_RangoFechas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Ramo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_Cobertura;
    }
}