namespace SegundoForm.Vistas
{
    partial class CargarProyectosBBDD
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDatosDataSet = new SegundoForm.baseDatosDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.proyectosTableAdapter = new SegundoForm.baseDatosDataSetTableAdapters.ProyectosTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(46, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(638, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "Proyectos";
            this.proyectosBindingSource.DataSource = this.baseDatosDataSet;
            // 
            // baseDatosDataSet
            // 
            this.baseDatosDataSet.DataSetName = "baseDatosDataSet";
            this.baseDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // proyectosTableAdapter
            // 
            this.proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(359, 378);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(546, 378);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // CargarProyectosBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 435);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CargarProyectosBBDD";
            this.Text = "CargarProyectosBBDD";
            this.Load += new System.EventHandler(this.CargarProyectosBBDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button button1;
        private baseDatosDataSet baseDatosDataSet;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private baseDatosDataSetTableAdapters.ProyectosTableAdapter proyectosTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnImprimir;
    }
}