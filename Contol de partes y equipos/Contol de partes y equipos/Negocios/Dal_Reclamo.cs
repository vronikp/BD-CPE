using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contol_de_partes_y_equipos.Negocios
{
    class Dal_Reclamo
    {
        Datos.Dat_Reclamo dReclamo = new Datos.Dat_Reclamo();
        Entidades.Reclamo reclamo = new Entidades.Reclamo();

        public ComboBox llenarCiaSeguros(ComboBox ciaSeguros)
        {
            ciaSeguros.DataSource = dReclamo.llenar_cboCiaSeguros();
            ciaSeguros.ValueMember = "Entidad_Codigo";
            ciaSeguros.DisplayMember = "Entidad_NombreComercial";
            return ciaSeguros;
        }

        public ComboBox llenarRamo(ComboBox ramo)
        {
            ramo.DataSource = dReclamo.llenar_cboRamo();
            ramo.ValueMember = "Pardet_Secuencia";
            ramo.DisplayMember = "Pardet_Descripcion";
            return ramo;
        }

        public ComboBox llenarCobertura(ComboBox cobertura)
        {
            cobertura.DataSource = dReclamo.llenar_cboCobertura();
            cobertura.ValueMember = "Pardet_Secuencia";
            cobertura.DisplayMember = "Pardet_Descripcion";
            return cobertura;
        }

        public void guardarReclamo(string Reclamo_Numero, int CiaSeguros_Codigo, int Pardet_Ramo, int Pardet_Cobertura,
            string Reclamo_Cliente, string Reclamo_Observacion)
        {
            reclamo.Reclamo_Numero = Reclamo_Numero;
            reclamo.CiaSeguros_Codigo = CiaSeguros_Codigo;
            reclamo.Parame_Ramo = Program.parame_Ramo;
            reclamo.Pardet_Ramo = Pardet_Ramo;
            reclamo.Parame_Cobertura = Program.parame_Cobertura;
            reclamo.Pardet_Cobertura = Pardet_Cobertura;
            reclamo.Reclamo_Cliente = Reclamo_Cliente;
            reclamo.Reclamo_Observacion = Reclamo_Observacion;
            try
            {
                dReclamo.guardarReclamo(reclamo);
            }
            catch { throw; }
        }
    }
}
