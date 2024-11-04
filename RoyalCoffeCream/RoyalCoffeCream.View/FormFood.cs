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

namespace RoyalCoffeCream.View
{
    public partial class FormFood : Form
    {
        public FormFood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Food_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = FoodBL.Instance.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNewFood formNuevo = new FormNewFood();

            formNuevo.ShowDialog();
            UpdateGrid();
        }
    }
}
