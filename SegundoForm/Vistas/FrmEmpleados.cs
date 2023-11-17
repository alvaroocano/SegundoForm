using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Text.Json;
using System.IO;
using SegundoForm.Controladores;

namespace SegundoForm
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        ControladorEmpleado cfe = new ControladorEmpleado();

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            cfe.cargarEmpleados(groupBox1);

        }

        private void FrmEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
           

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            cfe.filtrar(groupBox1, textBox1);
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBox1.SelectedItem.ToString();

            switch (opcion)
            {
                case "nombre":
                    cfe.ordenarPorNombre(groupBox1);
                break;

                case "apellidos":
                    cfe.ordenarPorApellidos(groupBox1);
                break;

                case "correo":
                    cfe.ordenarPorCorreo(groupBox1);
                break;

                case "ss":
                    cfe.ordenarPorSS(groupBox1);
                break;

                case "fecha_nacimiento":
                    cfe.ordenarPorFecha(groupBox1);
                break;
            }
        }


    }

    
}
