using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;
using System.Net;

namespace WebdocOrder.Controls
{
    public class ContactDropdown : DevExpress.XtraEditors.LookUpEdit
    {
        private DevExpress.XtraEditors.Controls.EditorButton edit;
        private DevExpress.XtraEditors.Controls.EditorButton delete;
        private DevExpress.XtraEditors.Controls.EditorButton callb;

        private int _currCust;
        public int CurrentCustomer
        {
            get
            {
                return _currCust;
            }
            set
            {
                _currCust = value;
                enumData();
            }
        }

        public void ReloadData()
        {
            enumData();
        }

        public ContactDropdown()
            : base()
        {
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            //if (designMode)
            {
                Properties.Columns.Clear();
                Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Namn"));
                Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", 20, "E-post"));
            }
            //Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Accepted", 20, "Godkännd"));
            Properties.NullText = "Välj kontaktperson";
            Properties.DisplayMember = "Name";
            Properties.ValueMember = "Id";
            Properties.PopupWidth = 400;
            DevExpress.XtraEditors.Controls.EditorButton add = new DevExpress.XtraEditors.Controls.EditorButton();
            add.Caption = "Ny";
            add.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus;

            edit = new DevExpress.XtraEditors.Controls.EditorButton();
            edit.Caption = "Edit";
            edit.Enabled = false;
            edit.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis;


            delete = new DevExpress.XtraEditors.Controls.EditorButton();
            delete.Caption = "Delete";
            delete.Enabled = false;
            delete.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Minus;

            callb = new DevExpress.XtraEditors.Controls.EditorButton();
            callb.Caption = "Call";
            callb.Enabled = true;
            callb.Visible = true;
            callb.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.OK;

            EditValueChanged += new EventHandler(Properties_EditValueChanged);
            //Properties.EditValueChanged += new EventHandler(Properties_EditValueChanged);
            Properties.Buttons.Add(add);
            Properties.Buttons.Add(edit);
            Properties.Buttons.Add(callb);
            Properties.PropertiesChanged += new EventHandler(Properties_PropertiesChanged);
            Properties.Buttons.Add(delete);
            enumData();
            ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(CompanyDropdown_ButtonClick);
        }

        void Properties_PropertiesChanged(object sender, EventArgs e)
        {
            CheckValue();
        }

        private void enumData()
        {
            try
            {
                if (CurrentCustomer > 0)
                    Properties.DataSource = WebdocOrder.ContactPerson.GetContactsByCustomer(CurrentCustomer);
                else
                    Properties.DataSource = WebdocOrder.ContactPerson.GetList<WebdocOrder.ContactPerson>();
            }
            catch
            {
            }
        }

        public void Call(string number)
        {
            int uid = int.Parse(System.Configuration.ConfigurationManager.AppSettings["UserId"]);
            var user = WebdocOrder.DAL.InternalUser.GetUser(uid);
            string extension_number = user.Ext;
            string extension_pin = user.Pin;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://192.168.0.3:5000/ivr/PbxAPI.aspx?func=make_call&from=" + extension_number + "&to=" + number.Replace(" ", "").Replace("-", "") + "&pin=" + extension_pin);



            // execute the request
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.GetResponseStream();
        }

        void CompanyDropdown_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (e.Button.Caption == "Ny")
            {
                WebdocOrder.GUI.Contact c = new GUI.Contact(CurrentCustomer);
                c.ShowDialog();
                enumData();
            }
            
            if (EditValue != null)
            {
                int id = (int)EditValue;
                if (e.Button.Caption == "Call")
                {
                    var cp = new ContactPerson(id);
                    Call(cp.Phone);
                }
                if (e.Button.Caption == "Edit")
                {
                    WebdocOrder.GUI.Contact c = new GUI.Contact(new ContactPerson(id));
                    c.ShowDialog();
                    enumData();
                }
                if (e.Button.Caption == "Delete")
                {
                    if (MessageBox.Show("Är du säker på att du vill radera denna kontakt?", "Radera kontakt", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        ContactPerson c = new ContactPerson(id);
                        c.Delete();
                    }
                    enumData();
                }
            }
        }

        void Properties_EditValueChanged(object sender, EventArgs e)
        {
            CheckValue();
        }

        public void CheckValue()
        {
            foreach (EditorButton eb in Properties.Buttons)
            {
                if (eb.Caption == "Ny")
                    eb.Enabled = true;
                else
                    eb.Enabled = (EditValue != null);
            }
            if (EditValue != null)
            {
                int id = (int)EditValue;
                callb.Enabled = !(string.IsNullOrEmpty(new ContactPerson(id).Phone));
            }
        }
    }
}
