namespace TimeCommander2
{
    partial class NewSupportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSupportForm));
            this.cbSite = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbEmail = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbAssignedTo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tTitle = new DevExpress.XtraEditors.TextEdit();
            this.tDescription = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAssignedTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSite
            // 
            this.cbSite.Location = new System.Drawing.Point(12, 31);
            this.cbSite.Name = "cbSite";
            this.cbSite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSite.Size = new System.Drawing.Size(245, 20);
            this.cbSite.TabIndex = 0;
            this.cbSite.SelectedIndexChanged += new System.EventHandler(this.cbSite_SelectedIndexChanged);
            // 
            // cbEmail
            // 
            this.cbEmail.Location = new System.Drawing.Point(12, 76);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEmail.Size = new System.Drawing.Size(245, 20);
            this.cbEmail.TabIndex = 1;
            // 
            // cbAssignedTo
            // 
            this.cbAssignedTo.Enabled = false;
            this.cbAssignedTo.Location = new System.Drawing.Point(12, 121);
            this.cbAssignedTo.Name = "cbAssignedTo";
            this.cbAssignedTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAssignedTo.Size = new System.Drawing.Size(245, 20);
            this.cbAssignedTo.TabIndex = 2;
            // 
            // tTitle
            // 
            this.tTitle.Location = new System.Drawing.Point(12, 166);
            this.tTitle.Name = "tTitle";
            this.tTitle.Size = new System.Drawing.Size(245, 20);
            this.tTitle.TabIndex = 3;
            // 
            // tDescription
            // 
            this.tDescription.Location = new System.Drawing.Point(12, 211);
            this.tDescription.Name = "tDescription";
            this.tDescription.Size = new System.Drawing.Size(245, 96);
            this.tDescription.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "User site";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "User email";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Assigned to";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(20, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Title";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 192);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Description";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Location = new System.Drawing.Point(181, 314);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // NewSupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 354);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tDescription);
            this.Controls.Add(this.tTitle);
            this.Controls.Add(this.cbAssignedTo);
            this.Controls.Add(this.cbEmail);
            this.Controls.Add(this.cbSite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewSupportForm";
            this.Text = "Submit support entry";
            this.Shown += new System.EventHandler(this.NewSupportForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cbSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAssignedTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbSite;
        private DevExpress.XtraEditors.ComboBoxEdit cbEmail;
        private DevExpress.XtraEditors.ComboBoxEdit cbAssignedTo;
        private DevExpress.XtraEditors.TextEdit tTitle;
        private DevExpress.XtraEditors.MemoEdit tDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}