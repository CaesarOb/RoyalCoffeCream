using RoyalCoffeCream.BusinessLogic;
using System;
using System.Windows.Forms;

namespace RoyalCoffeCream.View
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = CategoryBL.Instance.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FormNewCategory formNuevo = new FormNewCategory();

            formNuevo.ShowDialog();

            UpdateGrid();
        }
    }
}
