using System;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraScheduler;
using TimeCommander2.Helpers;
using System.Data;

namespace TimeCommander2.CustomControls
{
	public partial class UserDefinedFilterAppointmentForm : AppointmentForm {
		public UserDefinedFilterAppointmentForm() {
			InitializeComponent();
		}
		public UserDefinedFilterAppointmentForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm) : base(control, apt, openRecurrenceForm) {
			InitializeComponent();
            UpdateCorrupedData();
        }

		protected internal new UserDefinedFilterAppointmentFormController Controller { get { return (UserDefinedFilterAppointmentFormController)base.Controller; } }

		protected override AppointmentFormController CreateController(SchedulerControl control, Appointment apt) {
			return new UserDefinedFilterAppointmentFormController(control, apt);
		}

	    public void UpdateCorrupedData()
	    {
            if (ddCustomer != null)
            {
                enumProj(Controller.Customer);

                ddCustomer.EditValue = Controller.Customer; //luCompany.SelectedText = this.luCompany.Text = (string)appointment.CustomFields["Customer"];

                edtStartDate.DateTime = Controller.Start.Date;
                edtEndDate.DateTime = Controller.End.Date;

                edtStartTime.Time = DateTime.MinValue.AddTicks(Controller.Start.TimeOfDay.Ticks);
                edtEndTime.Time = DateTime.MinValue.AddTicks(Controller.End.TimeOfDay.Ticks);
                ddContact.EditValue = Controller.YourReference;
                ddProject.EditValue = Controller.Project; //luProject.SelectedText = this.luProject.Text = (string)appointment.CustomFields["Type"];
                //if (!(appointment.CustomFields["YourReference"] is DBNull))
                //comboBoxEdit1.Text = Controller.YourReference; //(string)appointment.CustomFields["YourReference"];
            }
        }

	    protected override bool CheckCustomDrawNonClientArea()
	    {
            UpdateCorrupedData();
            return base.CheckCustomDrawNonClientArea();
            
        }

	 //   protected override void UpdateCustomFieldsControls() {
		//	base.UpdateCustomFieldsControls();
		//	/*if (edtPrice != null)
		//		edtPrice.EditValue = Controller.Price;*/
            
		//}

        public void enumProj(int id)
        {
            
            ddProject.CurrentCustomer = id;
            ddProject.ReloadData();
            ddProject.Enabled = id > 0;
            //luProject.Properties.DataSource = WebdocOrder.ProjectOrder.GetOrders(id);
            /*
            luProject.Properties.DataSource = TimeCommander2.CustomControls.InplaceEditor.TempItem.Convert(wd.Time.Tables.Entry.ListAllTypesFromCompany((string)luCompany.EditValue));
            luProject.Properties.Columns.Clear();
            luProject.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"));
            luProject.Properties.DisplayMember = "Name";
            luProject.Properties.ValueMember = "Value";
             * */
            //luProject.r
            //luProject.Properties.
            enumRef(id);
            //luProject.Properties.PopulateColumns();
        }

        public void enumRef(int id)
        {
            ddContact.Enabled = id>0;
            ddContact.CurrentCustomer = id;
            ddContact.ReloadData();
            //comboBoxEdit1.Properties.DataSource = WebdocOrder.ContactPerson.GetContactsByCustomer(id);
            /*comboBoxEdit1.Properties.Items.Clear();
            foreach (string s in wd.Time.Tables.Entry.ListAllYRef(customer))
            {
                comboBoxEdit1.Properties.Items.Add(s);
            }*/
        }

        private void luCompany_EditValueChanged(object sender, EventArgs e)
        {
            int value = (int)ddCustomer.EditValue;
            enumProj(value);
            Controller.Customer = value;
        }

        private void luProject_EditValueChanged(object sender, EventArgs e)
        {
            int value = (int)ddProject.EditValue;
            Controller.Project = value;
            WebdocOrder.ProjectOrder po = new WebdocOrder.ProjectOrder(value);
            ddContact.EditValue = po.ContactId;
            comboBoxEdit1_EditValueChanged(null, null);
        }

        private void comboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int value = (int)ddContact.EditValue;
            Controller.YourReference = value;
        }

        private void UserDefinedFilterAppointmentForm_Load(object sender, EventArgs e)
        {
            /*
            // TODO: This line of code loads data into the 'supportDs.SupportEntry' table. You can move, or remove it, as needed.
            this.supportEntryTableAdapter.Fill(this.supportDs.SupportEntry);
            // TODO: This line of code loads data into the 'companys.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.companys.Entry);
             * */
            enumCompanies();

        }

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    luOutlook.Properties.DataSource = Helpers.OutlookTasks.GetTasks();
        //    luOutlook.Properties.DisplayMember = "Subject";
        //}

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SupportConversation cs = new SupportConversation();
            cs.ParentForm = (TimeApp)this.ParentForm;
            DataRow ts = ((DataRowView)lookUpEdit1.EditValue).Row;
            cs.EntryId = (int)ts["Id"];
            tbDescription.Text = (string)ts["Entry"];
            cs.Show();
        }

        //private void luOutlook_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (luOutlook.EditValue is OutlookTask)
        //    {
        //        OutlookTask ts = (OutlookTask)luOutlook.EditValue;
        //        tbSubject.Text = ts.Subject;
        //        tbDescription.Text = ts.Description;
        //    }
        //}

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEdit1.EditValue is DataRowView)
            {
                DataRow ts = ((DataRowView)lookUpEdit1.EditValue).Row;
                tbSubject.Text = (string)ts["Title"];
                tbDescription.Text = (string)ts["Entry"]; 
            }
        }

   
        
        private void enumCompanies()
        {
            ddCustomer.ReloadData();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
	}
    
	public class UserDefinedFilterAppointmentFormController : AppointmentFormController {
		public UserDefinedFilterAppointmentFormController(SchedulerControl control, Appointment apt)
			: base(control, apt) {
		}

		/*public Decimal Price {
			get {
				object value = EditedAppointmentCopy.CustomFields["CustomFieldPrice"];
				try {
					return Convert.ToDecimal(value);
				}
				catch {
					return 0;
				}
			}
			set { EditedAppointmentCopy.CustomFields["CustomFieldPrice"] = value; }
		}*/

        public int Customer
        {
            get
            {
                object value = EditedAppointmentCopy.CustomFields["CustomerId"];
                if (value is DBNull || value==null)
                    return 302;
                return (int)value;
            }
            set
            {
                EditedAppointmentCopy.CustomFields["CustomerId"] = value;
            }
        }

        public int YourReference
        {
            get
            {
                object value = EditedAppointmentCopy.CustomFields["YourReference"];
                if (value is DBNull || value == null)
                    return 192;
                return (int)value;
            }
            set
            {
                EditedAppointmentCopy.CustomFields["YourReference"] = value;
            }
        }

        public int Project
        {
            get
            {
                //return (string)EditedAppointmentCopy.CustomFields["Type"];
                object value = EditedAppointmentCopy.CustomFields["ProjectId"];
                if (value is DBNull || value == null)
                    return 28;
                return (int)value;
            }
            set
            {
                EditedAppointmentCopy.CustomFields["ProjectId"] = value;
            }
        }

		protected override void ApplyCustomFieldsValues() {
			base.ApplyCustomFieldsValues();
            SourceAppointment.CustomFields["Customer"] = new WebdocOrder.Customer(Customer).CustomerName;
            SourceAppointment.CustomFields["ProjectTitle"] = new WebdocOrder.ProjectOrder(Project).Title;
            SourceAppointment.CustomFields["CustomerId"] = Customer;
            SourceAppointment.CustomFields["ProjectId"] = Project;
            SourceAppointment.CustomFields["YourReference"] = YourReference;
		}
	}
}
