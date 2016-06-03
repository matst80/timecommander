using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DAL;
using WebdocOrder;

namespace TelefonFixarn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ReportEntry CurrentEntry = new ReportEntry();

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length < 2)
            {
                MessageBox.Show("Ingen användare angiven");
                Application.Exit();
                return;
            }
            var uid = 8;
            try
            {
                //args = new[] {"8", "0241-793370"};
                uid = int.Parse(args[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Join(", ", args));
            }
            CurrentEntry.ResourceId = uid;
            var phone = args[2].Replace(" ", "").Replace("-", "").Replace("0046", "0");
            if (!phone.StartsWith("0"))
                phone = "0" + phone;
            Text = phone;
            CurrentEntry.StartTime = DateTime.Now;
            CurrentEntry.EndTime = DateTime.Now.AddMinutes(30);
            //CurrentEntry.Duration = 30;
            CurrentEntry.EventType = 0;
            CurrentEntry.Parent = 2;
            CurrentEntry.EntryTitle = "0";
            var cp = ContactPerson.FindByText(phone).FirstOrDefault();
            //label2.Text = phone;
            var cust = dbBase.GetList<Customer>().OrderBy(d=>d.CustomerName).ToArray();
            comboBox1.Items.AddRange(cust);
            if (cp == null)
            {
                comboBox2.Items.AddRange(dbBase.GetList<ProjectOrder>().ToArray());
            }
            else
            {
                var currcust = cust.FirstOrDefault(d => d.Id == cp.CompanyId);
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(currcust);
                EnumProjects();
                //cp.CompanyId
                //label1.Text = cp.Name;
            }
            //comboBox1.Visible = cp == null;

        }

        public void EnumProjects(CustomerContact cp = null)
        {
            var cust = comboBox1.SelectedItem as Customer;
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(cust.FK_Order_Customer.ToArray());
            if (cp != null)
            {
                //comboBox2.Items.IndexOf(comboBox2.Items)
                comboBox2.SelectedIndex = cp.ProjectId;
            }
            else
            {
                comboBox2.SelectedIndex = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                CurrentEntry.CustomerId = ((Customer) comboBox1.SelectedItem).Id;
            EnumProjects();
            EnumContacts();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
                CurrentEntry.ProjectId = ((ProjectOrder)comboBox2.SelectedItem).Id;
        }

        private void EnumContacts()
        {
            var cust = comboBox1.SelectedItem as Customer;
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(cust.GetContacts().ToArray());
            comboBox3.SelectedIndex = 0;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            if (comboBox3.SelectedItem != null)
                CurrentEntry.YourReference = ((ContactPerson)comboBox3.SelectedItem).Id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentEntry.Title = textBox1.Text;
            CurrentEntry.Description = textBox2.Text;
            //CurrentEntry.Duration = 30;
            
            
            CurrentEntry.Save();
            Application.Exit();
        }
    }
}
