using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;

namespace TimeCommander2.CustomControls
{
    public partial class InplaceEditor : DevExpress.XtraEditors.XtraForm
    {
        Appointment appointment;
        SchedulerControl control;

        public InplaceEditor()
        {
            InitializeComponent();
            SubscribeKeyDownEvents();
        }
        public event EventHandler CommitChanges;
        public event EventHandler RollbackChanges;

        private void SubscribeKeyDownEvents()
        {
            appointmentLabelEdit.KeyDown += new KeyEventHandler(AppointmentLabelEdit_KeyDown);
            edtDescription.KeyDown += new KeyEventHandler(Editor_KeyDown);
            edtSubject.KeyDown += new KeyEventHandler(Editor_KeyDown);
        }
        public void AppointmentLabelEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (!appointmentLabelEdit.IsPopupOpen)
                Editor_KeyDown(sender, e);
        }
        private bool InEdit = false;
        public override bool ValidateChildren()
        {
            /*if (InEdit)
                return false;*/
            if (ddContact.EditValue == null || ddCompany.EditValue == null || ddProject == null) return false;
            return base.ValidateChildren();
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {
            if (ddContact.EditValue == null || ddCompany.EditValue == null || ddProject == null)
            {
                e.Cancel = true;
                //return;
            }
            base.OnClosing(e);
        }
        void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.Handled = true;
                    OnCommitChanges();
                    break;
                case Keys.Escape:
                    e.Handled = true;
                    OnRollbackChanges();
                    break;
            }
        }

        void OnCommitChanges()
        {
            if (CommitChanges != null)
                CommitChanges(this, EventArgs.Empty);
        }

        void OnRollbackChanges()
        {
            if (RollbackChanges != null)
                RollbackChanges(this, EventArgs.Empty);
        }
        protected override void OnShown(EventArgs e)
        {
            SchedulerStorage storage = control.Storage;
            if (storage.Appointments.IsNewAppointment(appointment))
            {
                edtSubject.SelectionLength = 0;
                edtSubject.SelectionStart = edtSubject.Text.Length;
            }
            enumCustomers();
            //comboBox1.DataSource = wd.Time.Tables.Entry.ListAllCompanys();
            //comboBox1.DisplayMember = "";
            base.OnShown(e);
        }
        /*
        public class TempItem
        {
            public string Name {get; set;}
            public string Value {get; set;}
            public TempItem(string v)
            {
                Name = v;
                Value = v;
            }
            public static List<TempItem> Convert(List<string> items)
            {
                List<TempItem> ti = new List<TempItem>();
                foreach (string s in items)
                {
                    ti.Add(new TempItem(s));
                }
                return ti;
            }
        }
        */
        public void enumCustomers()
        {
            ddCompany.ReloadData();
            //luCustomer.Properties.DataSource = WebdocOrder.Customer.GetCustomers();

            /*
            ddCustomer.Properties.Items.Clear();
            List<string> companys =wd.Time.Tables.Entry.ListAllCompanys(); 
            companys.Sort();
            foreach (string s in companys)
            {
                if (!string.IsNullOrEmpty(s.Trim()))
                    ddCustomer.Properties.Items.Add(s);
            }
             * */
            
        }

        public void enumProj(object id)
        {
            /*ddProject.Properties.Items.Clear();
            foreach (string s in wd.Time.Tables.Entry.ListAllTypesFromCompany(com))
            {
                if (!string.IsNullOrEmpty(s.Trim()))
                    ddProject.Properties.Items.Add(s);
            }
            
            luProject.Properties.DataSource = WebdocOrder.ProjectOrder.GetOrders((int)luCustomer.EditValue);
            luProject.EditValue = id;
             *  * */
            ddProject.CurrentCustomer = ddCompany.SelectedCustomer;
            ddProject.Enabled = true;
            ddContact.Enabled = true;
            ddProject.ReloadData();
            enumRef(id);
            //luProject.Properties.PopulateColumns();
        }

        public void enumRef(object customer)
        {
            ddContact.CurrentCustomer = ddCompany.SelectedCustomer;
            ddContact.ReloadData();
            //luContact.Properties.DataSource = WebdocOrder.ContactPerson.GetContactsByCustomer((int)luCustomer.EditValue);
            
            /*comboBoxEdit1.Properties.Items.Clear();
            foreach(string s in wd.Time.Tables.Entry.ListAllYRef(customer))
            {
                if (!string.IsNullOrEmpty(s.Trim()))
                    comboBoxEdit1.Properties.Items.Add(s);
            }*/
        }

        public void FillForm(SchedulerControl control, Appointment appointment)
        {
            this.appointment = appointment;
            this.control = control;
            SchedulerStorage storage = control.Storage;
            //comboBoxEdit1.Properties.Items.AddRange(
            this.appointmentLabelEdit.Storage = storage;
            object custId = appointment.CustomFields["CustomerId"];
            if (!(custId is DBNull || custId == null))
            {
                ddCompany.EditValue = (int)custId;
                //ddCustomer.Text = (string)appointment.CustomFields["Customer"];
                //luCompany.EditValue = luCompany.SelectedText = this.luCompany.Text = (string)appointment.CustomFields["Customer"];
                object projId = appointment.CustomFields["ProjectId"];
                enumProj(custId);
                if (!(projId is DBNull || projId == null))
                    ddProject.EditValue = projId;

                //ddProject.Text = (string)appointment.CustomFields["Type"];
                //if (!(appointment.CustomFields["YourReference"] is DBNull))
                object contactId = appointment.CustomFields["YourReference"];
                if (!(contactId is DBNull || contactId == null))
                    ddContact.EditValue = (int)contactId;
            }
            else
            {
               
            }
                //comboBoxEdit1.Text = (string)appointment.CustomFields["YourReference"];
            this.appointmentLabelEdit.Label = storage.Appointments.Labels[appointment.LabelId];
            this.edtSubject.Text = appointment.Subject;
            this.edtDescription.Text = appointment.Description;
        }
        public void ApplyChanges()
        {
            appointment.Subject = edtSubject.Text;
            if (ddCompany.EditValue != null)
                appointment.CustomFields["CustomerId"] = ddCompany.EditValue;
            else
                ddCompany.EditValue = appointment.CustomFields["CustomerId"] = 302;
            if (ddProject.EditValue!=null)
                appointment.CustomFields["ProjectId"] = ddProject.EditValue;
            else
                ddProject.EditValue = appointment.CustomFields["ProjectId"] = 28;
            if (ddContact.EditValue != null)
                appointment.CustomFields["YourReference"] = ddContact.EditValue;
            else
                ddContact.EditValue = appointment.CustomFields["YourReference"] = 192;
            appointment.Description = edtDescription.Text;
            appointment.LabelId = control.Storage.Appointments.Labels.IndexOf(appointmentLabelEdit.Label);
            appointment.CustomFields["Customer"] = new WebdocOrder.Customer((int)ddCompany.EditValue).CustomerName;
            appointment.CustomFields["ProjectTitle"] = new WebdocOrder.ProjectOrder((int)ddProject.EditValue).Title;
        }

        private void InplaceEditor_Load(object sender, EventArgs e)
        {
            /*
            // TODO: This line of code loads data into the 'projects.Entry' table. You can move, or remove it, as needed.
            //this.entryTableAdapter1.Fill(this.projects.Entry);
            // TODO: This line of code loads data into the 'companys.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.companys.Entry);
             * */

        }

        private void entryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        
        private void luCompany_EditValueChanged(object sender, EventArgs e)
        {
            //luProject.Properties.DataSource = wd.Time.Tables.Entry.ListAllTypesFromCompany((string)luCompany.EditValue);
            //if (ddCustomer.EditValue != null && !(ddCustomer.EditValue is DBNull))
            enumProj(ddCompany.EditValue);
        }
        /*
        private void ddCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            enumProj(ddCustomer.Text);
        }
        */
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void luProject_EditValueChanged(object sender, EventArgs e)
        {

        }

       

        private void ddCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (ddCompany.EditValue!=null)
                enumProj(ddCompany.SelectedCustomer);
        }

        private void ddProject_EditValueChanged(object sender, EventArgs e)
        {
               
            WebdocOrder.ProjectOrder po = new WebdocOrder.ProjectOrder((int)ddProject.EditValue);
            ddContact.EditValue = po.ContactId;
            //comboBoxEdit1_EditValueChanged(null, null);
        }

        /*private void luProject_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            
            //e.DisplayValue
            e.Handled = true;
        }

        private void luCompany_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            
            e.Handled = true;
        }*/
    }
}
