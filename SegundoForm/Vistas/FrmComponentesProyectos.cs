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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SegundoForm.Vistas
{
    public partial class FrmComponentesProyectos : Form
    {
        public FrmComponentesProyectos()
        {
            InitializeComponent();
        }

        ControladorEmpleado ce = new ControladorEmpleado();

        private void FrmComponentesProyectos_Load(object sender, EventArgs e)
        {
            List<Empleado> lista = new List<Empleado>();
            lista = ce.leerJSON();

            for (int i = 0; i < lista.Count; i++)
            {
                string employeeName = $"{lista[i].Id} {lista[i].Nombre} {lista[i].Apellido1}";
                listBox1.Items.Add(employeeName);
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Obtener el índice seleccionado
            int selectedIndex = listBox1.SelectedIndex;

            // Validar si hay un ítem seleccionado
            if (selectedIndex >= 0 && selectedIndex < listBox1.Items.Count)
            {
                // Obtener el nombre del empleado
                string employeeName = listBox1.Items[selectedIndex].ToString();

                // Mostrar detalles o realizar otras acciones según sea necesario
                 MessageBox.Show($"Empleado seleccionado: {employeeName}");
            }
        }
    }
}


