using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoyalCoffeCream.BusinessLogic;

namespace RoyalCoffeCream.View
{
    public partial class FormIngredient : Form
    {
        public FormIngredient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingredient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = IngredientBL.Instance.SelectAll();
        }
    }
}
