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
            bool toBien = true;
            int temp = 0;

            if(txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                toBien = false;
            }

            if(txtApellido1.Text == "")
            {
                txtApellido1.BackColor = Color.Red;
                toBien = false;
            }

            if (txtApellido2.Text == "")
            {
                txtApellido2.BackColor = Color.Red;
                toBien = false;
            }

            if (txtPuesto.Text == "")
            {
                txtPuesto.BackColor = Color.Red;
                toBien = false;
            }

            if (txtTlf.Text == "" || !int.TryParse(txtTlf.Text, out temp))
            {
                txtTlf.BackColor = Color.Red;
                toBien = false;
            }

            if (txtCorreo.Text == "")
            {
                txtCorreo.BackColor = Color.Red;
                toBien = false;
            }

            if(txtDNI.Text == "" || txtDNI.Text.Length != 9)
            {
                txtDNI.BackColor = Color.Red;
                toBien = false;
            }

            if(txtComent.Text == "" || txtComent.Text.Length > 1000)
            {
                txtComent.BackColor = Color.Red;
                toBien = false;
            }

            if (toBien)
            {
                Empleado e1 = new Empleado(numericUpDownId.Value, txtDNI.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtPuesto.Text, txtTlf.Text, txtCorreo.Text, fechaNacimiento.Value, numericUpDownSS.Value, txtComent.Text);
                ListaDatosEmpleados.ListaEmpleados.Add(e1);    

                FrmEmpleados f1 = new FrmEmpleados();
                f1.ShowDialog();

                this.Close();
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
