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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RoyalCoffeCream.View
{
    public partial class FormDetailSellFood : Form
    {

        private List<VentaViewModel> _car = new List<VentaViewModel>();
        public FormDetailSellFood()
        {
            InitializeComponent();
        }

        private void FormDetailSellFood_Load(object sender, EventArgs e)
        {
            UpdateGrip();
            UpdateComboBoxFood();
            UpdateComboBoxCajero();

            comboBoxFood.SelectedIndexChanged += ComboBoxFood_SelectedIndexChanged;
            numericUpDownCantidad.ValueChanged += NumericUpDownCantidad_ValueChanged;
        }
        private void UpdateGrip()
        {
            dataGridView1.DataSource = _car.ToList();
        }
        private void UpdateComboBoxFood()
        {
            comboBoxFood.DataSource = FoodBL.Instance.SelectAll();
            comboBoxFood.DisplayMember = "Name";
            comboBoxFood.ValueMember = "FoodId";
        }
        private void ComboBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFood = comboBoxFood.SelectedItem as Food;

            if (selectedFood != null)
            {
                textBoxPrecio.Text = selectedFood.Price.ToString("C");
                UpdateTotal();
            }
        }
        private void UpdateComboBoxCajero()
        {
            comboBoxCajero.DataSource = BUserBL.Instance.SelectAll();
            comboBoxCajero.DisplayMember = "Nick";
            comboBoxCajero.ValueMember = "UserId";
        }
        private void NumericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }
        private void UpdateTotal()
        {
            var selectedFood = comboBoxFood.SelectedItem as Food;
            if (selectedFood != null)
            {
                decimal price = selectedFood.Price;
                int quantity = (int)numericUpDownCantidad.Value;
                decimal total = price * quantity;

                textBoxSubTotal.Text = total.ToString("C");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            var selectedFood = comboBoxFood.SelectedItem as Food;
            if (selectedFood != null)
            {
                decimal price = selectedFood.Price;
                int quantity = (int)numericUpDownCantidad.Value;
                decimal subtotal = price * quantity;

                VentaViewModel entity = new VentaViewModel()
                {
                    ProductId = selectedFood.FoodId,
                    Name = selectedFood.Name,
                    Price = price,
                    Quantity = quantity,
                    Subtotal = subtotal
                };

                VentaViewModel result = _car.FirstOrDefault(x => x.ProductId.Equals(entity.ProductId));
                if (result != null)
                {
                    result.Quantity += entity.Quantity;
                    result.Subtotal = result.Quantity * result.Price;
                }
                else
                {
                    _car.Add(entity);
                }

                UpdateGrip();

                decimal total = _car.Sum(x => x.Subtotal);
                labelTotal.Text = total.ToString("C2");
            }
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            try
            {
                var sellFood = new SellFood
                {
                    SellDate = DateTime.Now,
                    Price = _car.Sum(x => x.Subtotal),
                    UserId = Convert.ToInt32(comboBoxCajero.SelectedValue) 
                };

                int sellFoodId = SellFoodBL.Instance.Insert(sellFood);

                foreach (var item in _car)
                {
                    if (item.ProductId == 0 || item.Quantity <= 0 || item.Subtotal <= 0)
                    {
                        MessageBox.Show("Hay un problema con los datos del carrito.");
                        return;
                    }

                    var detailsSellFood = new DetailsSellFood
                    {
                        SellFoodId = sellFoodId,
                        FoodId = item.ProductId,
                        Quantity = item.Quantity,
                        Total = item.Subtotal,
                        StatusFactureId = 1
                    };

                    try
                    {
                        DetailsSellFoodBL.Instance.Insert(detailsSellFood);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar detalle de venta: {ex.Message}");
                    }
                }

                MessageBox.Show("Pago realizado con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _car.Clear();
                dataGridView1.DataSource = null;
                labelTotal.Text = "0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _car.Clear();
                dataGridView1.DataSource = null;
                labelTotal.Text = "0.00";
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int selectedProductId = (int)dataGridView1.CurrentRow.Cells["ProductId"].Value;

                var itemToRemove = _car.FirstOrDefault(x => x.ProductId == selectedProductId);
                if (itemToRemove != null)
                {
                    _car.Remove(itemToRemove);
                }

                UpdateGrip();
                decimal total = _car.Sum(x => x.Subtotal);
                labelTotal.Text = total.ToString("C2");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
