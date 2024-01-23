using SegundoForm.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        public string IniCodigo = "";
        public string IniDescripcion = "";
        public DateTime IniFechaInicio = DateTime.Now;
        public DateTime IniFechaFin = DateTime.Now;
        public string IniEstado = "";
        public double IniPresupuestoInicio = 0.0;
        public double IniPresupuestoFin = 0.0;
        public string IniCambios = "";
        public int IniCodCliente = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int temp = 0;
            double temp2 = 0.0;
            bool todoBien = true;

            if (txtCodigo.Text.Equals("") || !int.TryParse(txtCodigo.Text, out temp))
            {
                txtCodigo.BackColor = Color.Red;
                todoBien = false;
            }

            if(txtDescripcion.Text.Equals(""))
            {
                txtDescripcion.BackColor = Color.Red;
                todoBien = false;
            }

            if (txtPresupuestoInicio.Text.Equals("") ||!double.TryParse(txtPresupuestoInicio.Text, out temp2))
            {
                txtPresupuestoInicio.BackColor = Color.Red;
                todoBien = false;

            }

            if (txtPresupuestoFin.Text.Equals("") || !double.TryParse(txtPresupuestoFin.Text, out temp2))
            {
                txtPresupuestoFin.BackColor = Color.Red;
                todoBien = false;
            }

            if (txtEstado.Text.Equals(""))
            {
                txtEstado.BackColor = Color.Red;
                todoBien = false;
            }

            if (txtCambios.Text.Equals(""))
            {
                txtCambios.BackColor = Color.Red;
                todoBien = false;
            }

            if (txtCodCliente.Text.Equals("") || !int.TryParse(txtCodCliente.Text, out temp))
            {
                txtCodCliente.BackColor = Color.Red;
                todoBien = false;
            }

            if (todoBien) {
                IniCodigo = txtCodigo.Text;
                IniDescripcion = txtDescripcion.Text;
                IniFechaInicio = txtFechaInicio.Value;
                IniFechaFin = txtFechaFin.Value;
                IniEstado = txtEstado.Text;
                IniPresupuestoInicio = double.Parse(txtPresupuestoInicio.Text);
                IniPresupuestoFin = double.Parse(txtPresupuestoInicio.Text);
                IniCambios = txtCambios.Text;
                IniCodCliente = int.Parse(txtCodCliente.Text);


                this.Close();
                Proyecto FormProyectosNuevo = new Proyecto(IniCodigo, IniDescripcion, IniFechaInicio, IniFechaFin, IniEstado, IniPresupuestoInicio, IniPresupuestoFin, IniCambios, IniCodCliente);
                ListaDatos.ListaProyectos.Add(FormProyectosNuevo);

                FrmProyectos f = new FrmProyectos();
                f.ShowDialog();

            }
        }

        ControladorEmpleado ce = new ControladorEmpleado();
        private void FrmNuevoProyecto_Load(object sender, EventArgs e)
        {
            
        }

    }
}
