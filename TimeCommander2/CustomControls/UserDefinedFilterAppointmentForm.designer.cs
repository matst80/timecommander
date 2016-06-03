namespace TimeCommander2.CustomControls
{
	partial class UserDefinedFilterAppointmentForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDefinedFilterAppointmentForm));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.entryBindingSource = new System.Windows.Forms.BindingSource();
            this.companysBindingSource = new System.Windows.Forms.BindingSource();
            this.companys = new TimeCommander2.companys();
            this.entryTableAdapter = new TimeCommander2.companysTableAdapters.EntryTableAdapter();
            this.luOutlook = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.supportEntryBindingSource = new System.Windows.Forms.BindingSource();
            this.supportDsBindingSource = new System.Windows.Forms.BindingSource();
            this.supportDs = new TimeCommander2.supportDs();
            this.supportEntryTableAdapter = new TimeCommander2.supportDsTableAdapters.SupportEntryTableAdapter();
            this.ddContact = new WebdocOrder.Controls.ContactDropdown();
            this.ddProject = new WebdocOrder.Controls.OrderDropdown();
            this.ddCustomer = new WebdocOrder.Controls.CompanyDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luOutlook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportDsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddCustomer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(16, 148);
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(16, 173);
            // 
            // lblShowTimeAs
            // 
            this.lblShowTimeAs.Location = new System.Drawing.Point(16, 70);
            // 
            // chkAllDay
            // 
            this.chkAllDay.Location = new System.Drawing.Point(328, 145);
            this.chkAllDay.TabIndex = 14;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 415);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 415);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(192, 415);
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Location = new System.Drawing.Point(280, 415);
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(96, 145);
            this.edtStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.TabIndex = 8;
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Location = new System.Drawing.Point(96, 170);
            this.edtEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.TabIndex = 9;
            // 
            // edtStartTime
            // 
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(224, 146);
            this.edtStartTime.TabIndex = 6;
            // 
            // edtEndTime
            // 
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(224, 170);
            this.edtEndTime.TabIndex = 7;
            // 
            // edtLabel
            // 
            this.edtLabel.TabIndex = 10;
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Location = new System.Drawing.Point(96, 67);
            this.edtShowTimeAs.TabIndex = 3;
            // 
            // tbSubject
            // 
            // 
            // edtResource
            // 
            this.edtResource.Location = new System.Drawing.Point(400, 170);
            this.edtResource.TabIndex = 15;
            // 
            // lblResource
            // 
            this.lblResource.Location = new System.Drawing.Point(327, 173);
            // 
            // edtResources
            // 
            this.edtResources.Location = new System.Drawing.Point(400, 170);
            // 
            // chkReminder
            // 
            this.chkReminder.Location = new System.Drawing.Point(328, 67);
            this.chkReminder.TabIndex = 12;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(16, 196);
            this.tbDescription.Size = new System.Drawing.Size(496, 209);
            this.tbDescription.TabIndex = 16;
            // 
            // cbReminder
            // 
            this.cbReminder.Location = new System.Drawing.Point(400, 67);
            this.cbReminder.TabIndex = 11;
            // 
            // tbLocation
            // 
            this.tbLocation.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(327, 100);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "Reference";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 42;
            this.labelControl3.Text = "Customer";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 41;
            this.labelControl2.Text = "Project";
            // 
            // entryBindingSource
            // 
            this.entryBindingSource.DataMember = "Entry";
            this.entryBindingSource.DataSource = this.companysBindingSource;
            // 
            // companysBindingSource
            // 
            this.companysBindingSource.DataSource = this.companys;
            this.companysBindingSource.Position = 0;
            // 
            // companys
            // 
            this.companys.DataSetName = "companys";
            this.companys.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entryTableAdapter
            // 
            this.entryTableAdapter.ClearBeforeFill = true;
            // 
            // luOutlook
            // 
            this.luOutlook.Location = new System.Drawing.Point(16, 351);
            this.luOutlook.Name = "luOutlook";
            this.luOutlook.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.luOutlook.Properties.BestFitRowCount = 10;
            this.luOutlook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luOutlook.Properties.DropDownRows = 10;
            this.luOutlook.Properties.NullText = "Select Outlooktask";
            this.luOutlook.Size = new System.Drawing.Size(464, 20);
            this.luOutlook.TabIndex = 44;
            this.luOutlook.Visible = false;
            //this.luOutlook.EditValueChanged += new System.EventHandler(this.luOutlook_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::TimeCommander2.Properties.Resources.OUTLLIBR_20611_16x16_32;
            this.simpleButton1.Location = new System.Drawing.Point(486, 351);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(26, 20);
            this.simpleButton1.TabIndex = 45;
            this.simpleButton1.Visible = false;
            //this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::TimeCommander2.Properties.Resources.OUTLLIBR_20601_16x16_8;
            this.simpleButton2.Location = new System.Drawing.Point(486, 377);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(26, 20);
            this.simpleButton2.TabIndex = 47;
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(16, 377);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lookUpEdit1.Properties.BestFitRowCount = 10;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 33, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Title", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Entry", "Entry", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", "Status", 41, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Site", "Site", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "User Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Added", "Added", 41, DevExpress.Utils.FormatType.DateTime, "yyyy-MM-dd", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Finished", "Finished", 49, DevExpress.Utils.FormatType.DateTime, "yyyy-MM-dd", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Started", "Started", 46, DevExpress.Utils.FormatType.DateTime, "yyyy-MM-dd", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssignTo", "Assign To", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserEmail", "User Email", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssignedToEmail", "Assigned To Email", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Version", "Version", 45, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EntryType", "Entry Type", 63, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lookUpEdit1.Properties.DataSource = this.supportEntryBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "Title";
            this.lookUpEdit1.Properties.DropDownRows = 10;
            this.lookUpEdit1.Properties.NullText = "Select support entry";
            this.lookUpEdit1.Size = new System.Drawing.Size(464, 20);
            this.lookUpEdit1.TabIndex = 46;
            this.lookUpEdit1.Visible = false;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // supportEntryBindingSource
            // 
            this.supportEntryBindingSource.DataMember = "SupportEntry";
            this.supportEntryBindingSource.DataSource = this.supportDsBindingSource;
            // 
            // supportDsBindingSource
            // 
            this.supportDsBindingSource.DataSource = this.supportDs;
            this.supportDsBindingSource.Position = 0;
            // 
            // supportDs
            // 
            this.supportDs.DataSetName = "supportDs";
            this.supportDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supportEntryTableAdapter
            // 
            this.supportEntryTableAdapter.ClearBeforeFill = true;
            // 
            // ddContact
            // 
            this.ddContact.CurrentCustomer = 0;
            this.ddContact.Enabled = false;
            this.ddContact.Location = new System.Drawing.Point(327, 119);
            this.ddContact.Name = "ddContact";
            this.ddContact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Ny", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus, "Delete", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Call", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.ddContact.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-post"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-post"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-post")});
            this.ddContact.Properties.DisplayMember = "Name";
            this.ddContact.Properties.NullText = "Välj kontaktperson";
            this.ddContact.Properties.PopupWidth = 400;
            this.ddContact.Properties.ValueMember = "Id";
            this.ddContact.Size = new System.Drawing.Size(185, 20);
            this.ddContact.TabIndex = 50;
            this.ddContact.EditValueChanged += new System.EventHandler(this.comboBoxEdit1_EditValueChanged);
            // 
            // ddProject
            // 
            this.ddProject.CurrentCustomer = 0;
            this.ddProject.Enabled = false;
            this.ddProject.Location = new System.Drawing.Point(96, 119);
            this.ddProject.Name = "ddProject";
            this.ddProject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Ny", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus, "Delete", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true)});
            this.ddProject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Time", "Antal timmar"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Accepted", "Godkännd"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Time", "Antal timmar"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Accepted", "Godkännd"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Time", "Antal timmar"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Accepted", "Godkännd")});
            this.ddProject.Properties.DisplayMember = "Title";
            this.ddProject.Properties.NullText = "Välj projekt";
            this.ddProject.Properties.PopupWidth = 400;
            this.ddProject.Properties.ValueMember = "Id";
            this.ddProject.Size = new System.Drawing.Size(216, 20);
            this.ddProject.TabIndex = 49;
            this.ddProject.EditValueChanged += new System.EventHandler(this.luProject_EditValueChanged);
            // 
            // ddCustomer
            // 
            this.ddCustomer.Location = new System.Drawing.Point(96, 94);
            this.ddCustomer.Name = "ddCustomer";
            this.ddCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Ny", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", null, null, true)});
            this.ddCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerNr", "Kundnummer"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerNr", "Kundnummer"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerNr", "Kundnummer")});
            this.ddCustomer.Properties.DisplayMember = "CustomerName";
            this.ddCustomer.Properties.NullText = "Välj kund";
            this.ddCustomer.Properties.PopupWidth = 400;
            this.ddCustomer.Properties.ValueMember = "Id";
            this.ddCustomer.Size = new System.Drawing.Size(216, 20);
            this.ddCustomer.TabIndex = 48;
            this.ddCustomer.EditValueChanged += new System.EventHandler(this.luCompany_EditValueChanged);
            // 
            // UserDefinedFilterAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.ddContact);
            this.Controls.Add(this.ddProject);
            this.Controls.Add(this.ddCustomer);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.luOutlook);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDefinedFilterAppointmentForm";
            this.Load += new System.EventHandler(this.UserDefinedFilterAppointmentForm_Load);
            //this.Controls.SetChildIndex(this.tbDescription, 0);
            //this.Controls.SetChildIndex(this.edtResources, 0);
            //this.Controls.SetChildIndex(this.edtShowTimeAs, 0);
            //this.Controls.SetChildIndex(this.edtEndTime, 0);
            //this.Controls.SetChildIndex(this.edtEndDate, 0);
            //this.Controls.SetChildIndex(this.btnRecurrence, 0);
            //this.Controls.SetChildIndex(this.btnDelete, 0);
            //this.Controls.SetChildIndex(this.btnCancel, 0);
            //this.Controls.SetChildIndex(this.lblShowTimeAs, 0);
            //this.Controls.SetChildIndex(this.lblEndTime, 0);
            //this.Controls.SetChildIndex(this.lblLabel, 0);
            //this.Controls.SetChildIndex(this.tbLocation, 0);
            //this.Controls.SetChildIndex(this.lblSubject, 0);
            //this.Controls.SetChildIndex(this.lblLocation, 0);
            //this.Controls.SetChildIndex(this.tbSubject, 0);
            //this.Controls.SetChildIndex(this.lblStartTime, 0);
            //this.Controls.SetChildIndex(this.chkAllDay, 0);
            //this.Controls.SetChildIndex(this.btnOk, 0);
            //this.Controls.SetChildIndex(this.edtStartDate, 0);
            //this.Controls.SetChildIndex(this.edtStartTime, 0);
            //this.Controls.SetChildIndex(this.edtLabel, 0);
            //this.Controls.SetChildIndex(this.chkReminder, 0);
            //this.Controls.SetChildIndex(this.cbReminder, 0);
            //this.Controls.SetChildIndex(this.lblResource, 0);
            //this.Controls.SetChildIndex(this.edtResource, 0);
            //this.Controls.SetChildIndex(this.labelControl2, 0);
            //this.Controls.SetChildIndex(this.labelControl3, 0);
            //this.Controls.SetChildIndex(this.labelControl6, 0);
            //this.Controls.SetChildIndex(this.luOutlook, 0);
            //this.Controls.SetChildIndex(this.simpleButton1, 0);
            //this.Controls.SetChildIndex(this.lookUpEdit1, 0);
            //this.Controls.SetChildIndex(this.simpleButton2, 0);
            //this.Controls.SetChildIndex(this.ddCustomer, 0);
            //this.Controls.SetChildIndex(this.ddProject, 0);
            //this.Controls.SetChildIndex(this.ddContact, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luOutlook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportDsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddCustomer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource companysBindingSource;
        private companys companys;
        private System.Windows.Forms.BindingSource entryBindingSource;
        private TimeCommander2.companysTableAdapters.EntryTableAdapter entryTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit luOutlook;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.BindingSource supportDsBindingSource;
        private supportDs supportDs;
        private System.Windows.Forms.BindingSource supportEntryBindingSource;
        private TimeCommander2.supportDsTableAdapters.SupportEntryTableAdapter supportEntryTableAdapter;
        private WebdocOrder.Controls.CompanyDropdown ddCustomer;
        private WebdocOrder.Controls.OrderDropdown ddProject;
        private WebdocOrder.Controls.ContactDropdown ddContact;
	}
}
