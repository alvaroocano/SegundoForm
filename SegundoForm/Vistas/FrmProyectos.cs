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
using SegundoForm.Controladores;
using System.Drawing.Printing;

namespace SegundoForm
{

    
    public partial class FrmProyectos : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        public FrmProyectos(string codigo, string descripcion, DateTime fechaInicio, DateTime fechaFin, string estado, double presupuestoInicial, double presupuestoActual, string cambios, int codCliente)
        {
            InitializeComponent();

        }

        ControladorProyecto cp = new ControladorProyecto();

        public FrmProyectos()
        {
            InitializeComponent();
            groupBox.Controls.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void FrmProyectos_Load(object sender, EventArgs e)
        {
            groupBox.Controls.Clear();

            List<Proyecto> lista = new List<Proyecto>();
            lista = cp.leerJSON();
            cp.cargarProyectos(lista, groupBox);

            printDocument1.PrintPage += new
            PrintPageEventHandler(printDocument1_PrintPage);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //captura la pantalla
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            Bitmap memoryImage = new Bitmap(s.Width,
            s.Height, myGraphics);
            Graphics memoryGraphics =
            Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0,
            s);
            //dibuja la pantalla en el documento
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

            private void btnOrdenar_Click(object sender, EventArgs e)
        {
            
        }


        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            cp.ordenarPor(select, groupBox);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            cp.borrarCheckBoxes(groupBox);

           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cp.escribirXML(ListaDatos.ListaProyectos);
            cp.escribirXML(ListaDatos.ListaProyectos);
        }
    }
    public static class ListaDatos
    {
        public static List<Proyecto> ListaProyectos = new List<Proyecto>();
    }
}
