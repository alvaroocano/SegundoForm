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
            // TODO: esta línea de código carga datos en la tabla 'baseDatosDataSet1.Proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.baseDatosDataSet1.Proyectos);
            // TODO: esta línea de código carga datos en la tabla 'baseDatosDataSet1.Proyectos' Puede moverla o quitarla según sea necesario.
            this.proyectosTableAdapter.Fill(this.baseDatosDataSet1.Proyectos);
            DataTable dtProyectos = cpb.obtenerProyectos();

            if (dtProyectos.Rows.Count > 0)
            {
                // Hay datos disponibles, enlaza el DataGridView con el DataTable
                dataGridView1.DataSource = dtProyectos;
            }
            else
            {
                // No hay datos disponibles, muestra un mensaje informativo
                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay datos disponibles.";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.AutoSize = false;
                lblMensaje.Dock = DockStyle.Fill;
                Controls.Add(lblMensaje);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpb.eliminarProyectosSeleccionados(dataGridView1);
        }

        
    }
}
