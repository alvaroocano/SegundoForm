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

namespace SegundoForm
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void escribirJSON(List<Empleado> lista)
        {
            
            try
            {
                
                 string jsonString = JsonSerializer.Serialize(lista);
                 File.WriteAllText("empleados.json", jsonString);
                
            }
            catch (Exception e)
            {
                
            }
        }

        private List<Empleado> leerJSON(List<Empleado> lista)
        {
            try
            {
                if (File.Exists("empleados.json"))
                {
                    string jsonString = File.ReadAllText("empleados.json");
                    lista = JsonSerializer.Deserialize<List<Empleado>>(jsonString);
                    System.Console.WriteLine(jsonString);
                }
            }
            catch (Exception e)
            {

            }
            return lista;
        }

        void crearEtiqueta(string empleado, string apellido1, string apellido2, int posicion, int contadorNombre)
        {
            Label GrupoLbl = new System.Windows.Forms.Label();
            GrupoLbl.AutoSize = true;
            GrupoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
           System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)
           (0)));
            GrupoLbl.Location = new System.Drawing.Point(75, posicion);
            GrupoLbl.Name = "lblEmpleado";
            GrupoLbl.Size = new System.Drawing.Size(291, 20);
            GrupoLbl.TabIndex = 1;
            GrupoLbl.Text = empleado+" "+apellido1+" "+apellido2;
            groupBox1.Controls.Add(GrupoLbl);
            
            
        }

        void crearEmpleados(List<Empleado> lista)
        {
            int pos = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(lista[i].Nombre, lista[i].Apellido1, lista[i].Apellido2, pos, i);

            }
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();

            crearEmpleados(ListaDatosEmpleados.ListaEmpleados);

            escribirJSON(ListaDatosEmpleados.ListaEmpleados);
            leerJSON(ListaDatosEmpleados.ListaEmpleados);

        }

        private void FrmEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            groupBox1.Controls.Clear();
            string texto = textBox1.Text.ToLower();

            var listaFiltrada = ListaDatosEmpleados.ListaEmpleados.Where(x => x.Nombre.ToLower().StartsWith(texto)).ToList();
            crearEmpleados(listaFiltrada);
        }

        private void ordenarPorNombre()
        {
            groupBox1.Controls.Clear();
            var listaOrdenada = ListaDatosEmpleados.ListaEmpleados.OrderBy(m => m.Nombre).ToList();

            crearEmpleados(listaOrdenada);
        }

        private void ordenarPorApellidos()
        {
            groupBox1.Controls.Clear();
            var listaOrdenada = ListaDatosEmpleados.ListaEmpleados.OrderBy(m => m.Apellido1).ToList();
            var listaOrdenada2 = listaOrdenada.OrderBy(m => m.Apellido2).ToList();

            crearEmpleados(listaOrdenada2);
        }

        private void ordenarPorCorreo()
        {
            groupBox1.Controls.Clear();
            var listaOrdenada = ListaDatosEmpleados.ListaEmpleados.OrderBy(m => m.Correo).ToList();

            crearEmpleados(listaOrdenada);
        }

        private void ordenarPorSS()
        {
            groupBox1.Controls.Clear();
            var listaOrdenada = ListaDatosEmpleados.ListaEmpleados.OrderBy(m => m.Ss).ToList();

            crearEmpleados(listaOrdenada);
        }

        private void ordenarPorFecha()
        {
            groupBox1.Controls.Clear();
            var listaOrdenada = ListaDatosEmpleados.ListaEmpleados.OrderBy(m => m.Fecha_nacimiento).ToList();

            crearEmpleados(listaOrdenada);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBox1.SelectedItem.ToString();

            switch (opcion)
            {
                case "nombre":
                    ordenarPorNombre();
                break;

                case "apellidos":
                    ordenarPorApellidos();
                break;

                case "correo":
                    ordenarPorCorreo();
                break;

                case "ss":
                    ordenarPorSS();
                break;

                case "fecha_nacimiento":
                    ordenarPorFecha();
                break;
            }
        }
    }

    public static class ListaDatosEmpleados
    {
        public static List<Empleado> ListaEmpleados = new List<Empleado>();
    }
}
