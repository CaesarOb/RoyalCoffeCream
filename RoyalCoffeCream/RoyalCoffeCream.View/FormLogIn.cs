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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsuario.Text))
            {
                errorProvider1.SetError(textBoxUsuario, "Campo Requerido");
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBoxContraseña.Text))
            {
                errorProvider1.SetError(textBoxContraseña, "Campo Requerido");
                return;
            }
            errorProvider1.Clear();

            string nick = textBoxUsuario.Text;
            string passcode = textBoxContraseña.Text;

            try
            {
             BUser entity = BUserBL.Instance.ValidateSession(passcode, nick);

                if (entity != null)
                {
                    MessageBox.Show("¡Login exitoso!");
                    FormCategory formNuevo = new FormCategory();

                    formNuevo.ShowDialog();
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la validación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
