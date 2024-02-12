using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
            
            if (Application.OpenForms["FrmComponentesProyectos"] == null)
            {
                // El formulario no está abierto, así que lo abrimos
                FrmComponentesProyectos formulario = new FrmComponentesProyectos();
                formulario.Show();
            }
            else
            {
                Application.OpenForms["FrmComponentesProyectos"].BringToFront();
            }
        }

        private void impresionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inicializa el printpreviewdialog
            FrmImpresion frm = new FrmImpresion();
            //Set the size, location, and name.
            frm.ClientSize = new System.Drawing.Size(400,
            300);
            frm.Location = new System.Drawing.Point(29, 29);
            frm.Name = "PrintPreviewDialog1";
            frm.MinimumSize = new System.Drawing.Size(375,250);
            // Establece el documento a imprimir
            frm.Document.DocumentName = "Previsualización";

            // Muestra el printpreviewdialog
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = frm.Document;

            // Muestra el diálogo
            printPreviewDialog1.ShowDialog();
        }

        private void proyectosBBDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoProyectoBBDD frm = new FrmNuevoProyectoBBDD();
            frm.ShowDialog();
        }
    }
}
