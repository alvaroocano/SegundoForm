namespace SegundoForm.Vistas
{
    partial class FrmComponentesProyectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.proyectos = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAnhadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proyectos
            // 
            this.proyectos.FormattingEnabled = true;
            this.proyectos.Location = new System.Drawing.Point(157, 67);
            this.proyectos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.proyectos.Name = "proyectos";
            this.proyectos.Size = new System.Drawing.Size(132, 21);
            this.proyectos.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(364, 22);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 134);
            this.listBox1.TabIndex = 1;
            // 
            // btnAnhadir
            // 
            this.btnAnhadir.Location = new System.Drawing.Point(210, 342);
            this.btnAnhadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnhadir.Name = "btnAnhadir";
            this.btnAnhadir.Size = new System.Drawing.Size(116, 46);
            this.btnAnhadir.TabIndex = 2;
            this.btnAnhadir.Text = "Añadir Componente";
            this.btnAnhadir.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(390, 342);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(116, 46);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar Componente";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // FrmComponentesProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 448);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAnhadir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.proyectos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmComponentesProyectos";
            this.Text = "FrmComponentesProyectos";
            this.Load += new System.EventHandler(this.FrmComponentesProyectos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox proyectos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAnhadir;
        private System.Windows.Forms.Button btnQuitar;
    }
}