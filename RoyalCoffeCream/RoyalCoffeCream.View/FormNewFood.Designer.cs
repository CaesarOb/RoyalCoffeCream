namespace RoyalCoffeCream.View
{
    partial class FormNewFood
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
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(657, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 68);
            this.button2.TabIndex = 17;
            this.button2.Text = "CREAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(808, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(264, 257);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(292, 24);
            this.comboBoxCategoria.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Categoria";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(264, 215);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(292, 22);
            this.textBoxPrecio.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Precio";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(264, 122);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(292, 72);
            this.textBoxDescripcion.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Descripcion";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(264, 297);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(292, 24);
            this.comboBoxEstado.TabIndex = 33;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(264, 81);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(292, 22);
            this.textBoxNombre.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 469);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewFood";
            this.Load += new System.EventHandler(this.FormNewFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}