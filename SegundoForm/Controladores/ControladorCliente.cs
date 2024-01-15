using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SegundoForm.Controladores
{
    internal class ControladorCliente
    {

        public void CargarImagenConTimer(System.Windows.Forms.ProgressBar progressBar, PictureBox pictureBox, FileDialog fd)
        {
            var rutaAArchivo = string.Empty;
            var timer1 = new Timer();

            fd.ShowDialog(); 

            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar.Maximum = 10;

            timer1.Tick += (timerSender, timerArgs) =>
            {
                if (progressBar.Value != progressBar.Maximum)
                {
                    progressBar.Show();
                    progressBar.Value++;
                }
                else
                {
                    timer1.Stop();
                    progressBar.Hide();

                    rutaAArchivo = fd.FileName;
                    pictureBox.Image = Image.FromFile(rutaAArchivo);

                    string carpetaDestino = ".//imagenes//";
                    string nombreArchivoSeguro = fd.FileName;
                    string rutaDestino = Path.Combine(carpetaDestino, nombreArchivoSeguro);

                    if (!File.Exists(rutaDestino))
                    {
                        File.Copy(rutaAArchivo, rutaDestino);
                    }
                    
                }
            };

            
        }






        public void AddBoledDate(MonthCalendar monthCalendar)
        {
            monthCalendar.BoldedDates = new DateTime[] { DateTime.Today };
            monthCalendar.UpdateBoldedDates();
        }

        public void anadirMenu(RichTextBox rtb)
        {
            
            // Configurar el ContextMenuStrip
            System.Windows.Forms.ContextMenuStrip cms = new ContextMenuStrip();
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Cortar", null);
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Copiar", null);
            ToolStripMenuItem menuItem3 = new ToolStripMenuItem("Pegar", null);
            cms.Items.Add(menuItem1);
            cms.Items.Add(menuItem2);
            cms.Items.Add(menuItem3);

            // Asociar el ContextMenuStrip con la RichTextBox
            rtb.ContextMenuStrip = cms;
        }

        public void CambiarColor(RichTextBox rtb)
        {
            // Crear un nuevo cuadro de diálogo de color
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Mostrar el cuadro de diálogo y cambiar el color si el usuario hace clic en OK
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    if (rtb.SelectionLength > 0)
                    {
                        rtb.SelectionColor = colorDialog.Color;
                    }
                }
            }
        }

        public void CambiarTipoDeFuente(RichTextBox rtb)
        {
            // Crear un nuevo cuadro de diálogo de fuente
            using (FontDialog fontDialog = new FontDialog())
            {
                // Mostrar el cuadro de diálogo y cambiar la fuente si el usuario hace clic en OK
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    if (rtb.SelectionLength > 0)
                    {
                        rtb.SelectionFont = fontDialog.Font;
                    }
                }
            }
        }
    }

} 

