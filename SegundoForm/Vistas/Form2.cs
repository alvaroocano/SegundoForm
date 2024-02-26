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

        private void cargarProyectosBBDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarProyectosBBDD cpb = new CargarProyectosBBDD();
            cpb.ShowDialog();
        }

        private void ejemploMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EjemploMDI emdi = new EjemploMDI();
            emdi.ShowDialog();
        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(
                (splitContainer1.Panel1.Width - pictureBox1.Width) / 2,
                (splitContainer1.Panel1.Height - pictureBox1.Height) / 2
            );

            pictureBox2.Location = new Point(
                (splitContainer1.Panel2.Width - pictureBox2.Width) / 2,
                (splitContainer1.Panel2.Height - pictureBox2.Height) / 2
            );


        }
    }
}
