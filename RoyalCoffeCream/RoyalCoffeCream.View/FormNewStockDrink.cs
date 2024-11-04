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
    public partial class FormNewStockDrink : Form
    {
        public FormNewStockDrink()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCantidad.Text))
            {
                errorProvider1.SetError(textBoxCantidad, "Campo Requerido");
                return;
            }
            errorProvider1.Clear();

            StockDrink entity = new StockDrink()
            {
                DrinkId = (int)comboBoxBebida.SelectedValue,
                Quantity = int.Parse(textBoxCantidad.Text.Trim()),
            };

            if (StockDrinkBL.Instance.Insert(entity))
            {
                MessageBox.Show("Registro ingresado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al insertar el registro", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNewStockDrink_Load(object sender, EventArgs e)
        {
            UpdateComboBoxBebida();
        }
        private void UpdateComboBoxBebida()
        {
            comboBoxBebida.DataSource = DrinkBL.Instance.SelectAll();
            comboBoxBebida.DisplayMember = "Name";
            comboBoxBebida.ValueMember = "DrinkId";
        }
    }
}
