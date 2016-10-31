using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Core.DAL;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;
using TimeCommander2.CustomControls;

namespace TimeCommander2
{
    public partial class TimeApp : DevExpress.XtraEditors.XtraForm
    {
        public TimeApp()
        {
            InitializeComponent();
        }

        //private TaskbarManager windowsTaskbar;

        //private ThumbnailToolbarButton tb;

        public Helpers.Configuration CurrentConfig;

        private void TimeApp_Load(object sender, EventArgs e)
        {
          //  Core.DAL.ConnectionFactory.BeforeRequest();
            // TODO: This line of code loads data into the 'supportDs.SupportEntry' table. You can move, or remove it, as needed.
            //this.supportEntryTableAdapter.Fill(this.supportDs.SupportEntry);
            this.LookAndFeel.Style = LookAndFeelStyle.UltraFlat;
            
            //this.LookAndFeel.SkinName = "Office 2007 Blue";
            //this.entryCal.LookAndFeel.SkinName = "Office 2007 Blue";
            CurrentConfig = new TimeCommander2.Helpers.Configuration();

            /*if (CurrentConfig.UseWindows7)
                windowsTaskbar = TaskbarManager.Instance;*/
            /*useWindows7ToolStripMenuItem.Checked = CurrentConfig.UseWindows7;
            useKeyboardhooksToolStripMenuItem.Checked = CurrentConfig.UseKeyboardHooks;*/
            //toolStripButton10.Checked = CurrentConfig.UseWindows7;
            //toolStripButton11.Checked = CurrentConfig.UseKeyboardHooks;
            // TODO: This line of code loads data into the 'users.EntryUsers' table. You can move, or remove it, as needed.
            this.entryUsersTableAdapter.Fill(this.users.EntryUsers);
            // TODO: This line of code loads data into the 'entrys.Entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.entrys.Entry);
            
            entryCal.GroupType = SchedulerGroupType.Resource;
            entryCal.OptionsView.ShowOnlyResourceAppointments = true;
            entryCal.Services.ResourceNavigation.ResourcePerPage = 1;
            entryCal.Services.DateTimeNavigation.GoToToday();
            
            entryCal.Services.ResourceNavigation.GoToResourceById(CurrentConfig.UserId);


            //calStorage.Appointments.ResourceSharing = true;

            //entryCal.Services.ResourceNavigation.ResourcePerPage = 1;
            //entryCal.Services.ResourceNavigation.GoToResourceById(8);
           /* if (CurrentConfig.UseWindows7)
            {
                
            }*/
        }

        //void tb_Click(object sender, ThumbnailButtonClickedEventArgs e)
        //{
        //    TimerActive = !TimerActive;
        //    TimerStatusChanged();
        //}

        /*
        private void enumFilterCustomers()
        {
            foreach (string s in wd.Time.Tables.Entry.ListAllCompanys())
            {
                ddFilterCompanys.Items.Add(s);
            }
        }
        */
        public class User
        {
            public string Username;
            public int UserId;

            public User(string username, int userid)
            {
                Username = username;
                UserId = userid;
            }

            public User(DataRow dr)
            {
                Username = (string)dr["Username"];
                UserId = (int)dr["Id"];
            }

            public override string ToString()
            {
                return Username;
            }
        }

        private void enumUsers()
        {
            //barSubItem1.add.Items.Clear();
            DataSet sqlGetUsers = DataAdapter.sqlGetDS("SELECT * FROM EntryUsers");
            foreach (DataRow dr in sqlGetUsers.Tables[0].Rows)
            {
                User u = new User(dr);

                barListItem1.Strings.Add(u.Username);
                //((RepositoryItemComboBox)barListItem1.Edit).Items.Add(u);
                if (CurrentConfig.UserId == u.UserId)
                {
                    barEditItem1.EditValue = u.Username;
                    barEditItem1.Caption = u.Username;
                }
                //barSubItem1.crea
                //cbCurrentUser.Items.Add(u);
                //cbCurrentUser.
                //if (CurrentConfig.UserId == u.UserId)
                //  cbCurrentUser.SelectedItem = u;
            }
        }

        private void calStorage_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            entryTableAdapter.Update(entrys.Entry);
            //UpdateProgress();

        }

        private void calStorage_AppointmentsInserted(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            entryTableAdapter.Update(entrys.Entry);
            //UpdateProgress();
        }

        private void calStorage_AppointmentsDeleted(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            entryTableAdapter.Update(entrys.Entry);
            //UpdateProgress();
        }

        private void entryCal_InplaceEditorShowing(object sender, DevExpress.XtraScheduler.InplaceEditorEventArgs e)
        {
            e.InplaceEditorEx = new ProjectSelector(e.SchedulerInplaceEditorEventArgs);
        }


        public class ProjectSelector : ISchedulerInplaceEditorEx
        {
            InplaceEditor editor;
            Appointment appointment;
            SchedulerControl control;
            public ProjectSelector(SchedulerInplaceEditorEventArgs inplaceEditorArgs)
            {
                this.appointment = inplaceEditorArgs.ViewInfo.Appointment;
                this.control = inplaceEditorArgs.Control;
                CreateEditor(inplaceEditorArgs);
            }
            InplaceEditor Editor { get { return editor; } }
            Appointment Appointment { get { return appointment; } }
            SchedulerControl Control { get { return control; } }

            public event EventHandler CommitChanges;
            public event EventHandler RollbackChanges;

            void CreateEditor(SchedulerInplaceEditorEventArgs inplaceEditorArgs)
            {
                this.editor = new InplaceEditor();
                Editor.Bounds = AdjustEditorBounds(inplaceEditorArgs.Control, inplaceEditorArgs.Bounds);
            }

            private Rectangle AdjustEditorBounds(SchedulerControl control, Rectangle editorBounds)
            {
                Rectangle screenControlBounds = control.Parent.RectangleToScreen(control.Bounds);
                editorBounds.Offset(0, -3);
                Rectangle screenEditorBounds = control.RectangleToScreen(editorBounds);

                Size preferredSize = editor.GetPreferredSize(editorBounds.Size);
                int height = Math.Max(preferredSize.Height, editorBounds.Height);
                int width = preferredSize.Width;

                Rectangle rect = screenEditorBounds;
                rect.Offset(editorBounds.Width + 6, 0);

                int maxBottom = Math.Min(screenControlBounds.Bottom, rect.Top + height);
                int top = maxBottom - height;

                Rectangle result = new Rectangle(rect.Left, top, width, height);
                if (screenControlBounds.Right < rect.Right)
                {
                    int horzOffset = control.ActiveView is DayView ? 12 : 8;
                    result = new Rectangle(screenEditorBounds.Left - width - horzOffset, top, width, height);
                }
                return result;
            }
            public void Dispose()
            {
                //if (editor.ValidateChildren())
                {
                    Dispose(true);
                    GC.SuppressFinalize(this);
                }
            }
            ~ProjectSelector()
            {
                Dispose(false);
            }
            protected virtual void Dispose(bool disposing)
            {
                if (disposing)
                {
                    if (Editor != null)
                    {
                        Editor.Dispose();
                        this.editor = null;
                    }
                    this.appointment = null;
                }
            }
            public virtual void Activate()
            {
                Editor.FillForm(control, appointment);
                SubscribeEditorEvents();
                //Editor.Show();
                Editor.Show(Control.FindForm());
            }
            public virtual void Deactivate()
            {
                //if (Editor.ValidateChildren())
                {
                    UnsibscribeEditorEvents();


                    Editor.Hide();
                }
                //Editor.Hide();
            }
            public virtual void ApplyChanges()
            {
                Editor.ApplyChanges();
            }

            protected internal virtual void SubscribeEditorEvents()
            {
                Editor.FormClosed += new FormClosedEventHandler(Editor_FormClosed);
                Editor.Deactivate += new EventHandler(Editor_Deactivate);
                Editor.CommitChanges += new EventHandler(Editor_CommitChanges);
                Editor.RollbackChanges += new EventHandler(Editor_RollbackChanges);
            }

            protected internal virtual void UnsibscribeEditorEvents()
            {
                Editor.FormClosed -= new FormClosedEventHandler(Editor_FormClosed);
                Editor.Deactivate -= new EventHandler(Editor_Deactivate);
                Editor.CommitChanges -= new EventHandler(Editor_CommitChanges);
                Editor.RollbackChanges -= new EventHandler(Editor_RollbackChanges);
            }
            void Editor_FormClosed(object sender, FormClosedEventArgs e)
            {
                OnCommitChanges();
            }

            void Editor_Deactivate(object sender, EventArgs e)
            {
                OnCommitChanges();
            }


            void Editor_RollbackChanges(object sender, EventArgs e)
            {
                OnRollbackChanges();
            }

            void Editor_CommitChanges(object sender, EventArgs e)
            {
                OnCommitChanges();
            }
            protected internal virtual void TextBox_LostFocus(object sender, EventArgs e)
            {
                //Editor.Close();
                OnCommitChanges();
            }


            protected internal virtual void OnRollbackChanges()
            {
                if (RollbackChanges != null)
                    RollbackChanges(this, EventArgs.Empty);
            }
            protected internal virtual void OnCommitChanges()
            {
                RaiseCommitChanges();
            }
            protected internal virtual void RaiseCommitChanges()
            {
                if (CommitChanges != null)
                    CommitChanges(this, EventArgs.Empty);
            }

        }

        private void entryCal_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e)
        {
            
            e.Text = e.Appointment.Subject + " (" + e.Appointment.CustomFields["Customer"] + ")";
            e.Description = e.Appointment.CustomFields["ProjectTitle"] + "\r\n" + e.Appointment.Description;
        }

       

        private void calStorage_FilterAppointment(object sender, PersistentObjectCancelEventArgs e)
        {
            Appointment apt = (Appointment)e.Object;
            if (true)
            {
                if (apt.ResourceId is int)
                    e.Cancel = ((int)apt.ResourceId != CurrentConfig.UserId);
            }
            //if (bFilterCustomer.Checked)
            //{
            //    if (apt.CustomFields["Customer"] != null && !(apt.CustomFields["Customer"] is DBNull) && (string)apt.CustomFields["Customer"] != ddFilterCompanys.Text)
            //        e.Cancel = true;
            //}
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            entryCal.Services.ResourceNavigation.ResourcePerPage = 1;//bOnlyone.Checked ? 1 : 8;
        }
/*
        private void SetGroupType()
        {
            /*if (bOnlyone.Checked)
            {
                entryCal.GroupType = SchedulerGroupType.None;
            }
            else
                entryCal.GroupType = SchedulerGroupType.Resource;
        }
        */
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SetCheckedStatus(sender);
            
            entryCal.ActiveViewType = SchedulerViewType.Day;
        }

        private void SetCheckedStatus(object sender)
        {
            //foreach (ToolStripItem item in toolStrip2.Items)
            //{
            //    ToolStripButton button = (ToolStripButton)item;
            //    button.Checked = (sender == item);
            //}
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SetCheckedStatus(sender);
            entryCal.ActiveViewType = SchedulerViewType.WorkWeek;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SetCheckedStatus(sender);
            entryCal.ActiveViewType = SchedulerViewType.Week;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SetCheckedStatus(sender);
            entryCal.ActiveViewType = SchedulerViewType.Month;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            SetCheckedStatus(sender);
            entryCal.ActiveViewType = SchedulerViewType.Timeline;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

            entryCal.Services.DateTimeNavigation.GoToToday();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            entryCal.Services.DateTimeNavigation.NavigateBackward();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbCurrentUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*CurrentConfig.UserId = ((User)cbCurrentUser.SelectedItem).UserId;
            entryCal.Services.ResourceNavigation.GoToResourceById(CurrentConfig.UserId);
            entryCal.Services.ResourceNavigation.ResourcePerPage = 1;*/
            //UpdateProgress();
            //SetGroupType();
            //entryCal.Update();
            //cbCurrentUser.SelectedText
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //Core.DAL.ConnectionFactory.AfterRequest();
            base.OnClosing(e);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //entryCal.OptionsView.ShowOnlyResourceAppointments = !bResourceSpecific.Checked;
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            entryCal.Services.DateTimeNavigation.NavigateForward();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            if (s.ShowDialog() == DialogResult.OK)
            {
                CurrentConfig.Load();
                enumUsers();
            }
        }

        private const string appId = "TimeCommander2";

        private void TimeApp_Shown(object sender, EventArgs e)
        {
            //if (CurrentConfig.UseWindows7)
            //{
            //    if (windowsTaskbar == null)
            //        FixProgress();
            //    UpdateProgress();
            //}
            //splitContainer1.SplitterDistance = (toolStripButton1.Checked ? TimeApp.ActiveForm.Size.Height - 380 : TimeApp.ActiveForm.Size.Height - 2);
            //enumFilterCustomers();
            enumUsers();
            //LoadTodo();
            //if (CurrentConfig.UseKeyboardHooks)
            //{
            //    HookManager.KeyDown += HookManager_KeyDown;
            //    HookManager.KeyUp += HookManager_KeyUp;
            //}
        }

        void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LWin)
                HasWinkey = false;
            if (e.KeyCode == Keys.LControlKey)
                HasCtrlkey = false;
        }

        public bool HasWinkey;
        public bool HasCtrlkey;
        public bool TimerActive;
        public DateTime StartTime;

        void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LWin)
                HasWinkey = true;
            if (e.KeyCode == Keys.LControlKey)
                HasCtrlkey = true;
            if (HasWinkey && HasCtrlkey)
            {
                TimerActive = !TimerActive;
                TimerStatusChanged();
            }
        }

        private void TimerStatusChanged()
        {
            notifyIcon.BalloonTipTitle = TimerActive ? "Starting timer" : "Stopping timer";
            notifyIcon.BalloonTipText = "To start and stop timer press ctrl+win";
            togglToolStripMenuItem.Text = TimerActive ? "Stopp timer" : "Start timer";
            notifyIcon.ShowBalloonTip(2500);
            if (TimerActive)
            {
                StartTime = DateTime.Now;
                //if (CurrentConfig.UseWindows7)
                //{
                //    if (windowsTaskbar == null)
                //        FixProgress();
                //    windowsTaskbar.SetProgressState(TaskbarProgressBarState.Indeterminate);
                //}
            }
            else
            {
                HasWinkey = false;
                HasCtrlkey = false;
                //HookManager.KeyDown -= HookManager_KeyDown;
                //HookManager.KeyUp -= HookManager_KeyUp;
                Appointment apt = calStorage.CreateAppointment(AppointmentType.Normal);
                apt.Start = StartTime;
                apt.End = DateTime.Now;
                apt.ResourceId = CurrentConfig.UserId;
                apt.Subject = "Timed event";
                entryCal.ShowEditAppointmentForm(apt);
                //HookManager.KeyDown += HookManager_KeyDown;
                //HookManager.KeyUp += HookManager_KeyUp;
                //if (CurrentConfig.UseWindows7)
                //{
                //    if (windowsTaskbar == null)
                //        FixProgress();
                //    windowsTaskbar.SetProgressState(TaskbarProgressBarState.Paused);
                //}
            }
        }

        //public void LoadTodo()
        //{
        //    treeView1.Nodes.Clear();
        //    List<int> customers = new List<int>();
        //    List<WebdocOrder.Todo> todos = WebdocOrder.Todo.GetByUser(CurrentConfig.UserId);
        //    //treeView1.DataSource = todos;
            

        //    foreach (var todo in todos)
        //    {
        //        //treeView1.AppendNode(todo, 0);
                
        //        if (!customers.Contains(todo.CustomerId))
        //        {
        //            customers.Add(todo.CustomerId);
        //        }
                 
        //    }
        
            
        //    foreach(int i in customers)
        //    {
        //        WebdocOrder.Customer co = new WebdocOrder.Customer(i);
                
        //        var custnode = treeView1.AppendNode(co, null);
        //        custnode.SetValue(0, co.CustomerName);
        //        custnode.CheckState = CheckState.Indeterminate;
        //        foreach (var todo in todos)
        //        {
        //            int custId = todo.CustomerId;
        //            if (custId == 0)
        //            {
        //                WebdocOrder.ProjectOrder po = new WebdocOrder.ProjectOrder(todo.ProjectId);
        //                custId = po.CustomerId;
        //            }
        //            if (custId == i)
        //            {
        //                if (!string.IsNullOrEmpty(todo.Title))
        //                {
        //                    /*
        //                    string pre = "";
        //                    if (todo.ProjectId > 0)
        //                    {
        //                        WebdocOrder.ProjectOrder po = new WebdocOrder.ProjectOrder(todo.ProjectId);
        //                        pre = po.Title;
        //                    }
        //                    //var ntn = new TreeListNode(pre + todo.Title) { ImageIndex = 0, Tag = todo, ToolTipText = todo.TextComment, Checked = todo.Done };
        //                    var ntn = new TreeListNode() { ImageIndex = 0, Tag = todo, Checked = todo.Done };
        //                    ntn.SetValue(0, co.CustomerName);
        //                    ntn.SetValue(1, pre);
        //                    tn.Nodes.Add(ntn);
        //                     * */
        //                    var nnode = treeView1.AppendNode(todo,custnode.Id);
        //                    nnode.Tag = todo;
        //                    nnode.SetValue(0, todo.Title);
        //                    nnode.SetValue(1, todo.Done);
        //                }
        //            }
        //        }
        //        //treeView1.Nodes.Add(tn);
        //    }
            
        //}

        //private void FixProgress()
        //{
        //    windowsTaskbar = TaskbarManager.Instance;
        //    windowsTaskbar.ApplicationId = appId;
        //    windowsTaskbar.SetProgressState(TaskbarProgressBarState.Paused);

        //    if (tb == null)
        //    {
        //        tb = new ThumbnailToolbarButton(Properties.Resources.alarmclock, "Start/Stop");
        //        tb.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(tb_Click);

        //        windowsTaskbar.ThumbnailToolbars.AddButtons(this.Handle, tb);
        //    }
        //}

        //public JumpList jumpList;

        //private void UpdateProgress()
        //{
        //    object ts = (object)DataAdapter.sqlGetSingle("SELECT SUM(DATEDIFF(hh,EventTime,EndTime)) as Time FROM Entry WHERE ResourceId=" + CurrentConfig.UserId + " AND EventTime BETWEEN '" + DateTime.Now.ToShortDateString() + " 00:00:01' AND '" + DateTime.Now.ToShortDateString() + " 23:59:59'");
        //    if (ts is int)
        //    {
        //        int h = (int)ts;
        //        h = Math.Min(h, 8);
        //        if (CurrentConfig.UseWindows7)
        //        {
        //            if (windowsTaskbar==null)
        //                FixProgress();
        //            if (h == 8)
        //                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal);
        //            else
        //                windowsTaskbar.SetProgressState(TaskbarProgressBarState.Paused);
        //            windowsTaskbar.SetProgressValue((int)ts, 8);
        //        }
        //    }
        //}

        private void entryCal_ActiveViewChanged(object sender, EventArgs e)
        {
            //CurrentConfig.UserId = ((User)cbCurrentUser.SelectedItem).UserId;
            entryCal.Services.ResourceNavigation.ResourcePerPage = 1;//bOnlyone.Checked ? 1 : 8;
            entryCal.Services.ResourceNavigation.GoToResourceById(CurrentConfig.UserId);
        }

        private void entryCal_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            e.Handled = true;
          
            UserDefinedFilterAppointmentForm form = new UserDefinedFilterAppointmentForm(entryCal, e.Appointment, e.OpenRecurrenceForm);
            form.ShowDialog(this);
        }

        private void useWindows7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CurrentConfig.UseWindows7 = toolStripButton10.Checked;
            /*toolStripButton10.Checked = useWindows7ToolStripMenuItem.Checked;
            toolStripButton11.Checked = useKeyboardhooksToolStripMenuItem.Checked;*/
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            
            
        }
        
        
      

        private void entryCal_AppointmentDrop(object sender, AppointmentDragEventArgs e)
        {
            if (e.SourceAppointment.CustomFields["YourReference"] == null)
            {
                //e.cHandled = true;
                e.Allow = false;
                entryCal.ShowEditAppointmentForm(e.EditedAppointment);// != System.Windows.Forms.DialogResult.Cancel;

            }

        }

        //private void useKeyboardhooksToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    CurrentConfig.UseKeyboardHooks = toolStripButton11.Checked;
        //    /*toolStripButton10.Checked = useWindows7ToolStripMenuItem.Checked;
        //    toolStripButton11.Checked = useKeyboardhooksToolStripMenuItem.Checked;*/
        //}

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void togglToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerActive = !TimerActive;
            TimerStatusChanged();
        }

        //private void bFilterCustomer_Click(object sender, EventArgs e)
        //{
        //    entryCal.GroupType = bFilterCustomer.Checked ? SchedulerGroupType.None : SchedulerGroupType.Resource;
        //    entryCal.Refresh();
        //}

        private void ddFilterCompanys_SelectedIndexChanged(object sender, EventArgs e)
        {
            entryCal.Refresh();
        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.supportEntryTableAdapter.FillBy(this.supportDs.SupportEntry);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            TaskForm sf = new TaskForm();
            sf.Parent = this;
            sf.Show();
        }        
        

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            SupportForm sf = new SupportForm();
            sf.Parent = this;
            sf.Show();
        }

        private void toolStripButton1_Click_3(object sender, EventArgs e)
        {
            ExportForm ef = new ExportForm();
            ef.Show();
        }

        private void toolStripButton8_Click_2(object sender, EventArgs e)
        {
            NewSupportForm fs = new NewSupportForm();
            fs.ShowDialog();
        }

        public DateTime lastCheck = DateTime.Now.AddDays(-1);
        public int CurrentSupportEntryId = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour>22)
                Application.Exit();
            //List<SupportEntry> newSupportEntrys = Support.SupportEntry.GetCustomList<SupportEntry>("SELECT * FROM SupportEntry WHERE Added>'" + lastCheck.ToString() + "'");
            //if (newSupportEntrys.Count>0)
            //{
            //    string customers = "";
            //    foreach (SupportEntry se in newSupportEntrys)
            //    {
            //        customers += se.Site + "\n";
            //    }
            //    CurrentSupportEntryId = newSupportEntrys[0].Id;
            //    notifyIcon.ShowBalloonTip(5000, newSupportEntrys.Count+" support entry", "There is a new support entry from "+customers, ToolTipIcon.Info);
                
            //}

            //List<SupportComment> newSupportConv = Support.SupportComment.GetCustomList<SupportComment>("SELECT * FROM SupportComment WHERE Date>'" + lastCheck.ToString() + "'");
            //if (newSupportConv.Count > 0)
            //{
            //    //string customers = "";
            //    foreach (SupportComment se in newSupportConv)
            //    {
            //        notifyIcon.ShowBalloonTip(5000, se.UserName+ " commented on a support entry", se.Entry, ToolTipIcon.Info);
            //        CurrentSupportEntryId = se.SupportId;
            //    }
                
            //}
            lastCheck = DateTime.Now;

        }

        void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            SupportConversation sf = new SupportConversation();
            //sf.Parent = this;
            sf.ParentForm = this;
            sf.EntryId = CurrentSupportEntryId;
            sf.Show();
            sf.Focus();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.entryTableAdapter.Fill(this.entrys.Entry);
            calStorage.RefreshData();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            WebdocOrder.GUI.Order o = new WebdocOrder.GUI.Order();
            o.ShowDialog();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            WebdocOrder.GUI.ContactSearch o = new WebdocOrder.GUI.ContactSearch();
            o.ShowDialog();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            WebdocOrder.GUI.Contact o = new WebdocOrder.GUI.Contact();
            o.ShowDialog();
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            WebdocOrder.GUI.Todo t = new WebdocOrder.GUI.Todo(new WebdocOrder.Customer(302));
            t.Show();
        }

        private void entryCal_CustomDrawAppointment(object sender, CustomDrawObjectEventArgs e)
        {
            object o = e.ObjectInfo;
            if (o is DevExpress.XtraScheduler.Drawing.VerticalAppointmentViewInfo)
            {
                DevExpress.XtraScheduler.Drawing.VerticalAppointmentViewInfo vi = (DevExpress.XtraScheduler.Drawing.VerticalAppointmentViewInfo)o;
                object inv = vi.Appointment.CustomFields["InvoiceId"];
                if (inv is DBNull)
                    return;
                if (inv!=null && ((int)inv)>0)
                    e.Cache.Paint.DrawImage(e.Graphics, TimeCommander2.Properties.Resources.gear, new Rectangle(e.Bounds.X + e.Bounds.Width - 20, e.Bounds.Y + e.Bounds.Height - 20, 16, 16));
            }
                //e.Graphics.DrawImageUnscaled(TimeCommander2.Properties.Resources.gear, 0, 0, 16, 16);
            //e.Graphics.DrawIcon(TimeCommander2.Properties.Resources.gear_add, new Rectangle(0, 0, 16, 16));
            //e.Handled = true;
            
        }

        private void entryCal_CustomDrawAppointmentBackground(object sender, CustomDrawObjectEventArgs e)
        {
            
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            WebdocOrder.GUI.CustomerOverview co = new WebdocOrder.GUI.CustomerOverview();
            co.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void lvTodo_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            if (treeView1.SelectedNode!=null && e.Button == MouseButtons.Left && treeView1.SelectedNode.Tag is WebdocOrder.Todo)
                treeView1.DoDragDrop(GetDragData(treeView1), DragDropEffects.All);*/
        }


        SchedulerDragData GetDragData(WebdocOrder.Todo todo)
        {

            //AppointmentBaseCollection appointments = new AppointmentBaseCollection();

            //foreach (ListViewItem row in view.SelectedItems)
            //{

                //WebdocOrder.Todo todo = view.SelectedNode.Tag as WebdocOrder.Todo;
                Appointment apt = calStorage.CreateAppointment(AppointmentType.Normal);
                apt.Subject = todo.Title;
                apt.LabelId = 0;
                apt.StatusId = 2;
                apt.ResourceId = CurrentConfig.UserId;
                apt.CustomFields["Customer"] = new WebdocOrder.Customer(todo.CustomerId);
                apt.CustomFields["CustomerId"] = todo.CustomerId;
                if (todo.ProjectId > 0)
                {
                    apt.CustomFields["Project"] = new WebdocOrder.ProjectOrder(todo.ProjectId);
                    apt.CustomFields["ProjectId"] = todo.ProjectId;
                    apt.CustomFields["ProjectTitle"] = todo.Title;
                }
                //apt.CustomFields["YourReference"] = 188;
                apt.Duration = TimeSpan.FromHours(1);
                apt.Description = todo.TextComment;
                //appointments.Add(apt);
            //}

            return new SchedulerDragData(apt);
        }

        private void lvTodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            //WebdocOrder.GUI.RibbonForm1 rf = new WebdocOrder.GUI.RibbonForm1();
            //rf.Show();
            //LoadTodo();
        }

        private void lvTodo_DoubleClick(object sender, EventArgs e)
        {
            //
        }

        /*
        private void lvTodo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var todo = (WebdocOrder.Todo)lvTodo.HitTest(e.Location).Item.Tag;
            WebdocOrder.GUI.Todo t = new WebdocOrder.GUI.Todo();
            t.LoadTodo(todo.Id);
            t.Show();
        }
         * */

        private void entryCal_CustomDrawNavigationButton(object sender, CustomDrawObjectEventArgs e)
        {

        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is WebdocOrder.Todo)
            {
                WebdocOrder.Todo todo = (WebdocOrder.Todo)e.Node.Tag;
                todo.Done = e.Node.Checked;
                todo.Save();
                if (todo.Done)
                    e.Node.Remove();
            }
        }




        public bool IsOnGlass(Rectangle rect)
        {
            return true;
        }

        private void treeView1_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Node.Tag is WebdocOrder.Todo)
            {
                WebdocOrder.Todo todo = (WebdocOrder.Todo)e.Node.Tag;
                todo.Done = (bool)e.Node.GetValue(1);
                todo.Save();
                e.Node.Visible = !todo.Done;
            }
        }

        private void treeView1_BeforeDragNode(object sender, DevExpress.XtraTreeList.BeforeDragNodeEventArgs e)
        {
            e.CanDrag = false;
            if (e.Node.Tag is WebdocOrder.Todo)
            {
                e.CanDrag = false;
                //treeView1.DoDragDrop(GetDragData((WebdocOrder.Todo)e.Node.Tag),DragDropEffects.Copy);
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.entryTableAdapter.Fill(this.entrys.Entry);
            calStorage.RefreshData();
        }

        private void barListItem1_ListItemClick(object sender, ListItemClickEventArgs e)
        {
            var str = barListItem1.Strings[e.Index];
            var realUser = users.EntryUsers.FirstOrDefault(d => d.Username.Equals(str));
            if (realUser != null)
            {
                CurrentConfig.UserId = realUser.Id;
                entryCal.Services.ResourceNavigation.GoToResourceById(CurrentConfig.UserId);
            }
        }
    }
}
