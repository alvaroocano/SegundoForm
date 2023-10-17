using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoForm
{
    public partial class FrmProyectos : Form
    {
        public FrmProyectos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void crearEtiqueta(string proyecto, int posicion, int contadorNombre)
        {
            Label LblProyecto = new System.Windows.Forms.Label();
            LblProyecto.AutoSize = true;
            LblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
            LblProyecto.Location = new System.Drawing.Point(75, posicion);
            LblProyecto.Name = "lblProyecto" + contadorNombre;
            LblProyecto.Size = new System.Drawing.Size(291, 20);
            LblProyecto.TabIndex = 1;
            LblProyecto.Text = proyecto;
            groupBox.Controls.Add(LblProyecto);
        }

        private List<Proyecto> listaProyectos = new List<Proyecto>();
        private void cargarProyectos()
        {
            listaProyectos.Add(new Proyecto("1", "Proyecto D", DateTime.Parse("15-1-2000"), DateTime.Parse("15-2-2000"),"sin empezar", 15.8,3.4, "", 1));
            listaProyectos.Add(new Proyecto("2", "Proyecto C", DateTime.Parse("3-1-2000"), DateTime.Parse("3-2-2000"), "fin", 16.19,2.1, "", 2));
            listaProyectos.Add(new Proyecto("3", "Proyecto E", DateTime.Parse("2-1-2000"), DateTime.Parse("2-2-2000"), "fin", 1.2,1.1, "", 3));
            listaProyectos.Add(new Proyecto("4", "Proyecto A", DateTime.Parse("1-1-2000"), DateTime.Parse("1-2-2000"), "en curso", 0.0,0.0, "", 4));
            listaProyectos.Add(new Proyecto("5", "Proyecto B", DateTime.Parse("12-1-2000"), DateTime.Parse("12-2-2000"), "fin", 5.3,1.9, "", 5));
        }

        private void FrmProyectos_Load(object sender, EventArgs e)
        {
           
            cargarProyectos();

            int pos = 0;
            for (int i = 0; i < listaProyectos.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(listaProyectos[i].Descripcion, pos , i);
                
            }
            
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
            var listaOrdenada = listaProyectos.OrderBy(m => m.Descripcion).ToArray();
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
                var listaOrdenada = listaProyectos.OrderBy(m => m.PresupuestoInicial).ToArray();
                int pos = 0;
                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    pos = pos + 20;
                    crearEtiqueta(listaOrdenada[i].Descripcion, pos, i);

                }
            }
            if (info.Equals("fin"))
            {
                var listaOrdenada = listaProyectos.OrderByDescending(m => m.PresupuestoInicial).ToArray();
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
                var listaOrdenada = listaProyectos.OrderBy(m => m.FechaInicio).ToArray();
                int pos = 0;
                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    pos = pos + 20;
                    crearEtiqueta(listaOrdenada[i].Descripcion, pos, i);

                }
            }
            if (info.Equals("fecha_fin"))
            {
                var listaOrdenada = listaProyectos.OrderByDescending(m => m.FechaFin).ToArray();
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
    }
}
