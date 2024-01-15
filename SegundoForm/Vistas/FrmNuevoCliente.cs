﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            cc.CargarImagenConTimer(progressBar1, pictureBox1, openFileDialog1);
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