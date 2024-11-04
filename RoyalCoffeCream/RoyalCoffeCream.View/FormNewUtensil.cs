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
    public partial class FormNewUtensil : Form
    {
        public FormNewUtensil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNewUtensil_Load(object sender, EventArgs e)
        {
            UpdateComboBoxTamaño();
            UpdateComboBoxEstado();
        }
        private void UpdateComboBoxTamaño()
        {
            comboBoxTamaño.DataSource = SizeBL.Instance.SelectAll();
            comboBoxTamaño.DisplayMember = "Name";
            comboBoxTamaño.ValueMember = "SizeId";
        }
        private void UpdateComboBoxEstado()
        {
            comboBoxEstado.DataSource = StatusBL.Instance.SelectAll();
            comboBoxEstado.DisplayMember = "Name";
            comboBoxEstado.ValueMember = "StatusId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                errorProvider1.SetError(textBoxNombre, "Campo Requerido");
                return;
            }
            errorProvider1.Clear();

            Utensil entity = new Utensil()
            {
                Name = textBoxNombre.Text.Trim(),
                SizeId = (int)comboBoxTamaño.SelectedValue,
                StatusId = (int)comboBoxEstado.SelectedValue,
            };

            if (UtensilBL.Instance.Insert(entity))
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
