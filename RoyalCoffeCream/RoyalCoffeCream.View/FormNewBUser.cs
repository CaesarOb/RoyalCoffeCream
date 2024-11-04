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
    public partial class FormNewBUser : Form
    {
        public FormNewBUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNewBUser_Load(object sender, EventArgs e)
        {
            UpdateComboBoxEmpleado();
            UpdateComboBoxTipo();
            UpdateComboBoxEstado();
        }
        private void UpdateComboBoxEmpleado()
        {
            comboBoxEmpleado.DataSource = EmployeeBL.Instance.SelectAll();
            comboBoxEmpleado.DisplayMember = "FullName";
            comboBoxEmpleado.ValueMember = "EmployeeId";
        }
        private void UpdateComboBoxTipo()
        {
            comboBoxUsuario.DataSource = UserTypeBL.Instance.SelectAll();
            comboBoxUsuario.DisplayMember = "AccessLevel";
            comboBoxUsuario.ValueMember = "UserTypeId";
        }
        private void UpdateComboBoxEstado()
        {
            comboBoxEstado.DataSource = StatusBL.Instance.SelectAll();
            comboBoxEstado.DisplayMember = "Name";
            comboBoxEstado.ValueMember = "StatusId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNick.Text))
            {
                errorProvider1.SetError(textBoxNick, "Campo Requerido");
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBoxContraseña.Text))
            {
                errorProvider1.SetError(textBoxContraseña, "Campo Requerido");
                return;
            }
            errorProvider1.Clear();

            BUser entity = new BUser()
            {
                Passcode = textBoxContraseña.Text.Trim(),
                Nick = textBoxNick.Text.Trim(),
                EmployeeId = (int)comboBoxEmpleado.SelectedValue,
                UserTypeId = (int)comboBoxUsuario.SelectedValue,
                StatusId = (int)comboBoxEstado.SelectedValue,
            };
            if (BUserBL.Instance.Insert(entity))
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
