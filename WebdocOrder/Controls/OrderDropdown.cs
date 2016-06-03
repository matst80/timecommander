using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;

namespace WebdocOrder.Controls
{
    public class OrderDropdown : DevExpress.XtraEditors.LookUpEdit
    {
        private DevExpress.XtraEditors.Controls.EditorButton edit;
        private DevExpress.XtraEditors.Controls.EditorButton delete;

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

        public OrderDropdown()
            : base()
        {
            bool designMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
            if (designMode)
            {
                Properties.Columns.Clear();
                Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", 40, "Namn"));
                Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Time", 20, "Antal timmar"));
                Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Accepted", 20, "Godkännd"));
            }
            Properties.NullText = "Välj projekt";
            Properties.DisplayMember = "Title";
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

            EditValueChanged += new EventHandler(Properties_EditValueChanged);
            //Properties.EditValueChanged += new EventHandler(Properties_EditValueChanged);
            Properties.Buttons.Add(add);
            Properties.Buttons.Add(edit);
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
                    Properties.DataSource = WebdocOrder.ProjectOrder.GetOrders(CurrentCustomer);
                else
                    Properties.DataSource = WebdocOrder.ProjectOrder.GetOrders();
            }
            catch {
            }
        }

        void CompanyDropdown_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            if (e.Button.Caption == "Ny")
            {
                WebdocOrder.GUI.Order c = new GUI.Order(CurrentCustomer);
                c.ShowDialog();
                enumData();
            }
            if (EditValue != null)
            {
                int id = (int)EditValue;
                if (e.Button.Caption == "Edit")
                {
                    WebdocOrder.GUI.Order c = new GUI.Order(new ProjectOrder(id));
                    c.ShowDialog();
                    enumData();
                }
                if (e.Button.Caption == "Delete")
                {
                    if (MessageBox.Show("Är du säker på att du vill radera denna order?", "Radera order", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                        new ProjectOrder(id).Delete();
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
