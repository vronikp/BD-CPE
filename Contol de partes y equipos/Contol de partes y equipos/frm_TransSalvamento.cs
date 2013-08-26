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
    public partial class frm_TransSalvamento : Form

    {
        Negocios.Dal_Savamento dalSalvam = new Negocios.Dal_Savamento();

        public frm_TransSalvamento()
        {
            InitializeComponent();
        }

        private void frm_IngresoSalvamento_Load(object sender, EventArgs e)
        {
            dalSalvam.llenarReclamo(cbo_Reclamo);
            dalSalvam.llenarTaller(cbo_Taller);
            dalSalvam.llenarCodigo(txt_Codigo);
            dalSalvam.llenarVehiculo(cbo_vehiculo);
            dalSalvam.llenarConjunto(cbo_Conjunto);
            dalSalvam.llenarMarca(cbo_Marca);
            cbo_Reclamo.SelectedItem = null;
            cbo_Taller.SelectedItem = null;
            cbo_vehiculo.SelectedItem = null;
            cbo_Conjunto.SelectedItem = null;
            cbo_Accesorio.SelectedItem = null;
            cbo_Marca.SelectedItem = null;
        }

        private void chk_vehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_vehiculo.Checked)
            {
                cbo_vehiculo.Visible = true;
            }
            else
            {
                cbo_vehiculo.Visible = false;
            }
        }

        private void cbo_Conjunto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int conjunto = Convert.ToInt32(cbo_Conjunto.SelectedValue);
            dalSalvam.llenarAccesorio(cbo_Accesorio,conjunto);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cbo_Reclamo.SelectedItem == null )
            {
                MessageBox.Show("Debe seleccionar un reclamo", "Partes y equipos");
                return;
            }
            if (cbo_Taller.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un taller", "Partes y equipos");
                return;
            }
            if (cbo_Conjunto.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un conjunto", "Partes y equipos"); 
                return;
            }
            if (cbo_Accesorio.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un accesorio", "Partes y equipos");
                return;
            }
            if (cbo_Marca.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una marca", "Partes y equipos");
                return;
            }

            try
            {   
                bool esNuevo = dalSalvam.esNuevo(Convert.ToInt32(txt_Codigo.Text)) == 0;
                dalSalvam.guardarSalvamento(Convert.ToInt32(txt_Codigo.Text), txt_Descripcion.Text, txt_Observacion.Text, Convert.ToInt32(cbo_vehiculo.SelectedValue), 
                    Program.parame_Conjunto,  Convert.ToInt32(cbo_Conjunto.SelectedValue), Program.parame_Accesorio,
                    Convert.ToInt32(cbo_Accesorio.SelectedValue), Program.parame_Marca, Convert.ToInt32(cbo_Marca.SelectedValue),
                    txt_Modelo.Text, txt_NoSerie.Text, Convert.ToInt32(cbo_Reclamo.SelectedValue), Convert.ToInt32(cbo_Taller.SelectedValue));
                if (esNuevo)
                {
                    MessageBox.Show("Parte o equipo ingresado con exito", "Partes y equipos");
                }else{
                    MessageBox.Show("Parte o equipo modificado con exito", "Partes y equipos");
                }
                cbo_Conjunto.SelectedItem = null;
                cbo_Accesorio.SelectedItem = null;
                cbo_Marca.SelectedItem = null;
                dalSalvam.llenarCodigo(txt_Codigo);
                txt_Descripcion.Text = "";
                txt_Modelo.Text = "";
                txt_NoSerie.Text = "";
                txt_Observacion.Text = "";
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString());}
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            cbo_Reclamo.SelectedItem = null;
            cbo_Taller.SelectedItem = null;
            cbo_vehiculo.SelectedItem = null;
            cbo_Conjunto.SelectedItem = null;
            cbo_Accesorio.SelectedItem = null;
            cbo_Marca.SelectedItem = null;
            dalSalvam.llenarCodigo(txt_Codigo);
            txt_Descripcion.Text = "";
            txt_Modelo.Text = "";
            txt_NoSerie.Text = "";
            txt_Observacion.Text = "";
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //frm_Datos frm_Datos = new frm_Datos(this);
            frm_Datos frm_Datos = new frm_Datos(this);
            frm_Datos.tipo = 0;
            frm_Datos.Show();
        }

        public void llenar()
        {
            DataTable dt = dalSalvam.buscar(frm_Principal.codigo);
            MessageBox.Show("salvamento " + dt.Rows[0][4].ToString() + " " + dt.Rows[0][5].ToString());
            cbo_Reclamo.SelectedValue = Convert.ToInt32(dt.Rows[0][0].ToString());
            cbo_Taller.SelectedValue = Convert.ToInt32(dt.Rows[0][1].ToString());
            cbo_vehiculo.SelectedValue = Convert.ToInt32(dt.Rows[0][2].ToString());
            cbo_Conjunto.SelectedValue = Convert.ToInt32(dt.Rows[0][3].ToString());
            int conjunto = Convert.ToInt32(cbo_Conjunto.SelectedValue);
            dalSalvam.llenarAccesorio(cbo_Accesorio, conjunto);
            cbo_Accesorio.SelectedValue = Convert.ToInt32(dt.Rows[0][4].ToString());
            cbo_Marca.SelectedValue = Convert.ToInt32(dt.Rows[0][5].ToString());
            txt_Codigo.Text = Convert.ToInt32(dt.Rows[0][6].ToString()).ToString("000000");
            txt_Descripcion.Text = dt.Rows[0][7].ToString();
            txt_Modelo.Text = dt.Rows[0][8].ToString();
            txt_NoSerie.Text = dt.Rows[0][9].ToString();
            txt_Observacion.Text = dt.Rows[0][10].ToString();
        }
    }
}
