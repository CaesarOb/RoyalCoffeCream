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
    public partial class FormNewEmployee : Form
    {
        public FormNewEmployee()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

            Employee entity = new Employee()
            {
                FullName = textBoxNombre.Text.Trim(),
                Phone = textBoxTelefono.Text.Trim(),
                DUI = textBoxDUI.Text.Trim(),
                StatusId = (int)comboBoxEstado.SelectedValue,
            };
            if (EmployeeBL.Instance.Insert(entity))
            {
                MessageBox.Show("Registro ingresado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al insertar el registro", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNewEmployee_Load(object sender, EventArgs e)
        {
            UpdateComboBox();
        }
        private void UpdateComboBox()
        {
            comboBoxEstado.DataSource = StatusBL.Instance.SelectAll();
            comboBoxEstado.DisplayMember = "Name";
            comboBoxEstado.ValueMember = "StatusId";

        }
    }
}
