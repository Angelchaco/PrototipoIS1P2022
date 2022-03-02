using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaSeguridadHSC
{
    public partial class frmProcesoNominaD : Form
    {
        public frmProcesoNominaD()
        {
            InitializeComponent();

            TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
            navegador1.ObtenerCamposdeTabla(alias, "nominad", "sin");
            navegador1.MetodoSalirVista(this);
            navegador1.LlenarCombobox(cbxCodConcepto, "concepto", "codigo_concepto ", "nombre_concepto ", "estatus_concepto");

            navegador1.ObtenerNombreDGV(this.dvgConsulta);
            navegador1.LlenarTabla();
            navegador1.ObtenerReferenciaFormActual(this);

            navegador1.usuario = "admin";
            navegador1.aplicacion = "Mantenimiento Módulo";
            navegador1.ActualizaPermisos();
            navegador1.idmodulo = "1";

        }

        private void dvgConsulta_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.SelecciondeFilaDGV(dvgConsulta);
        }

        private void cbxCodConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarElementosenCombo(cbxCodConcepto, txtCodigoConcepto);
        }

        private void txtCodigoConcepto_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarElementosenCombo(cbxCodConcepto, txtCodigoConcepto);
        }
    }
}
