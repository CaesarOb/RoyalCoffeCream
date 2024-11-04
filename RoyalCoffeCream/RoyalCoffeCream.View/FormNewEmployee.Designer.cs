namespace RoyalCoffeCream.View
{
    partial class FormNewEmployee
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
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDUI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(653, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 68);
            this.button2.TabIndex = 11;
            this.button2.Text = "CREAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(227, 283);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(292, 24);
            this.comboBoxEstado.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(227, 131);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(292, 22);
            this.textBoxNombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Completo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(763, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(227, 181);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(292, 22);
            this.textBoxTelefono.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefono";
            // 
            // textBoxDUI
            // 
            this.textBoxDUI.Location = new System.Drawing.Point(227, 231);
            this.textBoxDUI.Name = "textBoxDUI";
            this.textBoxDUI.Size = new System.Drawing.Size(292, 22);
            this.textBoxDUI.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "DUI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 462);
            this.Controls.Add(this.textBoxDUI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewEmployee";
            this.Load += new System.EventHandler(this.FormNewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDUI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}