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
            this.baseDatosDataSet1 = new SegundoForm.baseDatosDataSet1();
            this.proyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectosTableAdapter = new SegundoForm.baseDatosDataSet1TableAdapters.ProyectosTableAdapter();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presupuestoInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presupuestoActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambiosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.presupuestoInicialDataGridViewTextBoxColumn,
            this.presupuestoActualDataGridViewTextBoxColumn,
            this.cambiosDataGridViewTextBoxColumn,
            this.codClienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proyectosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(638, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // baseDatosDataSet1
            // 
            this.baseDatosDataSet1.DataSetName = "baseDatosDataSet1";
            this.baseDatosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectosBindingSource
            // 
            this.proyectosBindingSource.DataMember = "Proyectos";
            this.proyectosBindingSource.DataSource = this.baseDatosDataSet1;
            // 
            // proyectosTableAdapter
            // 
            this.proyectosTableAdapter.ClearBeforeFill = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // presupuestoInicialDataGridViewTextBoxColumn
            // 
            this.presupuestoInicialDataGridViewTextBoxColumn.DataPropertyName = "presupuestoInicial";
            this.presupuestoInicialDataGridViewTextBoxColumn.HeaderText = "presupuestoInicial";
            this.presupuestoInicialDataGridViewTextBoxColumn.Name = "presupuestoInicialDataGridViewTextBoxColumn";
            // 
            // presupuestoActualDataGridViewTextBoxColumn
            // 
            this.presupuestoActualDataGridViewTextBoxColumn.DataPropertyName = "presupuestoActual";
            this.presupuestoActualDataGridViewTextBoxColumn.HeaderText = "presupuestoActual";
            this.presupuestoActualDataGridViewTextBoxColumn.Name = "presupuestoActualDataGridViewTextBoxColumn";
            // 
            // cambiosDataGridViewTextBoxColumn
            // 
            this.cambiosDataGridViewTextBoxColumn.DataPropertyName = "cambios";
            this.cambiosDataGridViewTextBoxColumn.HeaderText = "cambios";
            this.cambiosDataGridViewTextBoxColumn.Name = "cambiosDataGridViewTextBoxColumn";
            // 
            // codClienteDataGridViewTextBoxColumn
            // 
            this.codClienteDataGridViewTextBoxColumn.DataPropertyName = "codCliente";
            this.codClienteDataGridViewTextBoxColumn.HeaderText = "codCliente";
            this.codClienteDataGridViewTextBoxColumn.Name = "codClienteDataGridViewTextBoxColumn";
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
            // CargarProyectosBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CargarProyectosBBDD";
            this.Text = "CargarProyectosBBDD";
            this.Load += new System.EventHandler(this.CargarProyectosBBDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private baseDatosDataSet1 baseDatosDataSet1;
        private System.Windows.Forms.BindingSource proyectosBindingSource;
        private baseDatosDataSet1TableAdapters.ProyectosTableAdapter proyectosTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presupuestoInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presupuestoActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cambiosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}