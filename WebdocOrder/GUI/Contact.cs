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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        public Contact(WebdocOrder.ContactPerson _CurrentPerson)
        {
            InitializeComponent();
            CurrentPerson = _CurrentPerson;
        }

        public Contact(int cid)
        {
            InitializeComponent();
            CurrentCustomerId = cid;
        }

        public int CurrentCustomerId;

        public WebdocOrder.ContactPerson CurrentPerson;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ddCompany.EditValue == null)
            {
                MessageBox.Show("Kund måste anges innan man sparar kontaktperson");
                return;
            }
            CurrentPerson.CompanyId = (int)ddCompany.EditValue;
            CurrentPerson.Email = teEmail.Text;
            CurrentPerson.MobilePhone = teMobile.Text;
            CurrentPerson.Name = teName.Text;
            CurrentPerson.Notes = teNotes.Text;
            CurrentPerson.Phone = tePhone.Text;
            CurrentPerson.Title = teTitle.Text;
            CurrentPerson.Save();
            this.Close();
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            //luCustomer.Properties.DataSource = WebdocOrder.Customer.GetList<WebdocOrder.Customer>();
            if (CurrentPerson != null)
            {
                LoadData();
            }
            else
            {
                CurrentPerson = new ContactPerson();
                if (CurrentCustomerId > 0)
                    ddCompany.EditValue = CurrentCustomerId;
                ddCompany.CheckValue();
            }


        }

        private void LoadData()
        {
            ddCompany.EditValue = CurrentPerson.CompanyId;
            teEmail.Text = CurrentPerson.Email;
            teMobile.Text = CurrentPerson.MobilePhone;
            teName.Text = CurrentPerson.Name;
            teNotes.Text = CurrentPerson.Notes;
            tePhone.Text = CurrentPerson.Phone;
            teTitle.Text = CurrentPerson.Title;
        }
    }
}
