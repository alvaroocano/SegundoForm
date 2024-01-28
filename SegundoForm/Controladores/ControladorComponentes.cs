using SegundoForm.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SegundoForm.Controladores
{
    internal class ControladorComponentes
    {
        ControladorEmpleado ce = new ControladorEmpleado();
        public void cargarEmpleados(System.Windows.Forms.ListBox lb)
        {
            List<Empleado> lista = new List<Empleado>();
            lista = ce.leerJSON();

            foreach (var empleado in lista)
            {
                // Crear un objeto anónimo con propiedades DisplayText y Value
                var listBoxItem = new { DisplayText = $"{empleado.Nombre} {empleado.Apellido1}", Value = empleado.Id };

                // Agregar el objeto al ListBox
                lb.Items.Add(listBoxItem);
            }
        }

        ControladorProyecto cp = new ControladorProyecto();
        public void cargarProyectos(System.Windows.Forms.ComboBox cb)
        {
            List<Proyecto> lista = new List<Proyecto>();
            lista = cp.leerJSON();

            foreach (var proyecto in lista)
            {
                string employeeName = $"{proyecto.Descripcion}";
                cb.Items.Add(employeeName);
            }
        }

        public void crearComponente(System.Windows.Forms.ComboBox cb, System.Windows.Forms.ListBox lb, System.Windows.Forms.ComboBox cb2, NumericUpDown nud, NumericUpDown nud2)
        {
            // Obtener el objeto seleccionado del ListBox
            var selectedItem = (dynamic)lb.SelectedItem;

            if (selectedItem != null)
            {
                // Obtener el Id del empleado desde la propiedad Value del objeto seleccionado
                int employeeId = selectedItem.Value;

                ComponentesProyecto cp = new ComponentesProyecto(cb.SelectedItem.ToString(), employeeId.ToString(), cb2.SelectedItem.ToString(), (float)nud.Value, nud2.Value);
                ListaDatosComponentes.ListaComponentes.Add(cp);

                MessageBox.Show("Componente creado");
            }
        }

    }

    public static class ListaDatosComponentes
    {
        public static List<ComponentesProyecto> ListaComponentes = new List<ComponentesProyecto>();
    }
}
