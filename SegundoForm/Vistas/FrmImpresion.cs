using SegundoForm.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoForm.Vistas
{
    public partial class FrmImpresion : Form
    {
        public System.Drawing.Printing.PrintDocument Document = new System.Drawing.Printing.PrintDocument();
        public FrmImpresion()
        {
            InitializeComponent();
            Document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(document_PrintPage);
        }

        internal PrintPreviewDialog PrintPreviewDialog1;
        internal System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();

        private void FrmImpresion_Load(object sender, EventArgs e)
        {
            document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(document_PrintPage);
        }

        ControladorEmpleado ce = new ControladorEmpleado();

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0;
            int contador = 3;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            Font font = new Font("Arial", 10);
            yPos = topMargin + (contador * (font.Size + 4));

            e.Graphics.DrawString("LISTADO DE EMPLEADOS", font, Brushes.Black,leftMargin, yPos, new StringFormat());
            contador++;
            List<Empleado> lista = ce.leerJSON();
            lista.ForEach(empleado =>
            {
                yPos = topMargin + (contador * font.Size);
                e.Graphics.DrawString(empleado.Nombre+" "+empleado.Apellido1+" "+empleado.Apellido2, font, Brushes.Black, leftMargin, yPos, new StringFormat());
                contador++;
            });
        }

        public System.Drawing.Printing.PrintDocument GetPrintDocument()
        {
            return document;
        }
    }
}
