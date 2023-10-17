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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProyectos FormProyectos = new FrmProyectos();
            FormProyectos.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmNuevoProyecto frmNuevoProyecto = new FrmNuevoProyecto();
            frmNuevoProyecto.ShowDialog();
        }
    }
}
