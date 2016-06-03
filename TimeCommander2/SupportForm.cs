using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace TimeCommander2
{
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
            /*try
            {
                this.supportEntryTableAdapter1.FillByUnique(this.sites.SupportEntry);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = supportGrid.HitTest(e.X, e.Y);
            if (supportGrid.SelectedRows.Count > 0 && e.Button == MouseButtons.Left && hit.RowIndex>0 && hit.ColumnIndex>0)
                supportGrid.DoDragDrop(GetDragData2(supportGrid), DragDropEffects.All);

        }

        public TimeApp Parent;

        SchedulerDragData GetDragData2(DataGridView view)
        {
            //TimeApp parent = (TimeApp)ParentForm;
            AppointmentBaseCollection appointments = new AppointmentBaseCollection();

            foreach (DataGridViewRow row in view.SelectedRows)
            {

                Appointment apt = Parent.calStorage.CreateAppointment(AppointmentType.Normal);
                apt.CustomFields["Type"] = (string)row.Cells[4].Value;
                apt.Subject = (string)row.Cells[1].Value;

                apt.LabelId = 0;
                apt.StatusId = 0;

                apt.Duration = TimeSpan.FromHours(1);
                apt.Description = (string)row.Cells[2].Value;
                appointments.Add(apt);
            }

            return new SchedulerDragData(appointments, 0);
        }

        private void openConversationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in supportGrid.SelectedRows)
            {
                SupportConversation sc = new SupportConversation();
                sc.ParentForm = Parent;
                sc.EntryId = (int)dr.Cells[0].Value;
                sc.Show();
            }
        }

        private void markAsDoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in supportGrid.SelectedRows)
            {
                Support.SupportEntry se = new TimeCommander2.Support.SupportEntry((int)dr.Cells[0].Value);
                se.Finished = DateTime.Now;
                if (string.IsNullOrEmpty(se.AssignTo))
                    se.AssignTo = Parent.cbCurrentUser.Text;
                se.Status = 2;
                se.Save();
            }
        }

        private void SupportForm_Shown(object sender, EventArgs e)
        {
            foreach (TimeCommander2.TimeApp.User s in Parent.cbCurrentUser.Items)
            {
                ddUser.Items.Add(s.Username);
            }

            try
            {
                this.supportEntryTableAdapter.FillByNotComplete(this.supportDs.SupportEntry);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void SupportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sites.SupportEntry' table. You can move, or remove it, as needed.
            //this.supportEntryTableAdapter1.Fill(this.sites.SupportEntry);
            // TODO: This line of code loads data into the 'supportDs.SupportEntry' table. You can move, or remove it, as needed.
            //this.supportEntryTableAdapter.Fill(this.supportDs.SupportEntry);

        }

        private void supportGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = supportGrid.HitTest(e.X, e.Y);
            if (supportGrid.Rows.Count > hit.RowIndex)
            {
                SupportConversation sc = new SupportConversation();
                sc.ParentForm = Parent;
                sc.EntryId = (int)supportGrid.Rows[hit.RowIndex].Cells[0].Value;
                sc.Show();
            }
        }

        private void fillByUserToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.supportEntryTableAdapter.FillByUser(this.supportDs.SupportEntry, ddUser.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByNotCompleteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.supportEntryTableAdapter.FillByNotComplete(this.supportDs.SupportEntry);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNotCompleteToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (fillByNotCompleteToolStripButton.Checked)
            {
                try
                {
                    this.supportEntryTableAdapter.FillByNotComplete(this.supportDs.SupportEntry);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    this.supportEntryTableAdapter.Fill(this.supportDs.SupportEntry);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.supportEntryTableAdapter.Fill(this.supportDs.SupportEntry);
        }

        private void supportGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex==3 && e.RowIndex>0)
            {
            //e.PaintParts &= ~DataGridViewPaintParts.ContentBackground;
            Brush b = Brushes.Green;
                if (e.Value is int)
                {
                    int v = (int)e.Value;
                    if (v == 1)
                        b = Brushes.Yellow;
                    if (v == 0)
                        b = Brushes.Red;
                }
            e.Graphics.FillRectangle(b, e.CellBounds);
            e.Handled = true;
            }
        }

       
    }
}
