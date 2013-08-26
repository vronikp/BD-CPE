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
    public partial class frm_Datos : Form
    {
        public int tipo; //codigo y secuencia 0 para salvamento, 1 para reclamo, 2 para vehiculo
        public int codigo;
        public bool selecionado;
        frm_TransSalvamento frm_salvamento;

        public frm_Datos(frm_TransSalvamento frm_salvamento)
        {
            this.frm_salvamento = frm_salvamento;
            InitializeComponent();
        }

        private void frm_Datos_Load(object sender, EventArgs e)
        {
            if (tipo == 0)
            {
                this.Name = "Salvamentos";
                Negocios.Dal_Savamento dalSalvam = new Negocios.Dal_Savamento();
                dataGridView1.DataSource = dalSalvam.listar();
            }

            if (tipo == 1)
            {
                this.Name = "Reclamo";
            }

            if (tipo == 2)
            {
                this.Name = "Vehiculo";
            }

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[e.RowIndex];
            frm_Principal.codigo = Convert.ToInt32(row.Cells["Codigo"].Value.ToString());
            MessageBox.Show(codigo.ToString());
            selecionado = true;
            frm_salvamento.llenar();
            this.Close();
        }
    }
}

