using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.DAL;

namespace WebdocOrder.GUI
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        public Customer(WebdocOrder.Customer c)
        {
            InitializeComponent();
            CurrentCustomer = c;
        }

        public WebdocOrder.Customer CurrentCustomer;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }
        

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entrys.NewEntry' table. You can move, or remove it, as needed.
            //this.newEntryTableAdapter.Fill(this.entrys.NewEntry);
            if (CurrentCustomer != null)
            {
                LoadCustomerData();
                //simpleButton2.Enabled = true;
                ddContact.CurrentCustomer = CurrentCustomer.Id;
                ddContact.Enabled = true;
                ddContact.CheckValue();

                //foreach (ContactPerson cp in ContactPerson.GetContactsByCustomer(CurrentCustomer.Id))
                //{
                //    ListViewItem lvi = new ListViewItem(cp.Name);
                //    lvi.Tag = cp;
                //    lvContacts.Items.Add(lvi);
                //}

                //foreach (ProjectOrder po in ProjectOrder.GetOrders(CurrentCustomer.Id))
                //{
                //    ListViewItem lvi = new ListViewItem(po.Title);
                //    lvi.Tag = po;
                //    lvOrders.Items.Add(lvi);
                //}
                //gdTime.DataSource = DataAdapter.sqlGetDS("SELECT * FROM NewEntry WHERE CustomerId="+CurrentCustomer.Id);
            }
            else
                CurrentCustomer = new WebdocOrder.Customer();
        }

        public void LoadCustomerData()
        {
            teName.Text = CurrentCustomer.CustomerName;
            teCustNr.Text = CurrentCustomer.CustomerNr;
            teNotes.Text = CurrentCustomer.Notes;
            teOrgnr.Text = CurrentCustomer.OrgNr;
            teAdress.Text = CurrentCustomer.Adress;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Contact c = new Contact(CurrentCustomer.Id);
            c.Show();
        }

        private void lvContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lvContacts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            CurrentCustomer.CustomerName = teName.Text;
            CurrentCustomer.CustomerNr = teCustNr.Text;
            CurrentCustomer.Notes = teNotes.Text;
            CurrentCustomer.OrgNr = teOrgnr.Text;
            CurrentCustomer.Adress = teAdress.Text;
            if (ddContact.EditValue != null)
                CurrentCustomer.DefaultContact = (int)ddContact.EditValue;
            CurrentCustomer.Save();
            ddContact.CurrentCustomer = CurrentCustomer.Id;
            ddContact.Enabled = true;
            //simpleButton2.Enabled = true;
            this.Close();
        }

       
    }
}
