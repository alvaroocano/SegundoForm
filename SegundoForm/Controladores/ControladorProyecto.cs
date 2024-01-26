using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Serialization;
using System.Text.Json;

namespace SegundoForm.Controladores
{
    public partial class ControladorProyecto : Form
    {
        public ControladorProyecto()
        {
            InitializeComponent();
        }

        private void ControladorProyecto_Load(object sender, EventArgs e)
        {

        }

        public void escribirJSON(List<Proyecto> lista)
        {
            try
            {
                // Serializar la lista actualizada de proyectos y escribir en el archivo JSON
                string jsonString = JsonSerializer.Serialize(lista);
                File.WriteAllText("proyectos.json", jsonString);
            }
            catch (Exception e)
            {
                // Manejar excepciones si es necesario
            }
        }


        public List<Proyecto> leerJSON()
        {
            try
            {
                if (File.Exists("proyectos.json"))
                {
                    string jsonString = File.ReadAllText("proyectos.json");
                    return JsonSerializer.Deserialize<List<Proyecto>>(jsonString);
                }
            }
            catch (Exception e)
            {
                // Manejar excepciones si es necesario
            }
            return new List<Proyecto>();
        }


        void crearEtiqueta(string proyecto, int posicion, int contadorNombre, System.Windows.Forms.GroupBox g)
        {
            System.Windows.Forms.CheckBox LblProyecto = new System.Windows.Forms.CheckBox();
            LblProyecto.AutoSize = true;
            LblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            LblProyecto.Location = new System.Drawing.Point(75, posicion);
            LblProyecto.Name = "lblProyecto";
            LblProyecto.Size = new System.Drawing.Size(291, 20);
            LblProyecto.TabIndex = 1;
            LblProyecto.Text = proyecto;

            g.Controls.Add(LblProyecto);
        }

        public void cargarProyectos(List<Proyecto> lista, System.Windows.Forms.GroupBox g)
        {
            int pos = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(lista[i].Descripcion, pos, i, g);

            }

        }
        public void escribirXML(List<Proyecto> lista)
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

        public void leerXML(List<Proyecto> lista)
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

        private void ordenarProyectosDescripcion(System.Windows.Forms.GroupBox g)
        {
            g.Controls.Clear();
            var listaOrdenada = ListaDatos.ListaProyectos.OrderBy(m => m.Descripcion).ToArray();
            int pos = 0;
            for (int i = 0; i < listaOrdenada.Count(); i++)
            {
                pos = pos + 20;
                crearEtiqueta(listaOrdenada[i].Descripcion, pos, i, g);

            }
        }

        private void ordenarProyectosPresupuesto(string info, System.Windows.Forms.GroupBox g)
        {
            g.Controls.Clear();

            if (info.Equals("inicio"))
            {
                var listaOrdenada = ListaDatos.ListaProyectos.OrderBy(m => m.PresupuestoInicial).ToArray();
                int pos = 0;
                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    pos = pos + 20;
                    crearEtiqueta(listaOrdenada[i].Descripcion, pos, i, g);

                }
            }
            if (info.Equals("fin"))
            {
                var listaOrdenada = ListaDatos.ListaProyectos.OrderByDescending(m => m.PresupuestoInicial).ToArray();
                int pos = 0;
                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    pos = pos + 20;
                    crearEtiqueta(listaOrdenada[i].Descripcion, pos, i, g);

                }
            }

        }

        private void ordenarProyectosFecha(string info, System.Windows.Forms.GroupBox g)
        {
            g.Controls.Clear();

            if (info.Equals("fecha_inicio"))
            {
                var listaOrdenada = ListaDatos.ListaProyectos.OrderBy(m => m.FechaInicio).ToArray();
                int pos = 0;
                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    pos = pos + 20;
                    crearEtiqueta(listaOrdenada[i].Descripcion, pos, i, g);

                }
            }
            if (info.Equals("fecha_fin"))
            {
                var listaOrdenada = ListaDatos.ListaProyectos.OrderByDescending(m => m.FechaFin).ToArray();
                int pos = 0;
                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    pos = pos + 20;
                    crearEtiqueta(listaOrdenada[i].Descripcion, pos, i, g);

                }
            }

        }

        public void ordenarPor(System.Windows.Forms.ComboBox c, System.Windows.Forms.GroupBox g)
        {
            string opcion = c.SelectedItem.ToString();

            switch (opcion)
            {
                case "descripcion":
                    ordenarProyectosDescripcion(g);
                    break;

                case "fecha_inicio":
                    ordenarProyectosFecha("fecha_inicio", g);
                    break;

                case "fecha_fin":
                    ordenarProyectosFecha("fecha_fin", g);
                    break;

                case "presupuesto_inicio":
                    ordenarProyectosPresupuesto("inicio", g);
                    break;

                case "presupuesto_final":
                    ordenarProyectosPresupuesto("fin", g);
                    break;
            }
        }

        private List<System.Windows.Forms.CheckBox> ListaChecked = new List<System.Windows.Forms.CheckBox>();
        public void borrarCheckBoxes(System.Windows.Forms.GroupBox g)
        {
            var checkboxes = g.Controls.OfType<System.Windows.Forms.CheckBox>().Where(x => x.GetType() == typeof(System.Windows.Forms.CheckBox));

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
                if (indice != -1)
                {
                    ListaDatos.ListaProyectos.RemoveAt(indice);
                }
            }

            g.Controls.Clear();
            int pos = 0;
            for (int i = 0; i < ListaDatos.ListaProyectos.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(ListaDatos.ListaProyectos[i].Descripcion, pos, i, g);

            }
        }
    }
}
