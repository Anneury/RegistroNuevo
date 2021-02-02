
namespace ProyectoNuevoRegistro
{
    partial class rUsuarios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rUsuarios));
            this.Nuevo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxClaveConfirm = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.Location = new System.Drawing.Point(127, 222);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(118, 68);
            this.Nuevo.TabIndex = 0;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.Location = new System.Drawing.Point(292, 222);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(118, 68);
            this.Guardar.TabIndex = 1;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clave ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Roll";
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Location = new System.Drawing.Point(628, 22);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(73, 24);
            this.checkBoxActivo.TabIndex = 9;
            this.checkBoxActivo.Text = "Activo";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.Location = new System.Drawing.Point(110, 60);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(153, 27);
            this.textBoxAlias.TabIndex = 11;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(110, 100);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(257, 27);
            this.textBoxNombres.TabIndex = 12;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(110, 142);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(146, 27);
            this.textBoxClave.TabIndex = 13;
            this.textBoxClave.TextChanged += new System.EventHandler(this.textBoxClave_TextChanged);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.Location = new System.Drawing.Point(168, 20);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(34, 27);
            this.Buscar.TabIndex = 14;
            this.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(416, 100);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(313, 27);
            this.textBoxEmail.TabIndex = 15;
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Adiministrador",
            "Estudiante",
            "Maestro",
            "Ciudadano",
            "Conserje",
            "Pasante"});
            this.comboBoxRol.Location = new System.Drawing.Point(594, 60);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(135, 28);
            this.comboBoxRol.TabIndex = 16;
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Location = new System.Drawing.Point(459, 222);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(118, 68);
            this.Eliminar.TabIndex = 17;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Confirmar Clave";
            // 
            // textBoxClaveConfirm
            // 
            this.textBoxClaveConfirm.Location = new System.Drawing.Point(416, 142);
            this.textBoxClaveConfirm.Name = "textBoxClaveConfirm";
            this.textBoxClaveConfirm.Size = new System.Drawing.Size(172, 27);
            this.textBoxClaveConfirm.TabIndex = 19;
            this.textBoxClaveConfirm.TextChanged += new System.EventHandler(this.textBoxClaveConfirm_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(416, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 27);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idNumericUpDown1
            // 
            this.idNumericUpDown1.Location = new System.Drawing.Point(110, 21);
            this.idNumericUpDown1.Name = "idNumericUpDown1";
            this.idNumericUpDown1.Size = new System.Drawing.Size(52, 27);
            this.idNumericUpDown1.TabIndex = 22;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(744, 311);
            this.Controls.Add(this.idNumericUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxClaveConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.textBoxAlias);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.MaximizeBox = false;
            this.Name = "RegistroUsuario";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxClaveConfirm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown idNumericUpDown1;
    }
}

