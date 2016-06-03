using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using OutLook = Microsoft.Office.Interop.Outlook;

namespace TimeCommander2.Helpers
{
    //public class OutlookTask
    //{
    //    public string Subject { get; set; }
    //    public DateTime Created { get; set; }
    //    public DateTime StartDate { get; set; }
    //    public DateTime DueDate { get; set; }
    //    public bool Done { get; set; }
    //    public string Description { get; set; }

    //    public OutlookTask()
    //    {
    //    }

    //    public OutlookTask(object o)
    //    {
    //        if (o is OutLook._TaskItem)
    //        {
    //            OutLook._TaskItem ti = (OutLook._TaskItem)o;
    //            Subject = ti.Subject;
    //            Created = ti.CreationTime;
    //            StartDate = ti.StartDate;
    //            DueDate = ti.DueDate;
    //            Done = (ti.Status == Microsoft.Office.Interop.Outlook.OlTaskStatus.olTaskComplete);
    //            Description = "";
    //        }
    //        if (o is OutLook._MailItem)
    //        {
    //            OutLook._MailItem ti = (OutLook._MailItem)o;
    //            Subject = ti.Subject;
    //            Created = ti.CreationTime;
    //            StartDate = ti.ReceivedTime;
    //            DueDate = ti.ExpiryTime;
    //            Done = (ti.FlagStatus == Microsoft.Office.Interop.Outlook.OlFlagStatus.olFlagComplete);
    //            Description = ti.Body;
    //        }
    //    }
    //}

    //public class OutlookTasks
    //{
        

    //    public static List<OutlookTask> GetTasks()
    //    {
    //        OutLook.Application a = new OutLook.Application();
    //        OutLook.MAPIFolder Tasks = (OutLook.MAPIFolder)a.Session.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderToDo);

    //        //dataGridView1.DataSource = Tasks.Items;
    //        //dataGridView1.databin

    //        //OutLook.

    //        List<OutlookTask> ret = new List<OutlookTask>();
    //        foreach (object ti in Tasks.Items)
    //        {
    //            ret.Add(new OutlookTask(ti));
    //        }
    //        return ret;
    //    }
    //}
}
