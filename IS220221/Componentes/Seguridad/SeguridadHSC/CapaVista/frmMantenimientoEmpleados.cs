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
    public partial class frmMantenimientoEmpleados : Form
    {
        public frmMantenimientoEmpleados()
        {
            InitializeComponent();

            TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
            navegador1.ObtenerCamposdeTabla(alias, "empleado", "sin");
            navegador1.MetodoSalirVista(this);
            navegador1.LlenarCombobox(cbxCodPuesto, "puesto", "codigo_puesto ", "nombre_puesto ", "estatus_puesto");
            navegador1.LlenarCombobox(cbxCodDep, "departamento", "codigo_departamento ", "nombre_departamento ", "estatus_departamento");

            navegador1.ObtenerNombreDGV(this.dvgConsulta);
            navegador1.LlenarTabla();
            navegador1.ObtenerReferenciaFormActual(this);

            navegador1.usuario = "admin";
            navegador1.aplicacion = "Mantenimiento Módulo";
            navegador1.ActualizaPermisos();
            navegador1.idmodulo = "1";

        }

        private void cbxCodPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarElementosenCombo(cbxCodPuesto, txtCodigoPuesto);
        }

        private void txtCodigoPuesto_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarElementosenCombo(cbxCodPuesto, txtCodigoPuesto);
        }

        private void cbxCodDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarElementosenCombo(cbxCodDep, txtCodigoDep);
        }

        private void txtCodigoDep_TextChanged(object sender, EventArgs e)
        {
            navegador1.SeleccionarElementosenCombo(cbxCodDep, txtCodigoDep);
        }

        private void dvgConsulta_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.SelecciondeFilaDGV(dvgConsulta);
        }
    }
}
