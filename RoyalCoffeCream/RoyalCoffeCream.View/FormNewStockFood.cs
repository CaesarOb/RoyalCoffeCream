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
    public partial class FormNewStockFood : Form
    {
        public FormNewStockFood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStockFood_Load(object sender, EventArgs e)
        {
            UpdateComboBoxComida();
        }
        private void UpdateComboBoxComida()
        {
            comboBoxComida.DataSource = FoodBL.Instance.SelectAll();
            comboBoxComida.DisplayMember = "Name";
            comboBoxComida.ValueMember = "FoodId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCantidad.Text))
            {
                errorProvider1.SetError(textBoxCantidad, "Campo Requerido");
                return;
            }
            errorProvider1.Clear();

            StockFood entity = new StockFood()
            {
                FoodId = (int)comboBoxComida.SelectedValue,
                Quantity = int.Parse(textBoxCantidad.Text.Trim()),
            };

            if (StockFoodBL.Instance.Insert(entity))
            {
                MessageBox.Show("Registro ingresado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al insertar el registro", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
