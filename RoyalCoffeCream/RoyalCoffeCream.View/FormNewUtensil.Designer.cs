namespace RoyalCoffeCream.View
{
    partial class FormNewUtensil
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
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxTamaño = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(153, 262);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(292, 24);
            this.comboBoxEstado.TabIndex = 50;
            // 
            // comboBoxTamaño
            // 
            this.comboBoxTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTamaño.FormattingEnabled = true;
            this.comboBoxTamaño.Location = new System.Drawing.Point(153, 215);
            this.comboBoxTamaño.Name = "comboBoxTamaño";
            this.comboBoxTamaño.Size = new System.Drawing.Size(292, 24);
            this.comboBoxTamaño.TabIndex = 49;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(153, 170);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(292, 22);
            this.textBoxNombre.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(549, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 68);
            this.button2.TabIndex = 47;
            this.button2.Text = "CREAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(681, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 46);
            this.button1.TabIndex = 46;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tamaño";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nombre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNewUtensil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxTamaño);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewUtensil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewUtensil";
            this.Load += new System.EventHandler(this.FormNewUtensil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxTamaño;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}