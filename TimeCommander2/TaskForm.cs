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
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
            taskGrid.DataSource = Helpers.OutlookTasks.GetTasks();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = taskGrid.HitTest(e.X, e.Y);
            if (taskGrid.SelectedRows.Count > 0 && e.Button == MouseButtons.Left && hit.RowIndex>0 && hit.ColumnIndex>0)
                taskGrid.DoDragDrop(GetDragData(taskGrid), DragDropEffects.All);

        }

        public TimeApp Parent;


        SchedulerDragData GetDragData(DataGridView view)
        {

            AppointmentBaseCollection appointments = new AppointmentBaseCollection();

            foreach (DataGridViewRow row in view.SelectedRows)
            {

                Appointment apt = Parent.calStorage.CreateAppointment(AppointmentType.Normal);
                apt.Subject = (string)row.Cells["Subject"].Value;
                apt.LabelId = 0;
                apt.StatusId = 0;

                apt.Duration = TimeSpan.FromHours(1);
                apt.Description = (string)row.Cells["Description"].Value;
                appointments.Add(apt);
            }

            return new SchedulerDragData(appointments, 0);
        }
    }
}
