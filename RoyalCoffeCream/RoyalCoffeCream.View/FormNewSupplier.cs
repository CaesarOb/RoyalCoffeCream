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
    public partial class FormNewSupplier : Form
    {
        public FormNewSupplier()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var textBoxes = new List<TextBox> { textBoxNombre, textBoxContacto, textBoxTelefono };
            int i = 0;

            while (i < textBoxes.Count)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    errorProvider1.SetError(textBoxes[i], "Campo Requerido");
                    return;
                }
                else
                {
                    errorProvider1.SetError(textBoxes[i], string.Empty);
                }
                i++;
            }

            Supplier entity = new Supplier()
            {
                Name = textBoxNombre.Text.Trim(),
                ContactName = textBoxContacto.Text.Trim(),
                Phone = textBoxTelefono.Text.Trim(),
                Address = textBoxDireccion.Text.Trim(),
                StatusId = (int)comboBox1.SelectedValue,
            };
            if (SupplierBL.Instance.Insert(entity))
            {
                MessageBox.Show("Registro ingresado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al insertar el registro", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNewSupplier_Load(object sender, EventArgs e)
        {
            UpdateComboBox();
        }
        private void UpdateComboBox()
        {
            comboBox1.DataSource = StatusBL.Instance.SelectAll();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "StatusId";
        }
    }
}
