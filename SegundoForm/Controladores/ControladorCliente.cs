using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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

        public void ValidarDatosGenerales(System.Windows.Forms.TextBox nombre, RichTextBox direccion, System.Windows.Forms.TextBox ciudad1, System.Windows.Forms.TextBox ciudad2, System.Windows.Forms.TextBox correo, MaskedTextBox cif, System.Windows.Forms.ComboBox accion)
        {
            bool todoBien = true;

            // Validar nombre (textBox1)
            if (!Regex.IsMatch(nombre.Text, "^[a-zA-Z]{1,15}$"))
            {
                nombre.BackColor = System.Drawing.Color.Red;
                todoBien = false;
            }
            else
            {
                nombre.BackColor = System.Drawing.Color.White;
            }

            // Validar dirección (richTextBox1)
            // No se especifica ninguna restricción específica en el enunciado
            // Puedes agregar validaciones adicionales si es necesario

            // Validar ciudad1 (textBox2)
            if (!Regex.IsMatch(ciudad1.Text, "^[a-zA-Z]{1,}$"))
            {
                ciudad1.BackColor = System.Drawing.Color.Red;
                todoBien = false;
            }
            else
            {
                ciudad1.BackColor = System.Drawing.Color.White;
            }

            // Validar ciudad2 (textBox3)
            if (!Regex.IsMatch(ciudad2.Text, "^[a-zA-Z]{1,}$"))
            {
                ciudad2.BackColor = System.Drawing.Color.Red;
                todoBien = false;
            }
            else
            {
                ciudad2.BackColor = System.Drawing.Color.White;
            }

            // Validar correo (textBox4)
            if (!Regex.IsMatch(correo.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                correo.BackColor = System.Drawing.Color.Red;
                todoBien = false;
            }
            else
            {
                correo.BackColor = System.Drawing.Color.White;
            }

            // Validar CIF (maskedTextBox2)
            if (!Regex.IsMatch(cif.Text, @"^[A-Z]\-\d{8}$"))
            {
                cif.BackColor = System.Drawing.Color.Red;
                todoBien = false;
            }else
            {
                cif.BackColor = System.Drawing.Color.White;
            }

            // Validar ComboBox (comboBox1)
            if (accion.SelectedIndex == -1)
            {
                accion.BackColor = System.Drawing.Color.Red;
                todoBien = false;
            }
            else
            {
                accion.BackColor = System.Drawing.Color.White;
            }

            // Mostrar MessageBox según el resultado de la validación
            if (todoBien)
            {
                MessageBox.Show("Todos los datos son válidos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

} 

