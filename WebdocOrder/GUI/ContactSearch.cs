using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebdocOrder.GUI
{
    public partial class ContactSearch : Form
    {
        public ContactSearch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ContactPerson.FindByText(textBox1.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<ContactPerson> ds = dataGridView1.DataSource as List<ContactPerson>;
            Contact c = new Contact(ds[e.RowIndex]);
            c.ShowDialog();
        }
    }
}
