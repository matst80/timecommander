namespace WebdocOrder.GUI
{
    partial class Customer
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
            this.contactPersonBindingSource = new System.Windows.Forms.BindingSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ddContact = new WebdocOrder.Controls.ContactDropdown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.teAdress = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teCustNr = new DevExpress.XtraEditors.TextEdit();
            this.teOrgnr = new DevExpress.XtraEditors.TextEdit();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.teNotes = new DevExpress.XtraEditors.MemoEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvContacts = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gdTime = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ourReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yourReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.invoicedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doneDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sendDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allDayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newEntryBindingSource = new System.Windows.Forms.BindingSource();
            this.entrys = new WebdocOrder.entrys();
            this.newEntryTableAdapter = new WebdocOrder.entrysTableAdapters.NewEntryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.contactPersonBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCustNr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOrgnr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNotes.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrys)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 494);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ddContact);
            this.tabPage1.Controls.Add(this.labelControl6);
            this.tabPage1.Controls.Add(this.labelControl5);
            this.tabPage1.Controls.Add(this.teAdress);
            this.tabPage1.Controls.Add(this.simpleButton1);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.teCustNr);
            this.tabPage1.Controls.Add(this.teOrgnr);
            this.tabPage1.Controls.Add(this.teName);
            this.tabPage1.Controls.Add(this.teNotes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kundinformation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ddContact
            // 
            this.ddContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ddContact.CurrentCustomer = 0;
            this.ddContact.Enabled = false;
            this.ddContact.Location = new System.Drawing.Point(6, 392);
            this.ddContact.Name = "ddContact";
            this.ddContact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Ny", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus, "Delete", -1, false, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
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
            this.ddContact.Size = new System.Drawing.Size(400, 20);
            this.ddContact.TabIndex = 21;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 373);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(116, 13);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Standard kontaktperson";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 206);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Adress";
            // 
            // teAdress
            // 
            this.teAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.teAdress.Location = new System.Drawing.Point(6, 225);
            this.teAdress.Name = "teAdress";
            this.teAdress.Size = new System.Drawing.Size(400, 82);
            this.teAdress.TabIndex = 16;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(300, 439);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 23);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Spara";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 313);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Kundnummer";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Anteckningar";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Orgnummer";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Kundnamn";
            // 
            // teCustNr
            // 
            this.teCustNr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.teCustNr.Location = new System.Drawing.Point(7, 332);
            this.teCustNr.Name = "teCustNr";
            this.teCustNr.Size = new System.Drawing.Size(400, 20);
            this.teCustNr.TabIndex = 18;
            // 
            // teOrgnr
            // 
            this.teOrgnr.Location = new System.Drawing.Point(6, 71);
            this.teOrgnr.Name = "teOrgnr";
            this.teOrgnr.Size = new System.Drawing.Size(117, 20);
            this.teOrgnr.TabIndex = 14;
            // 
            // teName
            // 
            this.teName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.teName.Location = new System.Drawing.Point(6, 26);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(400, 20);
            this.teName.TabIndex = 13;
            // 
            // teNotes
            // 
            this.teNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.teNotes.Location = new System.Drawing.Point(6, 116);
            this.teNotes.Name = "teNotes";
            this.teNotes.Size = new System.Drawing.Size(400, 84);
            this.teNotes.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvContacts);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kontaktpersoner";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lvContacts
            // 
            this.lvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvContacts.Location = new System.Drawing.Point(6, 6);
            this.lvContacts.Name = "lvContacts";
            this.lvContacts.Size = new System.Drawing.Size(400, 456);
            this.lvContacts.TabIndex = 0;
            this.lvContacts.UseCompatibleStateImageBehavior = false;
            this.lvContacts.SelectedIndexChanged += new System.EventHandler(this.lvContacts_SelectedIndexChanged);
            this.lvContacts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvContacts_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvOrders);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(412, 468);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ordrar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvOrders
            // 
            this.lvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvOrders.Location = new System.Drawing.Point(6, 6);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(400, 456);
            this.lvOrders.TabIndex = 0;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.gdTime);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(412, 468);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Debiterbar tid";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gdTime
            // 
            this.gdTime.AllowUserToAddRows = false;
            this.gdTime.AllowUserToDeleteRows = false;
            this.gdTime.AutoGenerateColumns = false;
            this.gdTime.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gdTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.ourReferenceDataGridViewTextBoxColumn,
            this.yourReferenceDataGridViewTextBoxColumn,
            this.eventTimeDataGridViewTextBoxColumn,
            this.deadLineDataGridViewTextBoxColumn,
            this.parentDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.internalDataGridViewCheckBoxColumn,
            this.invoicedDataGridViewCheckBoxColumn,
            this.doneDataGridViewCheckBoxColumn,
            this.isSentDataGridViewCheckBoxColumn,
            this.sendDateDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.allDayDataGridViewCheckBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.resourceIdDataGridViewTextBoxColumn,
            this.eventTypeDataGridViewTextBoxColumn,
            this.projectIdDataGridViewTextBoxColumn,
            this.entryTitleDataGridViewTextBoxColumn,
            this.invoiceIdDataGridViewTextBoxColumn});
            this.gdTime.DataSource = this.newEntryBindingSource;
            this.gdTime.Location = new System.Drawing.Point(6, 6);
            this.gdTime.Name = "gdTime";
            this.gdTime.ReadOnly = true;
            this.gdTime.Size = new System.Drawing.Size(400, 456);
            this.gdTime.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ourReferenceDataGridViewTextBoxColumn
            // 
            this.ourReferenceDataGridViewTextBoxColumn.DataPropertyName = "OurReference";
            this.ourReferenceDataGridViewTextBoxColumn.HeaderText = "OurReference";
            this.ourReferenceDataGridViewTextBoxColumn.Name = "ourReferenceDataGridViewTextBoxColumn";
            this.ourReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yourReferenceDataGridViewTextBoxColumn
            // 
            this.yourReferenceDataGridViewTextBoxColumn.DataPropertyName = "YourReference";
            this.yourReferenceDataGridViewTextBoxColumn.HeaderText = "YourReference";
            this.yourReferenceDataGridViewTextBoxColumn.Name = "yourReferenceDataGridViewTextBoxColumn";
            this.yourReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventTimeDataGridViewTextBoxColumn
            // 
            this.eventTimeDataGridViewTextBoxColumn.DataPropertyName = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.HeaderText = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.Name = "eventTimeDataGridViewTextBoxColumn";
            this.eventTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deadLineDataGridViewTextBoxColumn
            // 
            this.deadLineDataGridViewTextBoxColumn.DataPropertyName = "DeadLine";
            this.deadLineDataGridViewTextBoxColumn.HeaderText = "DeadLine";
            this.deadLineDataGridViewTextBoxColumn.Name = "deadLineDataGridViewTextBoxColumn";
            this.deadLineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentDataGridViewTextBoxColumn
            // 
            this.parentDataGridViewTextBoxColumn.DataPropertyName = "Parent";
            this.parentDataGridViewTextBoxColumn.HeaderText = "Parent";
            this.parentDataGridViewTextBoxColumn.Name = "parentDataGridViewTextBoxColumn";
            this.parentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // internalDataGridViewCheckBoxColumn
            // 
            this.internalDataGridViewCheckBoxColumn.DataPropertyName = "Internal";
            this.internalDataGridViewCheckBoxColumn.HeaderText = "Internal";
            this.internalDataGridViewCheckBoxColumn.Name = "internalDataGridViewCheckBoxColumn";
            this.internalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // invoicedDataGridViewCheckBoxColumn
            // 
            this.invoicedDataGridViewCheckBoxColumn.DataPropertyName = "Invoiced";
            this.invoicedDataGridViewCheckBoxColumn.HeaderText = "Invoiced";
            this.invoicedDataGridViewCheckBoxColumn.Name = "invoicedDataGridViewCheckBoxColumn";
            this.invoicedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // doneDataGridViewCheckBoxColumn
            // 
            this.doneDataGridViewCheckBoxColumn.DataPropertyName = "Done";
            this.doneDataGridViewCheckBoxColumn.HeaderText = "Done";
            this.doneDataGridViewCheckBoxColumn.Name = "doneDataGridViewCheckBoxColumn";
            this.doneDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isSentDataGridViewCheckBoxColumn
            // 
            this.isSentDataGridViewCheckBoxColumn.DataPropertyName = "IsSent";
            this.isSentDataGridViewCheckBoxColumn.HeaderText = "IsSent";
            this.isSentDataGridViewCheckBoxColumn.Name = "isSentDataGridViewCheckBoxColumn";
            this.isSentDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sendDateDataGridViewTextBoxColumn
            // 
            this.sendDateDataGridViewTextBoxColumn.DataPropertyName = "SendDate";
            this.sendDateDataGridViewTextBoxColumn.HeaderText = "SendDate";
            this.sendDateDataGridViewTextBoxColumn.Name = "sendDateDataGridViewTextBoxColumn";
            this.sendDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allDayDataGridViewCheckBoxColumn
            // 
            this.allDayDataGridViewCheckBoxColumn.DataPropertyName = "AllDay";
            this.allDayDataGridViewCheckBoxColumn.HeaderText = "AllDay";
            this.allDayDataGridViewCheckBoxColumn.Name = "allDayDataGridViewCheckBoxColumn";
            this.allDayDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resourceIdDataGridViewTextBoxColumn
            // 
            this.resourceIdDataGridViewTextBoxColumn.DataPropertyName = "ResourceId";
            this.resourceIdDataGridViewTextBoxColumn.HeaderText = "ResourceId";
            this.resourceIdDataGridViewTextBoxColumn.Name = "resourceIdDataGridViewTextBoxColumn";
            this.resourceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventTypeDataGridViewTextBoxColumn
            // 
            this.eventTypeDataGridViewTextBoxColumn.DataPropertyName = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.HeaderText = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.Name = "eventTypeDataGridViewTextBoxColumn";
            this.eventTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryTitleDataGridViewTextBoxColumn
            // 
            this.entryTitleDataGridViewTextBoxColumn.DataPropertyName = "EntryTitle";
            this.entryTitleDataGridViewTextBoxColumn.HeaderText = "EntryTitle";
            this.entryTitleDataGridViewTextBoxColumn.Name = "entryTitleDataGridViewTextBoxColumn";
            this.entryTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newEntryBindingSource
            // 
            this.newEntryBindingSource.DataMember = "NewEntry";
            this.newEntryBindingSource.DataSource = this.entrys;
            // 
            // entrys
            // 
            this.entrys.DataSetName = "entrys";
            this.entrys.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newEntryTableAdapter
            // 
            this.newEntryTableAdapter.ClearBeforeFill = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 518);
            this.Controls.Add(this.tabControl1);
            this.Name = "Customer";
            this.Text = "Kund";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactPersonBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCustNr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOrgnr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNotes.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource contactPersonBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Controls.ContactDropdown ddContact;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit teAdress;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teCustNr;
        private DevExpress.XtraEditors.TextEdit teOrgnr;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.MemoEdit teNotes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvContacts;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.DataGridView gdTime;
        private entrys entrys;
        private System.Windows.Forms.BindingSource newEntryBindingSource;
        private entrysTableAdapters.NewEntryTableAdapter newEntryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ourReferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yourReferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn internalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn invoicedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn doneDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allDayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
    }
}