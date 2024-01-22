using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SegundoForm.Controladores
{
    public partial class ControladorEmpleado
    {
        FrmNuevoEmpleado frm = new FrmNuevoEmpleado();
        

        public void ControladorEmpleado_Load(object sender, EventArgs e)
        {
        }

        

        public void escribirJSON(List<Empleado> lista)
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

        public List<Empleado> leerJSON(List<Empleado> lista)
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

        public void crearEtiqueta(string empleado, string apellido1, string apellido2, int posicion, int contadorNombre, System.Windows.Forms.GroupBox g)
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
            GrupoLbl.Text = empleado + " " + apellido1 + " " + apellido2;
            g.Controls.Add(GrupoLbl);


        }

        public void crearEmpleados(List<Empleado> lista, System.Windows.Forms.GroupBox g)
        {
            int pos = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(lista[i].Nombre, lista[i].Apellido1, lista[i].Apellido2, pos, i, g);

            }
        }

        public void cargarEmpleados(System.Windows.Forms.GroupBox g)
        {
            g.Controls.Clear();

            crearEmpleados(ListaDatosEmpleados.ListaEmpleados, g);

            escribirJSON(ListaDatosEmpleados.ListaEmpleados);
            leerJSON(ListaDatosEmpleados.ListaEmpleados);
        }

        public void filtrar(System.Windows.Forms.GroupBox g, System.Windows.Forms.TextBox t)
        {
            g.Controls.Clear();
            string texto = t.Text.ToLower();

            var listaFiltrada = ListaDatosEmpleados.ListaEmpleados.Where(x => x.Nombre.ToLower().StartsWith(texto)).ToList();
            crearEmpleados(listaFiltrada, g);
        }

        public void ordenarPorNombre(System.Windows.Forms.GroupBox g)
        {
            g.Controls.Clear();
            var listaOrdenada = ListaDatosEmpleados.ListaEmpleados.OrderBy(m => m.Nombre).ToList();

            crearEmpleados(listaOrdenada, g);
        }

        public void ordenarPorApellidos(System.Windows.Forms.GroupBox g)
        {
            g.Controls.Clear();
            var listaOrdenada = ListaDatosEmpleados.ListaEmpleados.OrderBy(m => m.Apellido1).ToList();
            var listaOrdenada2 = listaOrdenada.OrderBy(m => m.Apellido2).ToList();

            crearEmpleados(listaOrdenada2, g);
        }

        public void ordenarPorCorreo(System.Windows.Forms.GroupBox g)
        {
            g.Controls.Clear();
            var listaOrdenada = ListaDatosEmpleados.ListaEmpleados.OrderBy(m => m.Correo).ToList();

            crearEmpleados(listaOrdenada, g);
        }

        public void ordenarPorSS(System.Windows.Forms.GroupBox g)
        {
            g.Controls.Clear();
            var listaOrdenada = ListaDatosEmpleados.ListaEmpleados.OrderBy(m => m.Ss).ToList();

            crearEmpleados(listaOrdenada, g);
        }

        public void ordenarPorFecha(System.Windows.Forms.GroupBox g)
        {
            g.Controls.Clear();
            var listaOrdenada = ListaDatosEmpleados.ListaEmpleados.OrderBy(m => m.Fecha_nacimiento).ToList();

            crearEmpleados(listaOrdenada, g);
        }

        public void validarNuevoEmpleado(System.Windows.Forms.TextBox txtNombre, System.Windows.Forms.TextBox txtApellido1, System.Windows.Forms.TextBox txtApellido2, System.Windows.Forms.TextBox txtPuesto, System.Windows.Forms.TextBox txtTlf, System.Windows.Forms.TextBox txtCorreo, System.Windows.Forms.TextBox txtDNI, RichTextBox txtComent, NumericUpDown id, NumericUpDown ss, DateTimePicker fecha)
        {
            bool toBien = true;
            int temp = 0;

            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                toBien = false;
            }

            if (txtApellido1.Text == "")
            {
                txtApellido1.BackColor = Color.Red;
                toBien = false;
            }

            if (txtApellido2.Text == "")
            {
                txtApellido2.BackColor = Color.Red;
                toBien = false;
            }

            if (txtPuesto.Text == "")
            {
                txtPuesto.BackColor = Color.Red;
                toBien = false;
            }

            if (txtTlf.Text == "" || !int.TryParse(txtTlf.Text, out temp))
            {
                txtTlf.BackColor = Color.Red;
                toBien = false;
            }

            if (txtCorreo.Text == "")
            {
                txtCorreo.BackColor = Color.Red;
                toBien = false;
            }

            if (txtDNI.Text == "" || txtDNI.Text.Length != 9)
            {
                txtDNI.BackColor = Color.Red;
                toBien = false;
            }

            if (txtComent.Text == "" || txtComent.Text.Length > 1000)
            {
                txtComent.BackColor = Color.Red;
                toBien = false;
            }

            if (toBien)
            {
                Empleado e1 = new Empleado(id.Value, txtDNI.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtPuesto.Text, txtTlf.Text, txtCorreo.Text, fecha.Value, ss.Value, txtComent.Text);
                ListaDatosEmpleados.ListaEmpleados.Add(e1);

                FrmEmpleados f1 = new FrmEmpleados();
                f1.ShowDialog();

                frm.Close();
            }
        }
        
    }
    public static class ListaDatosEmpleados
    {
        public static List<Empleado> ListaEmpleados = new List<Empleado>();
    }

}

