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
    public partial class FormNewDrink : Form
    {
        public FormNewDrink()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNewDrink_Load(object sender, EventArgs e)
        {
            UpdateComboBoxTamaño();
            UpdateComboBoxCategoria();
            UpdateComboBoxEstado();
        }
        private void UpdateComboBoxTamaño()
        {
            comboBoxTamaño.DataSource = SizeBL.Instance.SelectAll();
            comboBoxTamaño.DisplayMember = "Name";
            comboBoxTamaño.ValueMember = "SizeId";
            


        }
        private void UpdateComboBoxCategoria()
        {
            comboBoxCategoria.DataSource = CategoryBL.Instance.SelectAll();
            comboBoxCategoria.DisplayMember = "Name";
            comboBoxCategoria.ValueMember = "CategoryId";

        }
        private void UpdateComboBoxEstado()
        {
            comboBoxEstado.DataSource = StatusProductBL.Instance.SelectAll();
            comboBoxEstado.DisplayMember = "Name";
            comboBoxEstado.ValueMember = "StatusProductId";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                errorProvider1.SetError(textBoxNombre, "Campo Requerido");
                return;
            }
            errorProvider1.Clear();

            if (!Decimal.TryParse(textBoxPrecio.Text.Trim(), out Decimal price))
            {
                errorProvider1.SetError(textBoxPrecio, "Ingrese un número válido para el precio.");
                return;
            }
            errorProvider1.Clear();

            Drink entity = new Drink()
            {
                Name = textBoxNombre.Text.Trim(),
                Description = textBoxDescripcion.Text.Trim(),
                Price = Decimal.Parse(textBoxPrecio.Text.Trim()),
                SizeId = (int)comboBoxTamaño.SelectedValue,
                CategoryId = (int)comboBoxCategoria.SelectedValue,
                StatusProductId = (int)comboBoxEstado.SelectedValue,
            };
            if (DrinkBL.Instance.Insert(entity))
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
