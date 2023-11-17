using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System ;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoForm.Controladores;

namespace SegundoForm
{
    public partial class FrmNuevoEmpleado : Form
    {

        
        public FrmNuevoEmpleado()
        {
            InitializeComponent();
        }
        
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmNuevoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ControladorEmpleado cfe = new ControladorEmpleado();
            cfe.validarNuevoEmpleado(txtNombre, txtApellido1 , txtApellido2 , txtPuesto , txtTlf , txtCorreo , txtDNI , txtComent , numericUpDownId, numericUpDownSS, fechaNacimiento);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
