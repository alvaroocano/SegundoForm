using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace SegundoForm
{

    
    public partial class FrmProyectos : Form
    {
        
        public FrmProyectos(string codigo, string descripcion, DateTime fechaInicio, DateTime fechaFin, string estado, double presupuestoInicial, double presupuestoActual, string cambios, int codCliente)
        {
            InitializeComponent();

        }

        public FrmProyectos()
        {
            InitializeComponent();
            groupBox.Controls.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void crearEtiqueta(string proyecto, int posicion, int contadorNombre)
        {
            CheckBox LblProyecto = new System.Windows.Forms.CheckBox();
            LblProyecto.AutoSize = true;
            LblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            LblProyecto.Location = new System.Drawing.Point(75, posicion);
            LblProyecto.Name = "lblProyecto";
            LblProyecto.Size = new System.Drawing.Size(291, 20);
            LblProyecto.TabIndex = 1;
            LblProyecto.Text = proyecto;
            
            groupBox.Controls.Add(LblProyecto);
        }

        private void cargarProyectos(List<Proyecto> lista)
        {
            int pos = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(lista[i].Descripcion, pos, i);

            }

        }
        private void escribirXML(List<Proyecto> lista)
        {
            try
            {
                using (var writer = new StreamWriter("proyectos.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(lista.GetType());
                    serializer.Serialize(writer, lista, namespaces);
                }
            }
            catch (Exception e) { }
        }

        private void leerXML(List<Proyecto> lista)
        {
            try
            {
                string xml = File.ReadAllText("proyectos.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new
                    XmlSerializer(lista.GetType());
                    lista = (List<Proyecto>)serializer.Deserialize(reader);
                    System.Console.WriteLine(xml);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
        }
        private void FrmProyectos_Load(object sender, EventArgs e)
        {
            groupBox.Controls.Clear();

            cargarProyectos(ListaDatos.ListaProyectos);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            
        }

        private void ordenarProyectosDescripcion()
        {
            groupBox.Controls.Clear();
            var listaOrdenada = ListaDatos.ListaProyectos.OrderBy(m => m.Descripcion).ToArray();
            int pos = 0;
            for (int i = 0; i < listaOrdenada.Count(); i++)
            {
                pos = pos + 20;
                crearEtiqueta(listaOrdenada[i].Descripcion, pos, i);

            }
        }

        private void ordenarProyectosPresupuesto(string info)
        {
            groupBox.Controls.Clear();

            if (info.Equals("inicio"))
            {
                var listaOrdenada = ListaDatos.ListaProyectos.OrderBy(m => m.PresupuestoInicial).ToArray();
                int pos = 0;
                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    pos = pos + 20;
                    crearEtiqueta(listaOrdenada[i].Descripcion, pos, i);

                }
            }
            if (info.Equals("fin"))
            {
                var listaOrdenada = ListaDatos.ListaProyectos.OrderByDescending(m => m.PresupuestoInicial).ToArray();
                int pos = 0;
                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    pos = pos + 20;
                    crearEtiqueta(listaOrdenada[i].Descripcion, pos, i);

                }
            }
            
        }

        private void ordenarProyectosFecha(string info)
        {
            groupBox.Controls.Clear();

            if (info.Equals("fecha_inicio"))
            {
                var listaOrdenada = ListaDatos.ListaProyectos.OrderBy(m => m.FechaInicio).ToArray();
                int pos = 0;
                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    pos = pos + 20;
                    crearEtiqueta(listaOrdenada[i].Descripcion, pos, i);

                }
            }
            if (info.Equals("fecha_fin"))
            {
                var listaOrdenada = ListaDatos.ListaProyectos.OrderByDescending(m => m.FechaFin).ToArray();
                int pos = 0;
                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    pos = pos + 20;
                    crearEtiqueta(listaOrdenada[i].Descripcion, pos, i);

                }
            }

        }

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = select.SelectedItem.ToString();
  
            switch (opcion)
            {
                case "descripcion":
                    ordenarProyectosDescripcion();
                break;

                case "fecha_inicio":
                    ordenarProyectosFecha("fecha_inicio");
                break;

                case "fecha_fin":
                    ordenarProyectosFecha("fecha_fin");
                    break;

                case "presupuesto_inicio":
                    ordenarProyectosPresupuesto("inicio");
                    break;

                case "presupuesto_final":
                    ordenarProyectosPresupuesto("fin");
                    break;
            }
        }
        private List<CheckBox> ListaChecked = new List<CheckBox>();
        private void button1_Click(object sender, EventArgs e)
        {
            var checkboxes = groupBox.Controls.OfType<CheckBox>().Where(x => x.GetType() == typeof(CheckBox));
            
            foreach (var ch in checkboxes)
            {
                if (ch.Checked)
                {
                    ListaChecked.Add(ch);
                }
            }

            foreach (var ch in ListaChecked)
            {
                
                int indice = ListaDatos.ListaProyectos.FindIndex(x => x.Descripcion == ch.Text);
                if(indice != -1)
                {
                    ListaDatos.ListaProyectos.RemoveAt(indice);
                }
            }

            groupBox.Controls.Clear();
            int pos = 0;
            for (int i = 0; i < ListaDatos.ListaProyectos.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(ListaDatos.ListaProyectos[i].Descripcion, pos, i);

            }

           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            escribirXML(ListaDatos.ListaProyectos);
            escribirXML(ListaDatos.ListaProyectos);
        }
    }
    public static class ListaDatos
    {
        public static List<Proyecto> ListaProyectos = new List<Proyecto>();
    }
}
