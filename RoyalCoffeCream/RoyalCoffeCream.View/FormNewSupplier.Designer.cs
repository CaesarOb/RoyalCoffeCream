namespace RoyalCoffeCream.View
{
    partial class FormNewSupplier
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
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(750, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 68);
            this.button2.TabIndex = 11;
            this.button2.Text = "CREAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(213, 122);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(292, 22);
            this.textBoxNombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(863, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.Location = new System.Drawing.Point(213, 167);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(292, 22);
            this.textBoxContacto.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre De Contacto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(213, 207);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(292, 22);
            this.textBoxTelefono.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefono";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(213, 251);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(292, 22);
            this.textBoxDireccion.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Direccion";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 474);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewSupplier";
            this.Load += new System.EventHandler(this.FormNewSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}