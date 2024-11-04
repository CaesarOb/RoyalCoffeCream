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
    public partial class FormStockFood : Form
    {
        public FormStockFood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStockFood_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = StockFoodBL.Instance.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNewStockFood formNuevo = new FormNewStockFood();

            formNuevo.ShowDialog();

            UpdateGrid();
        }
    }
}
