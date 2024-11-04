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
    public partial class FormRecord : Form
    {
        public FormRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRecord_Load(object sender, EventArgs e)
        {
            UpdateGride();
        }
        private void UpdateGride()
        {
            dataGridView1.DataSource = RecordBL.Instance.SelectAll();
        }
    }
}
