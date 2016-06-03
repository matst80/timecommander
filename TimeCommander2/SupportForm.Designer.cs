namespace TimeCommander2
{
    partial class SupportForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.supportGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedToEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supportMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.markAsDoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supportDs = new TimeCommander2.supportDs();
            this.fillByUserToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByUserToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ddUser = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fillByNotCompleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.supportEntryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sites = new TimeCommander2.Sites();
            this.supportEntryTableAdapter1 = new TimeCommander2.SitesTableAdapters.SupportEntryTableAdapter();
            this.supportEntryTableAdapter = new TimeCommander2.supportDsTableAdapters.SupportEntryTableAdapter();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supportGrid)).BeginInit();
            this.supportMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supportEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportDs)).BeginInit();
            this.fillByUserToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supportEntryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sites)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.supportGrid);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1287, 593);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1287, 618);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.fillByUserToolStrip);
            // 
            // supportGrid
            // 
            this.supportGrid.AllowUserToAddRows = false;
            this.supportGrid.AllowUserToOrderColumns = true;
            this.supportGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.supportGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.supportGrid.AutoGenerateColumns = false;
            this.supportGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.supportGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supportGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.supportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.entryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.siteDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.addedDataGridViewTextBoxColumn,
            this.finishedDataGridViewTextBoxColumn,
            this.startedDataGridViewTextBoxColumn,
            this.assignToDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.assignedToEmailDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.entryTypeDataGridViewTextBoxColumn});
            this.supportGrid.ContextMenuStrip = this.supportMenu;
            this.supportGrid.DataSource = this.supportEntryBindingSource;
            this.supportGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supportGrid.Location = new System.Drawing.Point(0, 0);
            this.supportGrid.Name = "supportGrid";
            this.supportGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.supportGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supportGrid.RowTemplate.Height = 65;
            this.supportGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supportGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supportGrid.Size = new System.Drawing.Size(1287, 593);
            this.supportGrid.TabIndex = 3;
            this.supportGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.supportGrid_CellPainting);
            this.supportGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.supportGrid_MouseDoubleClick);
            this.supportGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 120;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 250;
            // 
            // entryDataGridViewTextBoxColumn
            // 
            this.entryDataGridViewTextBoxColumn.DataPropertyName = "Entry";
            this.entryDataGridViewTextBoxColumn.FillWeight = 180F;
            this.entryDataGridViewTextBoxColumn.HeaderText = "Description";
            this.entryDataGridViewTextBoxColumn.Name = "entryDataGridViewTextBoxColumn";
            this.entryDataGridViewTextBoxColumn.Width = 350;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.Width = 60;
            // 
            // siteDataGridViewTextBoxColumn
            // 
            this.siteDataGridViewTextBoxColumn.DataPropertyName = "Site";
            this.siteDataGridViewTextBoxColumn.HeaderText = "Site";
            this.siteDataGridViewTextBoxColumn.Name = "siteDataGridViewTextBoxColumn";
            this.siteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // addedDataGridViewTextBoxColumn
            // 
            this.addedDataGridViewTextBoxColumn.DataPropertyName = "Added";
            this.addedDataGridViewTextBoxColumn.HeaderText = "Added";
            this.addedDataGridViewTextBoxColumn.Name = "addedDataGridViewTextBoxColumn";
            // 
            // finishedDataGridViewTextBoxColumn
            // 
            this.finishedDataGridViewTextBoxColumn.DataPropertyName = "Finished";
            this.finishedDataGridViewTextBoxColumn.HeaderText = "Finished";
            this.finishedDataGridViewTextBoxColumn.Name = "finishedDataGridViewTextBoxColumn";
            this.finishedDataGridViewTextBoxColumn.Visible = false;
            // 
            // startedDataGridViewTextBoxColumn
            // 
            this.startedDataGridViewTextBoxColumn.DataPropertyName = "Started";
            this.startedDataGridViewTextBoxColumn.HeaderText = "Started";
            this.startedDataGridViewTextBoxColumn.Name = "startedDataGridViewTextBoxColumn";
            this.startedDataGridViewTextBoxColumn.Visible = false;
            // 
            // assignToDataGridViewTextBoxColumn
            // 
            this.assignToDataGridViewTextBoxColumn.DataPropertyName = "AssignTo";
            this.assignToDataGridViewTextBoxColumn.HeaderText = "Assigned to";
            this.assignToDataGridViewTextBoxColumn.Name = "assignToDataGridViewTextBoxColumn";
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "UserEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            this.userEmailDataGridViewTextBoxColumn.Visible = false;
            // 
            // assignedToEmailDataGridViewTextBoxColumn
            // 
            this.assignedToEmailDataGridViewTextBoxColumn.DataPropertyName = "AssignedToEmail";
            this.assignedToEmailDataGridViewTextBoxColumn.FillWeight = 120F;
            this.assignedToEmailDataGridViewTextBoxColumn.HeaderText = "Assigned to email";
            this.assignedToEmailDataGridViewTextBoxColumn.Name = "assignedToEmailDataGridViewTextBoxColumn";
            this.assignedToEmailDataGridViewTextBoxColumn.Visible = false;
            this.assignedToEmailDataGridViewTextBoxColumn.Width = 120;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.Visible = false;
            // 
            // entryTypeDataGridViewTextBoxColumn
            // 
            this.entryTypeDataGridViewTextBoxColumn.DataPropertyName = "EntryType";
            this.entryTypeDataGridViewTextBoxColumn.HeaderText = "EntryType";
            this.entryTypeDataGridViewTextBoxColumn.Name = "entryTypeDataGridViewTextBoxColumn";
            this.entryTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // supportMenu
            // 
            this.supportMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markAsDoneToolStripMenuItem,
            this.openConversationToolStripMenuItem});
            this.supportMenu.Name = "supportMenu";
            this.supportMenu.Size = new System.Drawing.Size(175, 48);
            // 
            // markAsDoneToolStripMenuItem
            // 
            this.markAsDoneToolStripMenuItem.Name = "markAsDoneToolStripMenuItem";
            this.markAsDoneToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.markAsDoneToolStripMenuItem.Text = "Mark as done";
            this.markAsDoneToolStripMenuItem.Click += new System.EventHandler(this.markAsDoneToolStripMenuItem_Click);
            // 
            // openConversationToolStripMenuItem
            // 
            this.openConversationToolStripMenuItem.Name = "openConversationToolStripMenuItem";
            this.openConversationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openConversationToolStripMenuItem.Text = "Open conversation";
            this.openConversationToolStripMenuItem.Click += new System.EventHandler(this.openConversationToolStripMenuItem_Click);
            // 
            // supportEntryBindingSource
            // 
            this.supportEntryBindingSource.DataMember = "SupportEntry";
            this.supportEntryBindingSource.DataSource = this.supportDs;
            // 
            // supportDs
            // 
            this.supportDs.DataSetName = "supportDs";
            this.supportDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByUserToolStrip
            // 
            this.fillByUserToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByUserToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByUserToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByUserToolStripButton,
            this.ddUser,
            this.toolStripSeparator1,
            this.fillByNotCompleteToolStripButton,
            this.toolStripButton1});
            this.fillByUserToolStrip.Location = new System.Drawing.Point(3, 0);
            this.fillByUserToolStrip.Name = "fillByUserToolStrip";
            this.fillByUserToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.fillByUserToolStrip.Size = new System.Drawing.Size(349, 25);
            this.fillByUserToolStrip.TabIndex = 3;
            this.fillByUserToolStrip.Text = "fillByUserToolStrip";
            // 
            // fillByUserToolStripButton
            // 
            this.fillByUserToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillByUserToolStripButton.Image")));
            this.fillByUserToolStripButton.Name = "fillByUserToolStripButton";
            this.fillByUserToolStripButton.Size = new System.Drawing.Size(82, 22);
            this.fillByUserToolStripButton.Text = "Show only";
            this.fillByUserToolStripButton.Click += new System.EventHandler(this.fillByUserToolStripButton_Click);
            // 
            // ddUser
            // 
            this.ddUser.Name = "ddUser";
            this.ddUser.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // fillByNotCompleteToolStripButton
            // 
            this.fillByNotCompleteToolStripButton.Checked = true;
            this.fillByNotCompleteToolStripButton.CheckOnClick = true;
            this.fillByNotCompleteToolStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fillByNotCompleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillByNotCompleteToolStripButton.Image")));
            this.fillByNotCompleteToolStripButton.Name = "fillByNotCompleteToolStripButton";
            this.fillByNotCompleteToolStripButton.Size = new System.Drawing.Size(112, 22);
            this.fillByNotCompleteToolStripButton.Text = "Hide completed";
            this.fillByNotCompleteToolStripButton.Click += new System.EventHandler(this.fillByNotCompleteToolStripButton_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // supportEntryBindingSource1
            // 
            this.supportEntryBindingSource1.DataMember = "SupportEntry";
            this.supportEntryBindingSource1.DataSource = this.sites;
            // 
            // sites
            // 
            this.sites.DataSetName = "Sites";
            this.sites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supportEntryTableAdapter1
            // 
            this.supportEntryTableAdapter1.ClearBeforeFill = true;
            // 
            // supportEntryTableAdapter
            // 
            this.supportEntryTableAdapter.ClearBeforeFill = true;
            // 
            // SupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 618);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupportForm";
            this.Text = "Support entrys";
            this.Load += new System.EventHandler(this.SupportForm_Load);
            this.Shown += new System.EventHandler(this.SupportForm_Shown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supportGrid)).EndInit();
            this.supportMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supportEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportDs)).EndInit();
            this.fillByUserToolStrip.ResumeLayout(false);
            this.fillByUserToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supportEntryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView supportGrid;
        private supportDs supportDs;
        private System.Windows.Forms.BindingSource supportEntryBindingSource;
        private TimeCommander2.supportDsTableAdapters.SupportEntryTableAdapter supportEntryTableAdapter;
        private System.Windows.Forms.ContextMenuStrip supportMenu;
        private System.Windows.Forms.ToolStripMenuItem markAsDoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConversationToolStripMenuItem;
        private Sites sites;
        private System.Windows.Forms.BindingSource supportEntryBindingSource1;
        private TimeCommander2.SitesTableAdapters.SupportEntryTableAdapter supportEntryTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByUserToolStrip;
        private System.Windows.Forms.ToolStripButton fillByUserToolStripButton;
        private System.Windows.Forms.ToolStripComboBox ddUser;
        private System.Windows.Forms.ToolStripButton fillByNotCompleteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedToEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTypeDataGridViewTextBoxColumn;
    }
}