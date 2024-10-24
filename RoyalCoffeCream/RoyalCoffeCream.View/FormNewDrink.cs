using RoyalCoffeCream.BusinessLogic;
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
            UpdateComboBoxStado();
        }
        private void UpdateComboBoxTamaño()
        {
            comboBoxTamaño.DataSource = SizeBL.Instance.SelectAll();
            comboBoxTamaño.DisplayMember = "Name";
            comboBoxTamaño.ValueMember = "SizeId";

        }
        private void UpdateComboBoxCategoria()
        {
            comboBoxTamaño.DataSource = CategoryBL.Instance.SelectAll();
            comboBoxTamaño.DisplayMember = "Name";
            comboBoxTamaño.ValueMember = "CategoryId";

        }
        private void UpdateComboBoxStado()
        {
            comboBoxTamaño.DataSource = StatusProductBL.Instance.SelectAll();
            comboBoxTamaño.DisplayMember = "Name";
            comboBoxTamaño.ValueMember = "StatusProductId";

        }
    }
}
