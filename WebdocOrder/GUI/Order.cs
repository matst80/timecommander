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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        public Order(ProjectOrder _po)
        {
            InitializeComponent();
            po = _po;
        }

        public Order(int cid)
        {
            InitializeComponent();
            _cid = cid;
        }

        private int _cid =0;

        public ProjectOrder po;

        private void Order_Load(object sender, EventArgs e)
        {
            if (po == null)
            {
                po = new ProjectOrder();
            }
            else
            {
                LoadToGui();
            }
            enumCustomers();
            if (_cid > 0)
            {
                po.CustomerId = _cid;
                ddCompany.EditValue = _cid;
                ddCompany.CheckValue();
                EnumContacts();
            }
        }

        private void enumCustomers()
        {
            //luCustomer.Properties.DataSource = WebdocOrder.Customer.GetList<WebdocOrder.Customer>();
            ddCompany.ReloadData();
        }

        private void LoadToGui()
        {
            ddCompany.EditValue = po.CustomerId;
            ddContact.EditValue = po.ContactId;
            ddTech.EditValue = po.TechnicalId;
            cbAccepted.Checked = po.Approved;
            teDescription.Text = po.Description;
            teHourPrice.Text = po.HourCost.ToString();
            teHours.Text = po.Time.ToString();
            teTitle.Text = po.Title;
            CalcPrice();
        }

        private List<ContactPerson> contacts;

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            EnumContacts();
            ddParent.CurrentCustomer = ddCompany.SelectedCustomer;
            ddParent.ReloadData();
            //luParent.Properties.DataSource = WebdocOrder.ProjectOrder.GetOrders(ddCompany.SelectedCustomer);
        }

        private void EnumContacts()
        {
            if (ddCompany.EditValue != null)
            {
                int cid = ddCompany.SelectedCustomer;
                ddTech.CurrentCustomer = cid;
                ddContact.CurrentCustomer = cid;
                ddTech.ReloadData();
                ddContact.ReloadData();
            }
            /*contacts = ContactPerson.GetContactsByCustomer((int)luCustomer.EditValue);//new List<ContactPerson>(ContactPerson.GetCustomList<ContactPerson>("SELECT * FROM ContactPerson WHERE CompanyId=" + luCustomer.EditValue));
            luContact_old.Properties.DataSource = contacts;
            luTech.Properties.DataSource = contacts;*/

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //ProjectOrder po = new ProjectOrder();
            if (ddParent.EditValue!=null)
                po.ParentId = (int)ddParent.EditValue;
            po.BaseCost = int.Parse(teLicense.Text);
            if (ddCompany.EditValue != null)
                po.CustomerId = (int)ddCompany.EditValue;
            else
            {
                MessageBox.Show("Ingen kund vald för projektet!", "Inte korrekt ifyllt");
                return;
            }
            if (ddContact.EditValue != null)
                po.ContactId = (int)ddContact.EditValue;
            if (ddTech.EditValue!=null)
                po.TechnicalId = (int)ddTech.EditValue;
            po.Approved = cbAccepted.Checked;
            po.Description = teDescription.Text;
            po.HourCost = int.Parse(teHourPrice.Text);
            po.Time = int.Parse(teHours.Text);
            po.Title = teTitle.Text;
            string guid = Guid.NewGuid().ToString();
            po.LinkGuid = guid;
            //po.Type =
            Core.DAL.eObjectState state = po.ObjectState;
            int id = int.Parse(po.Save().ToString());
            if (po.Time >0)
                if (!cbAccepted.Checked && (state == Core.DAL.eObjectState.New || MessageBox.Show("Vill du skicka ett nytt acceptansmail?", "Skicka email", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes))
                    Helper.SendOrderAcceptMail(po);
            this.Close();
            //po.
        }

        
        private void teHourPrice_EditValueChanged(object sender, EventArgs e)
        {
            CalcPrice();
        }

        private void CalcPrice()
        {
            int h = 0;
            int.TryParse(teHours.Text, out h);
            int p = 0;
            int.TryParse(teHourPrice.Text, out p);
            int l = 0;
            int.TryParse(teLicense.Text, out l);
            if (h > 0)
                cbAccepted.Checked = false;
            teSum.Text = ((h * p) + l).ToString();
        }

        private void teHours_EditValueChanged(object sender, EventArgs e)
        {
            CalcPrice();
        }

        private void teLicense_EditValueChanged(object sender, EventArgs e)
        {
            CalcPrice();
        }

        private void ddCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (ddCompany.EditValue != null)
            {
                EnumContacts();
            }
        }

        
    }
}
