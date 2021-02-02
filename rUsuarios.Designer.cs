
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
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.AliasTextBox = new System.Windows.Forms.TextBox();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ClaveConfirmTextBox = new System.Windows.Forms.TextBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.IDNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.Location = new System.Drawing.Point(127, 222);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(118, 68);
            this.NuevoButton.TabIndex = 0;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.Nuevo_Click);
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
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(628, 22);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(73, 24);
            this.ActivoCheckBox.TabIndex = 9;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // AliasTextBox
            // 
            this.AliasTextBox.Location = new System.Drawing.Point(110, 56);
            this.AliasTextBox.Name = "AliasTextBox";
            this.AliasTextBox.Size = new System.Drawing.Size(153, 27);
            this.AliasTextBox.TabIndex = 11;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(110, 100);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(257, 27);
            this.NombresTextBox.TabIndex = 12;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(110, 145);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(146, 27);
            this.ClaveTextBox.TabIndex = 13;
            this.ClaveTextBox.TextChanged += new System.EventHandler(this.textBoxClave_TextChanged);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(168, 20);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(34, 27);
            this.BuscarButton.TabIndex = 14;
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(416, 100);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(313, 27);
            this.EmailTextBox.TabIndex = 15;
            // 
            // RolComboBox
            // 
            this.RolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Items.AddRange(new object[] {
            "Adiministrador",
            "Estudiante",
            "Maestro",
            "Ciudadano",
            "Conserje",
            "Pasante"});
            this.RolComboBox.Location = new System.Drawing.Point(594, 60);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(135, 28);
            this.RolComboBox.TabIndex = 16;
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.Location = new System.Drawing.Point(459, 222);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(118, 68);
            this.EliminarButton.TabIndex = 17;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = false;
            this.EliminarButton.Click += new System.EventHandler(this.Eliminar_Click);
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
            // ClaveConfirmTextBox
            // 
            this.ClaveConfirmTextBox.Location = new System.Drawing.Point(416, 142);
            this.ClaveConfirmTextBox.Name = "ClaveConfirmTextBox";
            this.ClaveConfirmTextBox.Size = new System.Drawing.Size(172, 27);
            this.ClaveConfirmTextBox.TabIndex = 19;
            this.ClaveConfirmTextBox.TextChanged += new System.EventHandler(this.textBoxClaveConfirm_TextChanged);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = " ";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(416, 61);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(146, 27);
            this.FechaDateTimePicker.TabIndex = 20;
            this.FechaDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            // IDNumericUpDown1
            // 
            this.IDNumericUpDown1.Location = new System.Drawing.Point(110, 21);
            this.IDNumericUpDown1.Name = "IDNumericUpDown1";
            this.IDNumericUpDown1.Size = new System.Drawing.Size(52, 27);
            this.IDNumericUpDown1.TabIndex = 22;
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(744, 311);
            this.Controls.Add(this.IDNumericUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.ClaveConfirmTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.AliasTextBox);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.NuevoButton);
            this.MaximizeBox = false;
            this.Name = "rUsuarios";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.TextBox AliasTextBox;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ClaveConfirmTextBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown IDNumericUpDown1;
    }
}

