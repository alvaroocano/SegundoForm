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

        private string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            string databaseFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database1.mdf");
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;
        }

        private void CargarProyectosBBDD_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Proyectos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, construirCadenaConexión());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
