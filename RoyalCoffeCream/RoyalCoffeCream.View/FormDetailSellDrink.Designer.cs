namespace RoyalCoffeCream.View
{
    partial class FormDetailSellDrink
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.comboBoxDrink = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxCajero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(738, 164);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 33);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(262, 203);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(158, 22);
            this.textBoxPrecio.TabIndex = 7;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(551, 202);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.ReadOnly = true;
            this.textBoxSubTotal.Size = new System.Drawing.Size(157, 22);
            this.textBoxSubTotal.TabIndex = 7;
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(438, 203);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(82, 22);
            this.numericUpDownCantidad.TabIndex = 8;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonPagar
            // 
            this.buttonPagar.Location = new System.Drawing.Point(574, 88);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(189, 61);
            this.buttonPagar.TabIndex = 9;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // comboBoxDrink
            // 
            this.comboBoxDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Location = new System.Drawing.Point(81, 125);
            this.comboBoxDrink.Name = "comboBoxDrink";
            this.comboBoxDrink.Size = new System.Drawing.Size(292, 24);
            this.comboBoxDrink.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(776, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxCajero
            // 
            this.comboBoxCajero.FormattingEnabled = true;
            this.comboBoxCajero.Location = new System.Drawing.Point(38, 203);
            this.comboBoxCajero.Name = "comboBoxCajero";
            this.comboBoxCajero.Size = new System.Drawing.Size(209, 24);
            this.comboBoxCajero.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cajero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "TOTAL:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(758, 434);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(32, 16);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "total";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(738, 220);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 34);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // FormDetailSellDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 468);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCajero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxDrink);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailSellDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSellDrink";
            this.Load += new System.EventHandler(this.FormSellDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Button buttonPagar;
        private System.Windows.Forms.ComboBox comboBoxDrink;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxCajero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonEliminar;
    }
}