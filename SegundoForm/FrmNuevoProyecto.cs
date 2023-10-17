using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoForm
{
    public partial class FrmNuevoProyecto : Form
    {
        public FrmNuevoProyecto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int temp = 0;

            if (txtCodigo.Text.Equals("") || !int.TryParse(txtCodigo.Text, out temp))
            {
                txtCodigo.BackColor = Color.Red;
            }
            if(txtDescripcion.Text.Equals(""))
            {
                txtDescripcion.BackColor = Color.Red;
            }
            if (txtPresupuestoInicio.Text.Equals(""))
            {
                txtPresupuestoInicio.BackColor = Color.Red;

            }
            if (txtPresupuestoFin.Text.Equals(""))
            {
                txtPresupuestoFin.BackColor = Color.Red;
            }
            if (txtEstado.Text.Equals(""))
            {
                txtEstado.BackColor = Color.Red;
            }
            if (txtCambios.Text.Equals(""))
            {
                txtCambios.BackColor = Color.Red;
            }
            if (txtCodCliente.Text.Equals(""))
            {
                txtCodCliente.BackColor = Color.Red;
            }
        }
    }
}
