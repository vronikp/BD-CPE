namespace Contol_de_partes_y_equipos
{
    partial class frm_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_ingreso = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ingresoReclamo = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ingresoVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ingresoSalvamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_mantRamo = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_mantCiaSeguros = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_mantTaller = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_mantCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_rprSalvamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_rprSalvamentoCia = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_rprSalvamentoReclamo = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_rprSalvamentoTaller = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_rprCia = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_rprTaller = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ayudaAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ayudaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_mantCobertura = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_ingreso,
            this.mi_mantenimiento,
            this.mi_reportes,
            this.mi_ayuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(735, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_ingreso
            // 
            this.mi_ingreso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_ingresoReclamo,
            this.mi_ingresoVehiculo,
            this.mi_ingresoSalvamento});
            this.mi_ingreso.Name = "mi_ingreso";
            this.mi_ingreso.Size = new System.Drawing.Size(58, 20);
            this.mi_ingreso.Text = "Ingreso";
            // 
            // mi_ingresoReclamo
            // 
            this.mi_ingresoReclamo.Name = "mi_ingresoReclamo";
            this.mi_ingresoReclamo.Size = new System.Drawing.Size(152, 22);
            this.mi_ingresoReclamo.Text = "Reclamo";
            this.mi_ingresoReclamo.Click += new System.EventHandler(this.mi_ingresoReclamo_Click);
            // 
            // mi_ingresoVehiculo
            // 
            this.mi_ingresoVehiculo.Name = "mi_ingresoVehiculo";
            this.mi_ingresoVehiculo.Size = new System.Drawing.Size(152, 22);
            this.mi_ingresoVehiculo.Text = "Vehiculo";
            this.mi_ingresoVehiculo.Click += new System.EventHandler(this.mi_ingresoVehiculo_Click);
            // 
            // mi_ingresoSalvamento
            // 
            this.mi_ingresoSalvamento.Name = "mi_ingresoSalvamento";
            this.mi_ingresoSalvamento.Size = new System.Drawing.Size(152, 22);
            this.mi_ingresoSalvamento.Text = "Parte o equipo";
            this.mi_ingresoSalvamento.Click += new System.EventHandler(this.mi_ingresoSalvamento_Click);
            // 
            // mi_mantenimiento
            // 
            this.mi_mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_mantCobertura,
            this.mi_mantRamo,
            this.mi_mantCiaSeguros,
            this.mi_mantTaller,
            this.mi_mantCiudad,
            this.marcaToolStripMenuItem,
            this.vehiculosToolStripMenuItem});
            this.mi_mantenimiento.Name = "mi_mantenimiento";
            this.mi_mantenimiento.Size = new System.Drawing.Size(101, 20);
            this.mi_mantenimiento.Text = "Mantenimiento";
            // 
            // mi_mantRamo
            // 
            this.mi_mantRamo.Name = "mi_mantRamo";
            this.mi_mantRamo.Size = new System.Drawing.Size(189, 22);
            this.mi_mantRamo.Text = "Ramo";
            this.mi_mantRamo.Click += new System.EventHandler(this.mi_mantRamo_Click);
            // 
            // mi_mantCiaSeguros
            // 
            this.mi_mantCiaSeguros.Name = "mi_mantCiaSeguros";
            this.mi_mantCiaSeguros.Size = new System.Drawing.Size(189, 22);
            this.mi_mantCiaSeguros.Text = "Compañia de seguros";
            this.mi_mantCiaSeguros.Click += new System.EventHandler(this.mi_mantCiaSeguros_Click);
            // 
            // mi_mantTaller
            // 
            this.mi_mantTaller.Name = "mi_mantTaller";
            this.mi_mantTaller.Size = new System.Drawing.Size(189, 22);
            this.mi_mantTaller.Text = "Taller";
            this.mi_mantTaller.Click += new System.EventHandler(this.mi_mantTaller_Click);
            // 
            // mi_mantCiudad
            // 
            this.mi_mantCiudad.Name = "mi_mantCiudad";
            this.mi_mantCiudad.Size = new System.Drawing.Size(189, 22);
            this.mi_mantCiudad.Text = "Ciudad";
            this.mi_mantCiudad.Click += new System.EventHandler(this.mi_mantCiudad_Click);
            // 
            // mi_reportes
            // 
            this.mi_reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_rprSalvamento,
            this.mi_rprCia,
            this.mi_rprTaller});
            this.mi_reportes.Name = "mi_reportes";
            this.mi_reportes.Size = new System.Drawing.Size(65, 20);
            this.mi_reportes.Text = "Reportes";
            // 
            // mi_rprSalvamento
            // 
            this.mi_rprSalvamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_rprSalvamentoCia,
            this.mi_rprSalvamentoReclamo,
            this.mi_rprSalvamentoTaller});
            this.mi_rprSalvamento.Name = "mi_rprSalvamento";
            this.mi_rprSalvamento.Size = new System.Drawing.Size(152, 22);
            this.mi_rprSalvamento.Text = "Salvamentos";
            // 
            // mi_rprSalvamentoCia
            // 
            this.mi_rprSalvamentoCia.Name = "mi_rprSalvamentoCia";
            this.mi_rprSalvamentoCia.Size = new System.Drawing.Size(152, 22);
            this.mi_rprSalvamentoCia.Text = "Por compañia";
            this.mi_rprSalvamentoCia.Click += new System.EventHandler(this.mi_rprSalvamentoCia_Click);
            // 
            // mi_rprSalvamentoReclamo
            // 
            this.mi_rprSalvamentoReclamo.Name = "mi_rprSalvamentoReclamo";
            this.mi_rprSalvamentoReclamo.Size = new System.Drawing.Size(152, 22);
            this.mi_rprSalvamentoReclamo.Text = "Por reclamo";
            this.mi_rprSalvamentoReclamo.Click += new System.EventHandler(this.mi_rprSalvamentoReclamo_Click);
            // 
            // mi_rprSalvamentoTaller
            // 
            this.mi_rprSalvamentoTaller.Name = "mi_rprSalvamentoTaller";
            this.mi_rprSalvamentoTaller.Size = new System.Drawing.Size(152, 22);
            this.mi_rprSalvamentoTaller.Text = "Por taller";
            this.mi_rprSalvamentoTaller.Click += new System.EventHandler(this.mi_rprSalvamentoTaller_Click);
            // 
            // mi_rprCia
            // 
            this.mi_rprCia.Name = "mi_rprCia";
            this.mi_rprCia.Size = new System.Drawing.Size(152, 22);
            this.mi_rprCia.Text = "Compañias";
            // 
            // mi_rprTaller
            // 
            this.mi_rprTaller.Name = "mi_rprTaller";
            this.mi_rprTaller.Size = new System.Drawing.Size(152, 22);
            this.mi_rprTaller.Text = "Talleres";
            // 
            // mi_ayuda
            // 
            this.mi_ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_ayudaAyuda,
            this.mi_ayudaAcercaDe});
            this.mi_ayuda.Name = "mi_ayuda";
            this.mi_ayuda.Size = new System.Drawing.Size(53, 20);
            this.mi_ayuda.Text = "Ayuda";
            // 
            // mi_ayudaAyuda
            // 
            this.mi_ayudaAyuda.Name = "mi_ayudaAyuda";
            this.mi_ayudaAyuda.Size = new System.Drawing.Size(152, 22);
            this.mi_ayudaAyuda.Text = "Ayuda";
            // 
            // mi_ayudaAcercaDe
            // 
            this.mi_ayudaAcercaDe.Name = "mi_ayudaAcercaDe";
            this.mi_ayudaAcercaDe.Size = new System.Drawing.Size(152, 22);
            this.mi_ayudaAcercaDe.Text = "Acerca de";
            // 
            // mi_mantCobertura
            // 
            this.mi_mantCobertura.Name = "mi_mantCobertura";
            this.mi_mantCobertura.Size = new System.Drawing.Size(189, 22);
            this.mi_mantCobertura.Text = "Cobertura";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem2});
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.marcaToolStripMenuItem.Text = "Equipos";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem1,
            this.modeloToolStripMenuItem,
            this.subModeloToolStripMenuItem});
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            // 
            // marcaToolStripMenuItem1
            // 
            this.marcaToolStripMenuItem1.Name = "marcaToolStripMenuItem1";
            this.marcaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.marcaToolStripMenuItem1.Text = "Marca";
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modeloToolStripMenuItem.Text = "Modelo";
            // 
            // subModeloToolStripMenuItem
            // 
            this.subModeloToolStripMenuItem.Name = "subModeloToolStripMenuItem";
            this.subModeloToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subModeloToolStripMenuItem.Text = "SubModelo";
            // 
            // marcaToolStripMenuItem2
            // 
            this.marcaToolStripMenuItem2.Name = "marcaToolStripMenuItem2";
            this.marcaToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.marcaToolStripMenuItem2.Text = "Marca";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 487);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.Text = "Control de partes y equipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_ingreso;
        private System.Windows.Forms.ToolStripMenuItem mi_mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem mi_mantRamo;
        private System.Windows.Forms.ToolStripMenuItem mi_mantCiaSeguros;
        private System.Windows.Forms.ToolStripMenuItem mi_mantTaller;
        private System.Windows.Forms.ToolStripMenuItem mi_mantCiudad;
        private System.Windows.Forms.ToolStripMenuItem mi_reportes;
        private System.Windows.Forms.ToolStripMenuItem mi_rprSalvamento;
        private System.Windows.Forms.ToolStripMenuItem mi_rprSalvamentoCia;
        private System.Windows.Forms.ToolStripMenuItem mi_rprSalvamentoReclamo;
        private System.Windows.Forms.ToolStripMenuItem mi_rprCia;
        private System.Windows.Forms.ToolStripMenuItem mi_rprTaller;
        private System.Windows.Forms.ToolStripMenuItem mi_ayuda;
        private System.Windows.Forms.ToolStripMenuItem mi_ayudaAyuda;
        private System.Windows.Forms.ToolStripMenuItem mi_ayudaAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem mi_ingresoReclamo;
        private System.Windows.Forms.ToolStripMenuItem mi_ingresoVehiculo;
        private System.Windows.Forms.ToolStripMenuItem mi_ingresoSalvamento;
        private System.Windows.Forms.ToolStripMenuItem mi_rprSalvamentoTaller;
        private System.Windows.Forms.ToolStripMenuItem mi_mantCobertura;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subModeloToolStripMenuItem;
    }
}

