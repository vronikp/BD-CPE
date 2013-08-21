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
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_CiaSeguros
            // 
            this.cbo_CiaSeguros.FormattingEnabled = true;
            this.cbo_CiaSeguros.Location = new System.Drawing.Point(169, 12);
            this.cbo_CiaSeguros.Name = "cbo_CiaSeguros";
            this.cbo_CiaSeguros.Size = new System.Drawing.Size(198, 25);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha inicio";
            // 
            // dtp_FechaInicio
            // 
            this.dtp_FechaInicio.Location = new System.Drawing.Point(169, 48);
            this.dtp_FechaInicio.Name = "dtp_FechaInicio";
            this.dtp_FechaInicio.Size = new System.Drawing.Size(200, 24);
            this.dtp_FechaInicio.TabIndex = 3;
            // 
            // dtp_FechaFin
            // 
            this.dtp_FechaFin.Location = new System.Drawing.Point(169, 78);
            this.dtp_FechaFin.Name = "dtp_FechaFin";
            this.dtp_FechaFin.Size = new System.Drawing.Size(200, 24);
            this.dtp_FechaFin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha fin";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = global::Contol_de_partes_y_equipos.Properties.Resources.cancel;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.Location = new System.Drawing.Point(229, 130);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(102, 42);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Cancelar";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Image = global::Contol_de_partes_y_equipos.Properties.Resources.accept1;
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Aceptar.Location = new System.Drawing.Point(44, 130);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(102, 43);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // frm_RprSalvamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 198);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_FechaFin);
            this.Controls.Add(this.dtp_FechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_CiaSeguros);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_RprSalvamentos";
            this.Text = "Reporte de Salvamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_CiaSeguros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicio;
        private System.Windows.Forms.DateTimePicker dtp_FechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}