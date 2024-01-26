using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoForm.Controladores
{
    internal class ControladorComponentes
    {
        ControladorEmpleado ce = new ControladorEmpleado();
        public void cargarEmpleados(ListBox lb)
        {
            List<Empleado> lista = new List<Empleado>();
            lista = ce.leerJSON();

            for (int i = 0; i < lista.Count; i++)
            {
                string employeeName = $"{lista[i].Nombre} {lista[i].Apellido1}";
                lb.Items.Add(employeeName);
            }
        }

        ControladorProyecto cp = new ControladorProyecto();
        public void cargarProyectos(ComboBox cb)
        {
            List<Proyecto> lista = new List<Proyecto>();
            lista = cp.leerJSON();

            foreach (var proyecto in lista)
            {
                string employeeName = $"{proyecto.Descripcion}";
                cb.Items.Add(employeeName);
            }
        }
    }
}
