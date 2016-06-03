namespace WebdocOrder.GUI
{
    partial class Order
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            this.teTitle = new DevExpress.XtraEditors.TextEdit();
            this.teHours = new DevExpress.XtraEditors.TextEdit();
            this.teHourPrice = new DevExpress.XtraEditors.TextEdit();
            this.teDescription = new DevExpress.XtraEditors.MemoEdit();
            this.cbAccepted = new DevExpress.XtraEditors.CheckEdit();
            this.ddType = new DevExpress.XtraEditors.DropDownButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.teSum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.teLicense = new DevExpress.XtraEditors.TextEdit();
            this.ddTech = new WebdocOrder.Controls.ContactDropdown();
            this.ddCompany = new WebdocOrder.Controls.CompanyDropdown();
            this.ddContact = new WebdocOrder.Controls.ContactDropdown();
            this.ddParent = new WebdocOrder.Controls.OrderDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHours.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHourPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAccepted.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLicense.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddTech.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddParent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teTitle
            // 
            this.teTitle.Location = new System.Drawing.Point(10, 83);
            this.teTitle.Name = "teTitle";
            this.teTitle.Size = new System.Drawing.Size(271, 20);
            this.teTitle.TabIndex = 1;
            // 
            // teHours
            // 
            this.teHours.EditValue = "0";
            this.teHours.Location = new System.Drawing.Point(10, 134);
            this.teHours.Name = "teHours";
            this.teHours.Size = new System.Drawing.Size(72, 20);
            this.teHours.TabIndex = 2;
            this.teHours.EditValueChanged += new System.EventHandler(this.teHours_EditValueChanged);
            // 
            // teHourPrice
            // 
            this.teHourPrice.EditValue = "850";
            this.teHourPrice.Location = new System.Drawing.Point(96, 134);
            this.teHourPrice.Name = "teHourPrice";
            this.teHourPrice.Size = new System.Drawing.Size(58, 20);
            this.teHourPrice.TabIndex = 3;
            this.teHourPrice.EditValueChanged += new System.EventHandler(this.teHourPrice_EditValueChanged);
            // 
            // teDescription
            // 
            this.teDescription.Location = new System.Drawing.Point(11, 251);
            this.teDescription.Name = "teDescription";
            this.teDescription.Size = new System.Drawing.Size(271, 159);
            this.teDescription.TabIndex = 6;
            // 
            // cbAccepted
            // 
            this.cbAccepted.EditValue = true;
            this.cbAccepted.Location = new System.Drawing.Point(11, 420);
            this.cbAccepted.Name = "cbAccepted";
            this.cbAccepted.Properties.Caption = "Accepterad";
            this.cbAccepted.Size = new System.Drawing.Size(96, 19);
            this.cbAccepted.TabIndex = 10;
            // 
            // ddType
            // 
            this.ddType.Location = new System.Drawing.Point(113, 416);
            this.ddType.Name = "ddType";
            this.ddType.Size = new System.Drawing.Size(169, 23);
            this.ddType.TabIndex = 11;
            this.ddType.Text = "Kundtyp";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(187, 553);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(95, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Spara";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Företag";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Titel";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Antal timmar";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(96, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Timpris";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 232);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Beskrivning";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 452);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Kontaktperson";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 497);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(107, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Teknisk kontaktperson";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(166, 115);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Summa";
            // 
            // teSum
            // 
            this.teSum.EditValue = "";
            this.teSum.Enabled = false;
            this.teSum.Location = new System.Drawing.Point(166, 134);
            this.teSum.Name = "teSum";
            this.teSum.Size = new System.Drawing.Size(58, 20);
            this.teSum.TabIndex = 25;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 187);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(78, 13);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Länka till projekt";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(166, 160);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 13);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Licenspris";
            // 
            // teLicense
            // 
            this.teLicense.EditValue = "0";
            this.teLicense.Location = new System.Drawing.Point(164, 179);
            this.teLicense.Name = "teLicense";
            this.teLicense.Size = new System.Drawing.Size(72, 20);
            this.teLicense.TabIndex = 4;
            this.teLicense.EditValueChanged += new System.EventHandler(this.teLicense_EditValueChanged);
            // 
            // ddTech
            // 
            this.ddTech.CurrentCustomer = 0;
            this.ddTech.Location = new System.Drawing.Point(11, 516);
            this.ddTech.Name = "ddTech";
            this.ddTech.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Ny", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus, "Delete", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.ddTech.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-post"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-post"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-post")});
            this.ddTech.Properties.DisplayMember = "Name";
            this.ddTech.Properties.NullText = "Välj teknisk kontaktperson";
            this.ddTech.Properties.PopupWidth = 400;
            this.ddTech.Properties.ValueMember = "Id";
            this.ddTech.Size = new System.Drawing.Size(269, 20);
            this.ddTech.TabIndex = 8;
            // 
            // ddCompany
            // 
            this.ddCompany.Location = new System.Drawing.Point(10, 31);
            this.ddCompany.Name = "ddCompany";
            this.ddCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Ny", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.ddCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerNr", "Kundnummer"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerNr", "Kundnummer")});
            this.ddCompany.Properties.DisplayMember = "CustomerName";
            this.ddCompany.Properties.ImmediatePopup = true;
            this.ddCompany.Properties.NullText = "Välj kund";
            this.ddCompany.Properties.PopupWidth = 400;
            this.ddCompany.Properties.ValueMember = "Id";
            this.ddCompany.Size = new System.Drawing.Size(270, 20);
            this.ddCompany.TabIndex = 0;
            this.ddCompany.EditValueChanged += new System.EventHandler(this.ddCompany_EditValueChanged);
            // 
            // ddContact
            // 
            this.ddContact.CurrentCustomer = 0;
            this.ddContact.Location = new System.Drawing.Point(12, 472);
            this.ddContact.Name = "ddContact";
            this.ddContact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Ny", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus, "Delete", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true)});
            this.ddContact.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-post"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-post")});
            this.ddContact.Properties.DisplayMember = "Name";
            this.ddContact.Properties.NullText = "Välj kontaktperson";
            this.ddContact.Properties.PopupWidth = 400;
            this.ddContact.Properties.ValueMember = "Id";
            this.ddContact.Size = new System.Drawing.Size(269, 20);
            this.ddContact.TabIndex = 7;
            // 
            // ddParent
            // 
            this.ddParent.CurrentCustomer = 0;
            this.ddParent.Location = new System.Drawing.Point(12, 206);
            this.ddParent.Name = "ddParent";
            this.ddParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Ny", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject10, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus, "Delete", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject11, "", null, null, true)});
            this.ddParent.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Time", "Antal timmar"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Accepted", "Godkännd"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", 40, "Namn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Time", "Antal timmar"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Accepted", "Godkännd")});
            this.ddParent.Properties.DisplayMember = "Title";
            this.ddParent.Properties.NullText = "Välj order";
            this.ddParent.Properties.PopupWidth = 400;
            this.ddParent.Properties.ValueMember = "Id";
            this.ddParent.Size = new System.Drawing.Size(268, 20);
            this.ddParent.TabIndex = 26;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 588);
            this.Controls.Add(this.ddTech);
            this.Controls.Add(this.ddCompany);
            this.Controls.Add(this.ddContact);
            this.Controls.Add(this.ddParent);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.teLicense);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.teSum);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.ddType);
            this.Controls.Add(this.cbAccepted);
            this.Controls.Add(this.teHourPrice);
            this.Controls.Add(this.teHours);
            this.Controls.Add(this.teTitle);
            this.Controls.Add(this.teDescription);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHours.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHourPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAccepted.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLicense.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddTech.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddParent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teTitle;
        private DevExpress.XtraEditors.TextEdit teHours;
        private DevExpress.XtraEditors.TextEdit teHourPrice;
        private DevExpress.XtraEditors.MemoEdit teDescription;
        private DevExpress.XtraEditors.CheckEdit cbAccepted;
        private DevExpress.XtraEditors.DropDownButton ddType;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit teSum;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit teLicense;
        private Controls.OrderDropdown ddParent;
        private Controls.ContactDropdown ddContact;
        private Controls.CompanyDropdown ddCompany;
        private Controls.ContactDropdown ddTech;
    }
}