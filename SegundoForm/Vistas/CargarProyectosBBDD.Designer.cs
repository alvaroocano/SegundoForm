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
            this.baseDatosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDatosDataSet = new SegundoForm.baseDatosDataSet();
            this.baseDatosDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.baseDatosDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(233, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // baseDatosDataSetBindingSource
            // 
            this.baseDatosDataSetBindingSource.DataSource = this.baseDatosDataSet;
            this.baseDatosDataSetBindingSource.Position = 0;
            // 
            // baseDatosDataSet
            // 
            this.baseDatosDataSet.DataSetName = "baseDatosDataSet";
            this.baseDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseDatosDataSetBindingSource1
            // 
            this.baseDatosDataSetBindingSource1.DataSource = this.baseDatosDataSet;
            this.baseDatosDataSetBindingSource1.Position = 0;
            // 
            // CargarProyectosBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 435);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CargarProyectosBBDD";
            this.Text = "CargarProyectosBBDD";
            this.Load += new System.EventHandler(this.CargarProyectosBBDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource baseDatosDataSetBindingSource;
        private baseDatosDataSet baseDatosDataSet;
        private System.Windows.Forms.BindingSource baseDatosDataSetBindingSource1;
    }
}