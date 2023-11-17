using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoForm.Controladores;

namespace SegundoForm
{
    public partial class FormReg : Form
    {
        
        public FormReg()
        {
            InitializeComponent();
        }
        ControladorUsuario cf1 = new ControladorUsuario();
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
            cf1.cargarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cf1.escribirXML(ListaDatosUsuarios.listaUsuarios);
            cf1.leerXML(ListaDatosUsuarios.listaUsuarios);

        }
    }
}
