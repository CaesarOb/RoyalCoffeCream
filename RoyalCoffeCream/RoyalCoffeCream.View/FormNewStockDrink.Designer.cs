namespace RoyalCoffeCream.View
{
    partial class FormNewStockDrink
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxBebida = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Bebida";
            // 
            // comboBoxBebida
            // 
            this.comboBoxBebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBebida.FormattingEnabled = true;
            this.comboBoxBebida.Location = new System.Drawing.Point(137, 180);
            this.comboBoxBebida.Name = "comboBoxBebida";
            this.comboBoxBebida.Size = new System.Drawing.Size(292, 24);
            this.comboBoxBebida.TabIndex = 56;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(445, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 68);
            this.button2.TabIndex = 55;
            this.button2.Text = "CREAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(593, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 46);
            this.button1.TabIndex = 54;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(137, 229);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(292, 22);
            this.textBoxCantidad.TabIndex = 60;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNewStockDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 470);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxBebida);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNewStockDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewStockDrink";
            this.Load += new System.EventHandler(this.FormNewStockDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxBebida;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}