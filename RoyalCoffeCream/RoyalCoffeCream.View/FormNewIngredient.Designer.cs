namespace RoyalCoffeCream.View
{
    partial class FormNewIngredient
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTamaño = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(631, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 68);
            this.button2.TabIndex = 19;
            this.button2.Text = "CREAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(762, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(250, 130);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(292, 22);
            this.textBoxNombre.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre";
            // 
            // comboBoxTamaño
            // 
            this.comboBoxTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTamaño.FormattingEnabled = true;
            this.comboBoxTamaño.Location = new System.Drawing.Point(250, 175);
            this.comboBoxTamaño.Name = "comboBoxTamaño";
            this.comboBoxTamaño.Size = new System.Drawing.Size(292, 24);
            this.comboBoxTamaño.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tamaño";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(250, 222);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(292, 24);
            this.comboBoxEstado.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Estado";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(250, 271);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(292, 22);
            this.textBoxFecha.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fecha de vencimiento";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNewIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 460);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTamaño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewIngredient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewIngredient";
            this.Load += new System.EventHandler(this.FormNewIngredient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTamaño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}