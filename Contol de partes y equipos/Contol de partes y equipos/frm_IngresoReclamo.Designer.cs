namespace Contol_de_partes_y_equipos
{
    partial class frm_IngresoReclamo
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
            this.lbl_CiaSeguros = new System.Windows.Forms.Label();
            this.lbl_NoReclamo = new System.Windows.Forms.Label();
            this.txt_NoReclamo = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_nuevoCiaSeguros = new System.Windows.Forms.Button();
            this.txt_Observacion = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Ramo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Cobertura = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_CiaSeguros
            // 
            this.cbo_CiaSeguros.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_CiaSeguros.FormattingEnabled = true;
            this.cbo_CiaSeguros.Location = new System.Drawing.Point(182, 37);
            this.cbo_CiaSeguros.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_CiaSeguros.Name = "cbo_CiaSeguros";
            this.cbo_CiaSeguros.Size = new System.Drawing.Size(238, 23);
            this.cbo_CiaSeguros.TabIndex = 0;
            // 
            // lbl_CiaSeguros
            // 
            this.lbl_CiaSeguros.AutoSize = true;
            this.lbl_CiaSeguros.Location = new System.Drawing.Point(17, 41);
            this.lbl_CiaSeguros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CiaSeguros.Name = "lbl_CiaSeguros";
            this.lbl_CiaSeguros.Size = new System.Drawing.Size(143, 17);
            this.lbl_CiaSeguros.TabIndex = 1;
            this.lbl_CiaSeguros.Text = "Compañia de Seguros";
            // 
            // lbl_NoReclamo
            // 
            this.lbl_NoReclamo.AutoSize = true;
            this.lbl_NoReclamo.Location = new System.Drawing.Point(17, 16);
            this.lbl_NoReclamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NoReclamo.Name = "lbl_NoReclamo";
            this.lbl_NoReclamo.Size = new System.Drawing.Size(88, 17);
            this.lbl_NoReclamo.TabIndex = 2;
            this.lbl_NoReclamo.Text = "No. Reclamo";
            // 
            // txt_NoReclamo
            // 
            this.txt_NoReclamo.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoReclamo.Location = new System.Drawing.Point(182, 13);
            this.txt_NoReclamo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NoReclamo.Name = "txt_NoReclamo";
            this.txt_NoReclamo.Size = new System.Drawing.Size(214, 22);
            this.txt_NoReclamo.TabIndex = 3;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = global::Contol_de_partes_y_equipos.Properties.Resources.save;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(72, 209);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(110, 43);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::Contol_de_partes_y_equipos.Properties.Resources.cancel;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(251, 209);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 43);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cliente.Location = new System.Drawing.Point(112, 114);
            this.txt_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(308, 22);
            this.txt_Cliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Observacion";
            // 
            // btn_nuevoCiaSeguros
            // 
            this.btn_nuevoCiaSeguros.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoCiaSeguros.Location = new System.Drawing.Point(158, 37);
            this.btn_nuevoCiaSeguros.Name = "btn_nuevoCiaSeguros";
            this.btn_nuevoCiaSeguros.Size = new System.Drawing.Size(24, 25);
            this.btn_nuevoCiaSeguros.TabIndex = 10;
            this.btn_nuevoCiaSeguros.Text = "+";
            this.btn_nuevoCiaSeguros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevoCiaSeguros.UseVisualStyleBackColor = true;
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Observacion.Location = new System.Drawing.Point(112, 142);
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.Size = new System.Drawing.Size(308, 56);
            this.txt_Observacion.TabIndex = 11;
            this.txt_Observacion.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "+";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ramo";
            // 
            // cbo_Ramo
            // 
            this.cbo_Ramo.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Ramo.FormattingEnabled = true;
            this.cbo_Ramo.Location = new System.Drawing.Point(182, 62);
            this.cbo_Ramo.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Ramo.Name = "cbo_Ramo";
            this.cbo_Ramo.Size = new System.Drawing.Size(238, 23);
            this.cbo_Ramo.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(158, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 25);
            this.button2.TabIndex = 17;
            this.button2.Text = "+";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cobertura";
            // 
            // cbo_Cobertura
            // 
            this.cbo_Cobertura.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Cobertura.FormattingEnabled = true;
            this.cbo_Cobertura.Location = new System.Drawing.Point(182, 87);
            this.cbo_Cobertura.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Cobertura.Name = "cbo_Cobertura";
            this.cbo_Cobertura.Size = new System.Drawing.Size(238, 23);
            this.cbo_Cobertura.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(397, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 18;
            this.button3.Text = "...";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frm_IngresoReclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 260);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_Cobertura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_Ramo);
            this.Controls.Add(this.txt_Observacion);
            this.Controls.Add(this.btn_nuevoCiaSeguros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_NoReclamo);
            this.Controls.Add(this.lbl_NoReclamo);
            this.Controls.Add(this.lbl_CiaSeguros);
            this.Controls.Add(this.cbo_CiaSeguros);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_IngresoReclamo";
            this.Text = "Ingreso de Reclamo";
            this.Load += new System.EventHandler(this.frm_IngresoReclamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_CiaSeguros;
        private System.Windows.Forms.Label lbl_CiaSeguros;
        private System.Windows.Forms.Label lbl_NoReclamo;
        private System.Windows.Forms.TextBox txt_NoReclamo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_nuevoCiaSeguros;
        private System.Windows.Forms.RichTextBox txt_Observacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Ramo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Cobertura;
        private System.Windows.Forms.Button button3;
    }
}