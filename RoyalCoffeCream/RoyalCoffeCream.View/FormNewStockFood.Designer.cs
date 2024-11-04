namespace RoyalCoffeCream.View
{
    partial class FormNewStockFood
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
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxComida = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(148, 249);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(292, 22);
            this.textBoxCantidad.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Comida";
            // 
            // comboBoxComida
            // 
            this.comboBoxComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComida.FormattingEnabled = true;
            this.comboBoxComida.Location = new System.Drawing.Point(148, 200);
            this.comboBoxComida.Name = "comboBoxComida";
            this.comboBoxComida.Size = new System.Drawing.Size(292, 24);
            this.comboBoxComida.TabIndex = 63;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(456, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 68);
            this.button2.TabIndex = 62;
            this.button2.Text = "CREAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(604, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 46);
            this.button1.TabIndex = 61;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormStockFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxComida);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStockFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStockFood";
            this.Load += new System.EventHandler(this.FormStockFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxComida;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}