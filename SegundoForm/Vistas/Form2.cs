using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoForm.Vistas;

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
            FrmProyectos FormProyectos =  new FrmProyectos();
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

        private void listadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEmpleados frm = new FrmEmpleados();
            frm.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNuevoEmpleado frm = new FrmNuevoEmpleado();
            frm.ShowDialog();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frm = new FrmNuevoCliente();
            frm.ShowDialog();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = ".";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Logs logs = new Logs();
                //propiedad pública del formulario log
                logs.directorio = folderBrowserDialog.SelectedPath;

                logs.Show();
            }

        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComponentesProyectos form = new FrmComponentesProyectos();
            form.ShowDialog();
        }
    }
}
