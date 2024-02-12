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
    public partial class FrmNuevoProyectoBBDD : Form
    {
        public FrmNuevoProyectoBBDD()
        {
            InitializeComponent();
            
        }

        ControladorProyectosBBDD cp = new ControladorProyectosBBDD();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cp.insertarProyecto(txtDescripcion, txtFechaInicio, txtFechaFin, comboBox1, txtPresupuestoInicio, txtPresupuestoInicio, comboBox2, txtCodCliente);
            
        }

        ControladorEmpleado ce = new ControladorEmpleado();
        private void FrmNuevoProyecto_Load(object sender, EventArgs e)
        {
            
        }

    }
}
