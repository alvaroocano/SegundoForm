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

        public class EmployeeRadioButton : UserControl
        {
            public RadioButton RadioButton { get; private set; }
            public string EmployeeName { get; private set; }

            public EmployeeRadioButton(string name)
            {
                InitializeComponents(name);
            }

            private void InitializeComponents(string name)
            {
                RadioButton = new RadioButton();
                RadioButton.Text = name;
                RadioButton.AutoSize = true;

                EmployeeName = name;

                // Asegúrate de ajustar las propiedades de este control personalizado según tus necesidades
                // Por ejemplo, puedes establecer la posición y el tamaño del RadioButton

                Controls.Add(RadioButton);
            }
        }

        // Luego, en tu formulario:

        private void FrmComponentesProyectos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ListaDatosEmpleados.ListaEmpleados.Count; i++)
            {
                string employeeName = $"{ListaDatosEmpleados.ListaEmpleados[i].Nombre} {ListaDatosEmpleados.ListaEmpleados[i].Apellido1}";

                EmployeeRadioButton employeeRadioButton = new EmployeeRadioButton(employeeName);
                listBox1.Controls.Add(employeeRadioButton);
            }
        }


    }
}
