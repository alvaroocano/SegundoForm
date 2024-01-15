using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegundoForm.Controladores;

namespace SegundoForm.Vistas
{
    public partial class FrmNuevoCliente : Form
    {
        public FrmNuevoCliente()
        {
            InitializeComponent();
            richTextBox2.MouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    cc.anadirMenu(richTextBox2);
                }
            };
        }

        ControladorCliente cc = new ControladorCliente();

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            monthCalendar1.MinDate = DateTime.Now;
            cc.AddBoledDate(monthCalendar1);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cc.mostrarFileDialog(openFileDialog1);
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 99;
            cc.mostrarNombreArchivo(rutaArchivo,openFileDialog1.FileName);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cc.CambiarColor(richTextBox2);
        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            cc.CambiarTipoDeFuente(richTextBox2);
        }
    }
}
