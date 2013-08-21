namespace Contol_de_partes_y_equipos
{
    partial class frm_IngresoSalvamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_vehiculo = new System.Windows.Forms.ComboBox();
            this.chk_vehiculo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Taller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Reclamo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_Marca = new System.Windows.Forms.ComboBox();
            this.txt_Observacion = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NoSerie = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Conjunto = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbo_Accesorio = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_vehiculo);
            this.groupBox1.Controls.Add(this.chk_vehiculo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_Taller);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_Reclamo);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(394, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // cbo_vehiculo
            // 
            this.cbo_vehiculo.FormattingEnabled = true;
            this.cbo_vehiculo.Location = new System.Drawing.Point(121, 79);
            this.cbo_vehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_vehiculo.Name = "cbo_vehiculo";
            this.cbo_vehiculo.Size = new System.Drawing.Size(265, 25);
            this.cbo_vehiculo.TabIndex = 24;
            this.cbo_vehiculo.Visible = false;
            // 
            // chk_vehiculo
            // 
            this.chk_vehiculo.AutoSize = true;
            this.chk_vehiculo.Location = new System.Drawing.Point(7, 83);
            this.chk_vehiculo.Name = "chk_vehiculo";
            this.chk_vehiculo.Size = new System.Drawing.Size(79, 21);
            this.chk_vehiculo.TabIndex = 23;
            this.chk_vehiculo.Text = "Vehiculo";
            this.chk_vehiculo.UseVisualStyleBackColor = true;
            this.chk_vehiculo.CheckedChanged += new System.EventHandler(this.chk_vehiculo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Taller";
            // 
            // cbo_Taller
            // 
            this.cbo_Taller.FormattingEnabled = true;
            this.cbo_Taller.Location = new System.Drawing.Point(121, 50);
            this.cbo_Taller.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Taller.Name = "cbo_Taller";
            this.cbo_Taller.Size = new System.Drawing.Size(265, 25);
            this.cbo_Taller.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Reclamo";
            // 
            // cbo_Reclamo
            // 
            this.cbo_Reclamo.FormattingEnabled = true;
            this.cbo_Reclamo.Location = new System.Drawing.Point(121, 20);
            this.cbo_Reclamo.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Reclamo.Name = "cbo_Reclamo";
            this.cbo_Reclamo.Size = new System.Drawing.Size(265, 25);
            this.cbo_Reclamo.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_Marca);
            this.groupBox2.Controls.Add(this.txt_Observacion);
            this.groupBox2.Controls.Add(this.txt_Descripcion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_NoSerie);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txt_Codigo);
            this.groupBox2.Controls.Add(this.txt_Modelo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbo_Conjunto);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cbo_Accesorio);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(13, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(407, 315);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parte o equipo";
            // 
            // cbo_Marca
            // 
            this.cbo_Marca.FormattingEnabled = true;
            this.cbo_Marca.Location = new System.Drawing.Point(121, 170);
            this.cbo_Marca.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Marca.Name = "cbo_Marca";
            this.cbo_Marca.Size = new System.Drawing.Size(196, 25);
            this.cbo_Marca.TabIndex = 42;
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Location = new System.Drawing.Point(121, 257);
            this.txt_Observacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.Size = new System.Drawing.Size(264, 24);
            this.txt_Observacion.TabIndex = 41;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(121, 106);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(264, 60);
            this.txt_Descripcion.TabIndex = 36;
            this.txt_Descripcion.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Observacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Codigo";
            // 
            // txt_NoSerie
            // 
            this.txt_NoSerie.Location = new System.Drawing.Point(121, 228);
            this.txt_NoSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NoSerie.Name = "txt_NoSerie";
            this.txt_NoSerie.Size = new System.Drawing.Size(264, 24);
            this.txt_NoSerie.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 231);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 17);
            this.label19.TabIndex = 32;
            this.label19.Text = "No. Serie";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(121, 14);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(196, 24);
            this.txt_Codigo.TabIndex = 33;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Location = new System.Drawing.Point(121, 199);
            this.txt_Modelo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(196, 24);
            this.txt_Modelo.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Conjunto";
            // 
            // cbo_Conjunto
            // 
            this.cbo_Conjunto.FormattingEnabled = true;
            this.cbo_Conjunto.Location = new System.Drawing.Point(121, 43);
            this.cbo_Conjunto.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Conjunto.Name = "cbo_Conjunto";
            this.cbo_Conjunto.Size = new System.Drawing.Size(264, 25);
            this.cbo_Conjunto.TabIndex = 34;
            this.cbo_Conjunto.SelectionChangeCommitted += new System.EventHandler(this.cbo_Conjunto_SelectionChangeCommitted);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 202);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Modelo";
            // 
            // cbo_Accesorio
            // 
            this.cbo_Accesorio.FormattingEnabled = true;
            this.cbo_Accesorio.Location = new System.Drawing.Point(121, 73);
            this.cbo_Accesorio.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Accesorio.Name = "cbo_Accesorio";
            this.cbo_Accesorio.Size = new System.Drawing.Size(264, 25);
            this.cbo_Accesorio.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 173);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Marca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Pieza";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 109);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Descripicion";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(504, 363);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 30);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(504, 221);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(100, 30);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(449, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 172);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(504, 292);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(100, 30);
            this.btn_Limpiar.TabIndex = 8;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // frm_IngresoSalvamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_IngresoSalvamento";
            this.Text = "Partes o equipos";
            this.Load += new System.EventHandler(this.frm_IngresoSalvamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Reclamo;
        private System.Windows.Forms.CheckBox chk_vehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Taller;
        private System.Windows.Forms.ComboBox cbo_vehiculo;
        private System.Windows.Forms.TextBox txt_Observacion;
        private System.Windows.Forms.RichTextBox txt_Descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NoSerie;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Modelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Conjunto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbo_Accesorio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_Marca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}