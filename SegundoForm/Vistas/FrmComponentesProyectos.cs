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
using SegundoForm.Modelos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SegundoForm.Vistas
{
    public partial class FrmComponentesProyectos : Form
    {
        public FrmComponentesProyectos()
        {
            InitializeComponent();
        }


        ControladorComponentes cc = new ControladorComponentes();
        private void FrmComponentesProyectos_Load(object sender, EventArgs e)
        {
            cc.cargarEmpleados(listBox1);
            cc.cargarProyectos(proyectos);
        }

        private void btnAnhadir_Click(object sender, EventArgs e)
        {
            cc.crearComponente(proyectos, listBox1, puesto, numericUpDown1, numericUpDown2);
        }
    }

    
}


