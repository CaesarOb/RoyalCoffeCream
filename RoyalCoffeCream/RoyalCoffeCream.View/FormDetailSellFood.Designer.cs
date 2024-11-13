namespace RoyalCoffeCream.View
{
    partial class FormDetailSellFood
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
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCajero = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(743, 214);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 34);
            this.buttonEliminar.TabIndex = 31;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(763, 428);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(32, 16);
            this.labelTotal.TabIndex = 29;
            this.labelTotal.Text = "total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "TOTAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cajero";
            // 
            // comboBoxCajero
            // 
            this.comboBoxCajero.FormattingEnabled = true;
            this.comboBoxCajero.Location = new System.Drawing.Point(43, 197);
            this.comboBoxCajero.Name = "comboBoxCajero";
            this.comboBoxCajero.Size = new System.Drawing.Size(209, 24);
            this.comboBoxCajero.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(781, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 46);
            this.button2.TabIndex = 26;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(86, 119);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(292, 24);
            this.comboBoxFood.TabIndex = 25;
            // 
            // buttonPagar
            // 
            this.buttonPagar.Location = new System.Drawing.Point(579, 82);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(189, 61);
            this.buttonPagar.TabIndex = 24;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(443, 197);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(82, 22);
            this.numericUpDownCantidad.TabIndex = 23;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(556, 196);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.ReadOnly = true;
            this.textBoxSubTotal.Size = new System.Drawing.Size(157, 22);
            this.textBoxSubTotal.TabIndex = 21;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(267, 197);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.ReadOnly = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(158, 22);
            this.textBoxPrecio.TabIndex = 22;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(743, 158);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 33);
            this.buttonAgregar.TabIndex = 20;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Producto";
            // 
            // FormDetailSellFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCajero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxFood);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailSellFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailSellFood";
            this.Load += new System.EventHandler(this.FormDetailSellFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCajero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.Button buttonPagar;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}