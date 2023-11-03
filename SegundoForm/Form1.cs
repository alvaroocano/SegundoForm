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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            escribirXML(ListaDatosUsuarios.listaUsuarios);
            leerXML(ListaDatosUsuarios.listaUsuarios);

        }
    }
}
