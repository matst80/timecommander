using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebdocOrder.GUI
{
    public partial class CustomerGrid : UserControl
    {
        public CustomerGrid()
        {
            InitializeComponent();
        }

        private void CustomerGrid_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = WebdocOrder.Customer.GetList<WebdocOrder.Customer>();
            
        }
    }
}
