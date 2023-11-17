namespace SegundoForm
{
    partial class FrmNuevoEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.tlf = new System.Windows.Forms.Label();
            this.puesto = new System.Windows.Forms.Label();
            this.comentarios = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido2 = new System.Windows.Forms.Label();
            this.apellido1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtTlf = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.numericUpDownSS = new System.Windows.Forms.NumericUpDown();
            this.txtComent = new System.Windows.Forms.RichTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Nuevo Empleado";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(105, 60);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(23, 20);
            this.id.TabIndex = 1;
            this.id.Text = "Id";
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.Location = new System.Drawing.Point(105, 285);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(37, 20);
            this.dni.TabIndex = 2;
            this.dni.Text = "DNI";
            this.dni.Click += new System.EventHandler(this.label3_Click);
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(105, 259);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(157, 20);
            this.fecha.TabIndex = 3;
            this.fecha.Text = "Fecha de nacimeinto";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(105, 234);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(57, 20);
            this.correo.TabIndex = 4;
            this.correo.Text = "Correo";
            // 
            // tlf
            // 
            this.tlf.AutoSize = true;
            this.tlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlf.Location = new System.Drawing.Point(105, 207);
            this.tlf.Name = "tlf";
            this.tlf.Size = new System.Drawing.Size(26, 20);
            this.tlf.TabIndex = 5;
            this.tlf.Text = "Tlf";
            this.tlf.Click += new System.EventHandler(this.label6_Click);
            // 
            // puesto
            // 
            this.puesto.AutoSize = true;
            this.puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puesto.Location = new System.Drawing.Point(105, 179);
            this.puesto.Name = "puesto";
            this.puesto.Size = new System.Drawing.Size(59, 20);
            this.puesto.TabIndex = 6;
            this.puesto.Text = "Puesto";
            // 
            // comentarios
            // 
            this.comentarios.AutoSize = true;
            this.comentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentarios.Location = new System.Drawing.Point(105, 344);
            this.comentarios.Name = "comentarios";
            this.comentarios.Size = new System.Drawing.Size(99, 20);
            this.comentarios.TabIndex = 7;
            this.comentarios.Text = "Comentarios";
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ss.Location = new System.Drawing.Point(105, 313);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(31, 20);
            this.ss.TabIndex = 8;
            this.ss.Text = "SS";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(105, 90);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(65, 20);
            this.nombre.TabIndex = 9;
            this.nombre.Text = "Nombre";
            // 
            // apellido2
            // 
            this.apellido2.AutoSize = true;
            this.apellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido2.Location = new System.Drawing.Point(105, 148);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(74, 20);
            this.apellido2.TabIndex = 10;
            this.apellido2.Text = "Apellido2";
            // 
            // apellido1
            // 
            this.apellido1.AutoSize = true;
            this.apellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido1.Location = new System.Drawing.Point(105, 119);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(74, 20);
            this.apellido1.TabIndex = 11;
            this.apellido1.Text = "Apellido1";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(217, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(217, 119);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(100, 20);
            this.txtApellido1.TabIndex = 14;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(217, 148);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(100, 20);
            this.txtApellido2.TabIndex = 15;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(217, 179);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(100, 20);
            this.txtPuesto.TabIndex = 16;
            // 
            // txtTlf
            // 
            this.txtTlf.Location = new System.Drawing.Point(217, 207);
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(100, 20);
            this.txtTlf.TabIndex = 17;
            this.txtTlf.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(217, 234);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(146, 20);
            this.txtCorreo.TabIndex = 18;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(273, 259);
            this.fechaNacimiento.MaxDate = new System.DateTime(2023, 10, 25, 0, 0, 0, 0);
            this.fechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimiento.TabIndex = 19;
            this.fechaNacimiento.Value = new System.DateTime(2023, 10, 25, 0, 0, 0, 0);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(217, 282);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 20;
            // 
            // numericUpDownSS
            // 
            this.numericUpDownSS.Location = new System.Drawing.Point(217, 313);
            this.numericUpDownSS.Name = "numericUpDownSS";
            this.numericUpDownSS.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSS.TabIndex = 23;
            // 
            // txtComent
            // 
            this.txtComent.Location = new System.Drawing.Point(217, 346);
            this.txtComent.Name = "txtComent";
            this.txtComent.Size = new System.Drawing.Size(241, 73);
            this.txtComent.TabIndex = 24;
            this.txtComent.Text = "";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(518, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 48);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(666, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 48);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(217, 60);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownId.TabIndex = 27;
            // 
            // FrmNuevoEmpleado
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtComent);
            this.Controls.Add(this.numericUpDownSS);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTlf);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.apellido1);
            this.Controls.Add(this.apellido2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.comentarios);
            this.Controls.Add(this.puesto);
            this.Controls.Add(this.tlf);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "FrmNuevoEmpleado";
            this.Text = "FrmNuevoEmpleado";
            this.Load += new System.EventHandler(this.FrmNuevoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label tlf;
        private System.Windows.Forms.Label puesto;
        private System.Windows.Forms.Label comentarios;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido2;
        private System.Windows.Forms.Label apellido1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellido1;
        public System.Windows.Forms.TextBox txtApellido2;
        public System.Windows.Forms.TextBox txtPuesto;
        public System.Windows.Forms.TextBox txtTlf;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.DateTimePicker fechaNacimiento;
        public System.Windows.Forms.TextBox txtDNI;
        public System.Windows.Forms.NumericUpDown numericUpDownSS;
        public System.Windows.Forms.RichTextBox txtComent;
        public System.Windows.Forms.NumericUpDown numericUpDownId;
    }
}