using RoyalCoffeCream.BusinessLogic;
using RoyalCoffeCream.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalCoffeCream.View
{
    public partial class FormNewCategory : Form
    {
        public FormNewCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                errorProvider1.SetError(textBoxNombre, "Campo Requerido");
                return;
            }
            errorProvider1.Clear();

            Category entity = new Category()
            {
                Name = textBoxNombre.Text.Trim(),
                StatusId = (int)comboBox1.SelectedValue,
            };
            if (CategoryBL.Instance.Insert(entity))
            {
                MessageBox.Show("Registro ingresado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al insertar el registro", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNewCategory_Load(object sender, EventArgs e)
        {
            UpdateComboBox();
        }
        private void UpdateComboBox()
        {
            comboBox1.DataSource = StatusBL.Instance.SelectAll();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "StatusId";
            
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
