using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SegundoForm.Controladores;

namespace SegundoForm.Vistas
{
    public partial class FrmImprimirBBDD : Form
    {
        public System.Drawing.Printing.PrintDocument Document = new System.Drawing.Printing.PrintDocument();
        public FrmImprimirBBDD()
        {
            InitializeComponent();
            Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(document_PrintPage);
        }

        internal PrintPreviewDialog PrintPreviewDialog1;
        internal System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();

        private void FrmImprimirBBDD_Load(object sender, EventArgs e)
        {
            document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(document_PrintPage);
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0;
            int contador = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            Font font = new Font("Arial", 10);
            yPos = topMargin + (contador * (font.Size + 4));

            e.Graphics.DrawString("LISTADO DE PROYECTOS", font, Brushes.Black, leftMargin, yPos, new StringFormat());
            contador++;

            // Obtener los proyectos desde la base de datos
            DataTable proyectos = ObtenerProyectosDesdeBaseDeDatos();

            // Iterar sobre los proyectos y dibujarlos en el documento
            foreach (DataRow proyecto in proyectos.Rows)
            {
                yPos = topMargin + (contador * font.Size);
                string nombreProyecto = proyecto["descripcion"].ToString(); // Reemplaza "Nombre" con el nombre de la columna que contiene el nombre del proyecto
                e.Graphics.DrawString(nombreProyecto, font, Brushes.Black, leftMargin, yPos, new StringFormat());
                contador++;
            }
        }

        ControladorProyectosBBDD cpb = new ControladorProyectosBBDD();
        private DataTable ObtenerProyectosDesdeBaseDeDatos()
        {
            // Aquí debes implementar la lógica para obtener los proyectos desde la base de datos
            // Utiliza tu capa de datos para ejecutar la consulta y obtener los resultados
            // Luego, devuelve los resultados en forma de DataTable

            string connectionString = cpb.construirCadenaConexión();
            string query = "SELECT descripcion FROM Proyectos"; // Query para seleccionar los nombres de los proyectos, reemplaza "Nombre" con el nombre de la columna en tu base de datos

            DataTable proyectos = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(proyectos); // Llena el DataTable con los resultados de la consulta
                    }
                }
            }

            return proyectos;
        }
        public System.Drawing.Printing.PrintDocument GetPrintDocument()
        {
            return document;
        }
    }
}
