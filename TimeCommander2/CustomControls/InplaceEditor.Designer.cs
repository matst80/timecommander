namespace TimeCommander2.CustomControls
{
    partial class InplaceEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ddContact = new WebdocOrder.Controls.ContactDropdown();
            this.ddProject = new WebdocOrder.Controls.OrderDropdown();
            this.ddCompany = new WebdocOrder.Controls.CompanyDropdown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.edtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.appointmentLabelEdit = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            this.edtSubject = new DevExpress.XtraEditors.TextEdit();
            this.entryBindingSource = new System.Windows.Forms.BindingSource();
            this.companys = new TimeCommander2.companys();
            this.entryTableAdapter = new TimeCommander2.companysTableAdapters.EntryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentLabelEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companys)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ddContact);
            this.groupControl1.Controls.Add(this.ddProject);
            this.groupControl1.Controls.Add(this.ddCompany);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.edtDescription);
            this.groupControl1.Controls.Add(this.appointmentLabelEdit);
            this.groupControl1.Controls.Add(this.edtSubject);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.SkinName = "iMaginary";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(257, 369);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Time entry";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // ddContact
            // 
            this.ddContact.CurrentCustomer = 0;
            this.ddContact.Enabled = false;
            this.ddContact.Location = new System.Drawing.Point(12, 284);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-post")});
            this.ddContact.Properties.DisplayMember = "Name";
            this.ddContact.Properties.NullText = "Välj kontaktperson";
            this.ddContact.Properties.PopupWidth = 400;
            this.ddContact.Properties.ValueMember = "Id";
            this.ddContact.Size = new System.Drawing.Size(232, 20);
            this.ddContact.TabIndex = 4;
            // 
            // ddProject
            // 
            this.ddProject.CurrentCustomer = 0;
            this.ddProject.Enabled = false;
            this.ddProject.Location = new System.Drawing.Point(12, 137);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Accepted", "Godkännd")});
            this.ddProject.Properties.DisplayMember = "Title";
            this.ddProject.Properties.NullText = "Välj projekt";
            this.ddProject.Properties.PopupWidth = 400;
            this.ddProject.Properties.ValueMember = "Id";
            this.ddProject.Size = new System.Drawing.Size(232, 20);
            this.ddProject.TabIndex = 2;
            this.ddProject.EditValueChanged += new System.EventHandler(this.ddProject_EditValueChanged);
            // 
            // ddCompany
            // 
            this.ddCompany.Location = new System.Drawing.Point(12, 92);
            this.ddCompany.Name = "ddCompany";
            this.ddCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Ny", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", null, null, true)});
            this.ddCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerNr", "Kundnummer"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerNr", "Kundnummer")});
            this.ddCompany.Properties.DisplayMember = "CustomerName";
            this.ddCompany.Properties.NullText = "Välj kund";
            this.ddCompany.Properties.PopupWidth = 400;
            this.ddCompany.Properties.ValueMember = "Id";
            this.ddCompany.Size = new System.Drawing.Size(232, 20);
            this.ddCompany.TabIndex = 1;
            this.ddCompany.EditValueChanged += new System.EventHandler(this.ddCompany_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 265);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Reference";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 310);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Type";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Customer";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Project";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 163);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Description";
            // 
            // edtDescription
            // 
            this.edtDescription.EditValue = "";
            this.edtDescription.Location = new System.Drawing.Point(12, 182);
            this.edtDescription.MinimumSize = new System.Drawing.Size(0, 32);
            this.edtDescription.Name = "edtDescription";
            this.edtDescription.Size = new System.Drawing.Size(232, 77);
            this.edtDescription.TabIndex = 3;
            // 
            // appointmentLabelEdit
            // 
            this.appointmentLabelEdit.Location = new System.Drawing.Point(12, 329);
            this.appointmentLabelEdit.Name = "appointmentLabelEdit";
            this.appointmentLabelEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.appointmentLabelEdit.Size = new System.Drawing.Size(232, 20);
            this.appointmentLabelEdit.TabIndex = 5;
            // 
            // edtSubject
            // 
            this.edtSubject.EditValue = "";
            this.edtSubject.Location = new System.Drawing.Point(12, 47);
            this.edtSubject.Name = "edtSubject";
            this.edtSubject.Size = new System.Drawing.Size(232, 20);
            this.edtSubject.TabIndex = 0;
            // 
            // entryBindingSource
            // 
            this.entryBindingSource.DataMember = "Entry";
            this.entryBindingSource.DataSource = this.companys;
            this.entryBindingSource.CurrentChanged += new System.EventHandler(this.entryBindingSource_CurrentChanged);
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
            // InplaceEditor
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(257, 369);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(257, 369);
            this.Name = "InplaceEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.InplaceEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentLabelEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit edtDescription;
        private DevExpress.XtraScheduler.UI.AppointmentLabelEdit appointmentLabelEdit;
        private DevExpress.XtraEditors.TextEdit edtSubject;
        private companys companys;
        private System.Windows.Forms.BindingSource entryBindingSource;
        private TimeCommander2.companysTableAdapters.EntryTableAdapter entryTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private WebdocOrder.Controls.ContactDropdown ddContact;
        private WebdocOrder.Controls.OrderDropdown ddProject;
        private WebdocOrder.Controls.CompanyDropdown ddCompany;




    }
}
