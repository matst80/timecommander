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
    public partial class Todo : Form
    {
        public Todo()
        {
            InitializeComponent();
        }
        public int CustomerId;
        public int ProjectId;
        
        public Todo(WebdocOrder.Customer c) : this()
        {
            CustomerId = c.Id;
        }

        public Todo(WebdocOrder.ProjectOrder po)
            : this()
        {
            CustomerId = po.CustomerId;
            ProjectId = po.Id;
        }

        private void Todo_Load(object sender, EventArgs e)
        {
            foreach (var user in WebdocOrder.DAL.InternalUser.GetUsers())
            {
                comboBox1.Items.Add(user);
            }
            if (ProjectId > 0)
            {
                orderDropdown1.EditValue = ProjectId;
                ProjectOrder po = new ProjectOrder(ProjectId);
                companyDropdown1.EditValue = po.CustomerId;
                orderDropdown1.CurrentCustomer = po.CustomerId;
            }
            else
            {
                if (CustomerId > 0)
                    companyDropdown1.EditValue = CustomerId;
            }
            enumComments();
        }

        private void enumComments()
        {
            List<WebdocOrder.Todo> t;
            if (ProjectId>0)
                t = WebdocOrder.Todo.GetByProjectId(ProjectId);
            else
            t = WebdocOrder.Todo.GetByCustomerId(CustomerId);
            t.Reverse();
            dataGridView1.DataSource = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebdocOrder.Todo t = currentTodo;
            if (currentTodo==null)
                t = new WebdocOrder.Todo();
            
            if (comboBox1.SelectedItem != null)
                t.UserId = ((WebdocOrder.DAL.InternalUser)comboBox1.SelectedItem).Id;
            else 
                t.UserId = 0;
            t.CustomerId = (int)companyDropdown1.EditValue;
            if (orderDropdown1.EditValue!=null)
                t.ProjectId = (int)orderDropdown1.EditValue;
            //t.UserId = (int)comboBox1.SelectedValue;
            t.Title = textBox2.Text;
            t.Comment = richEditControl1.RtfText;
            t.TextComment = richEditControl1.Text;
            t.SendDate = DateTime.Now;
            t.DueDate = dateTimePicker1.Value;
            t.Save();
            enumComments();
        }

        private void companyDropdown1_EditValueChanged(object sender, EventArgs e)
        {
            orderDropdown1.CurrentCustomer = (int)companyDropdown1.EditValue;
        }

        private WebdocOrder.Todo currentTodo;

        public void LoadTodo(int id)
        {
            WebdocOrder.Todo t = new WebdocOrder.Todo(id);
            currentTodo = t;
            textBox2.Text = t.Title;
            richEditControl1.RtfText = t.Comment;
            companyDropdown1.EditValue = t.CustomerId;
            ProjectId = t.ProjectId;
            CustomerId = t.CustomerId;
            enumComments();
            orderDropdown1.EditValue = t.ProjectId;
            if (t.DueDate > dateTimePicker1.MinDate && t.DueDate < dateTimePicker1.MaxDate)
                dateTimePicker1.Value = t.DueDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RibbonForm1 rf = new RibbonForm1();
            rf.richEditControl1.RtfText = richEditControl1.RtfText;
            rf.ShowDialog();
            
            richEditControl1.RtfText = rf.richEditControl1.RtfText;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
                LoadTodo(((WebdocOrder.Todo)dataGridView1.SelectedRows[0].DataBoundItem).Id);
        }

        private void orderDropdown1_EditValueChanged(object sender, EventArgs e)
        {
            ProjectId = (int)orderDropdown1.EditValue;
            enumComments();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

    }
}
