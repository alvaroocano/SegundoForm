using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoForm.Controladores;

namespace SegundoForm.Vistas
{
    public partial class CargarProyectosBBDD : Form
    {
        public CargarProyectosBBDD()
        {
            InitializeComponent();
        }

        ControladorProyectosBBDD cpb = new ControladorProyectosBBDD();

        private void CargarProyectosBBDD_Load(object sender, EventArgs e)
        {
            cpb.CargarUsuariosEnComboBox(comboBox1);
            comboBox1.SelectedIndex = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpb.eliminarProyectosSeleccionados(dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpb.CargarDatosEnDataGridView(dataGridView1, comboBox1.SelectedItem.ToString());
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FrmImprimirBBDD frm = new FrmImprimirBBDD();
            //Set the size, location, and name.
            frm.ClientSize = new System.Drawing.Size(400,
            300);
            frm.Location = new System.Drawing.Point(29, 29);
            frm.Name = "PrintPreviewDialog1";
            frm.MinimumSize = new System.Drawing.Size(375, 250);
            // Establece el documento a imprimir
            frm.Document.DocumentName = "Previsualización";

            // Muestra el printpreviewdialog
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = frm.Document;

            // Muestra el diálogo
            printPreviewDialog1.ShowDialog();
        }
    }
}
