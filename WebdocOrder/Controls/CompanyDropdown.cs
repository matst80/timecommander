using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;

namespace WebdocOrder.Controls
{
    public class CompanyDropdown : DevExpress.XtraEditors.LookUpEdit
    {
        private DevExpress.XtraEditors.Controls.EditorButton edit;
        private DevExpress.XtraEditors.Controls.EditorButton delete;

        public CompanyDropdown()
            : base()
        {
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            if (designMode)
            {
                Properties.Columns.Clear();
                Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", 40, "Namn"));
                Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerNr", 20, "Kundnummer"));
            }
            Properties.NullText = "Välj kund";
            Properties.DisplayMember = "CustomerName";
            Properties.PopupWidth = 400;
            Properties.ValueMember = "Id";

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

            EditValueChanged += new EventHandler(Properties_EditValueChanged);
            //Properties.EditValueChanged += new EventHandler(Properties_EditValueChanged);
            Properties.Buttons.Add(add);
            Properties.Buttons.Add(edit);
            Properties.PropertiesChanged += new EventHandler(Properties_PropertiesChanged);
            //Properties.Buttons.Add(delete);
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
                Properties.DataSource = WebdocOrder.Customer.GetCustomers();
            }
            catch
            {
            }
        }

        public int SelectedCustomer
        {
            get {
                return (int)EditValue;
            }
        }

        public void ReloadData()
        {
            enumData();
        }

        void CompanyDropdown_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (e.Button.Caption == "Ny")
            {
                WebdocOrder.GUI.Customer c = new GUI.Customer();
                c.ShowDialog();
                enumData();
            }
            if (EditValue != null)
            {
                int id = (int)EditValue;
                if (e.Button.Caption == "Edit")
                {
                    WebdocOrder.GUI.Customer c = new GUI.Customer(new Customer(id));
                    c.ShowDialog();
                    enumData();
                }
                if (e.Button.Caption == "Delete")
                {
                    if (MessageBox.Show("Är du säker på att du vill radera denna kund?", "Radera kund", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                        new Customer(id).Delete();
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
        }
    }
}
