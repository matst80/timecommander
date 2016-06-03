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
    public partial class CustomerOverview : Form
    {
        public CustomerOverview()
        {
            InitializeComponent();
        }

        private void CustomerOverview_Load(object sender, EventArgs e)
        {
            EnumData();
        }

        private void EnumData()
        {
            treeView1.Nodes.Clear();
            foreach (var customer in WebdocOrder.Customer.GetCustomers())
            {
                if (!string.IsNullOrEmpty(customer.CustomerName))
                {
                    TreeNode tn = new TreeNode(customer.CustomerName);
                    tn.Tag = customer;
                    tn.ImageIndex = 0;
                    tn.SelectedImageIndex = 0;
                    tn.ContextMenuStrip = contextMenuStrip2;
                    foreach (var todo in WebdocOrder.Todo.GetByCustomerId(customer.Id))
                    {
                        var tnode = new TreeNode(todo.Title);
                        tnode.Tag = todo;
                        tnode.ImageIndex = 2;
                        tnode.SelectedImageIndex = 2;
                        tn.Nodes.Add(tnode);
                    }
                    foreach (var proj in WebdocOrder.ProjectOrder.GetOrders(customer.Id))
                    {
                        TreeNode pnode = new TreeNode(proj.Title);
                        foreach (var todo in WebdocOrder.Todo.GetByProjectId(proj.Id))
                        {
                            var tnode = new TreeNode(todo.Title);
                            tnode.Tag = todo;
                            tnode.ImageIndex = 2;
                            tnode.SelectedImageIndex = 2;
                            pnode.Nodes.Add(tnode);
                        }
                        pnode.Tag = proj;
                        pnode.ImageIndex = 1;
                        pnode.SelectedImageIndex = 1;
                        pnode.ContextMenuStrip = contextMenuStrip1;
                        tn.Nodes.Add(pnode);
                    }
                    treeView1.Nodes.Add(tn);
                }
            }
        }

        private WebdocOrder.Customer getCustomer()
        {
            var o = currentTag;
            if (o is WebdocOrder.Customer)
                return ((WebdocOrder.Customer)o);
            else if (o is WebdocOrder.ProjectOrder)
                return ((ProjectOrder)o).ParentCustomer;
            else return null;
        }

        private WebdocOrder.ProjectOrder getProject()
        {
            var o = currentTag;
            if (o is WebdocOrder.ProjectOrder)
                return ((WebdocOrder.ProjectOrder)o);
            else return null;
        }

        private void todoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Todo t = new Todo(getCustomer());
            t.ShowDialog();
        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Todo t = new Todo(getProject());
            t.ShowDialog();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order o = new Order(getCustomer().Id);
            o.ShowDialog();
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order o = new Order(getProject());
            o.ShowDialog();
        }

        private void openCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Customer c = new Customer(getCustomer());
            c.ShowDialog();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var obj = treeView1.HitTest(e.Location).Node.Tag;
            if (obj is WebdocOrder.Todo)
            {
                WebdocOrder.GUI.Todo t = new Todo();
                t.LoadTodo(((WebdocOrder.Todo)obj).Id);
                t.Show();
            }
            else if (obj is WebdocOrder.Customer)
            {
                WebdocOrder.GUI.Customer t = new Customer((WebdocOrder.Customer)obj);
                t.Show();
            }
            else if (obj is WebdocOrder.ProjectOrder)
            {
                WebdocOrder.GUI.Order t = new Order((WebdocOrder.ProjectOrder)obj);
                t.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            EnumData();
        }

        public object currentTag;

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            currentTag = treeView1.HitTest(e.Location).Node.Tag;
        }
    }
}
