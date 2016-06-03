using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DAL;

namespace TelefonFixarn
{
    [dbTable("NewEntry")]
    [dbIdField("Id")]
    public class ReportEntry : dbBase
    {
        public ReportEntry(System.Data.IDataRecord dr)
            : base(dr)
        {

        }

        public ReportEntry(int id)
            : base(id)
        {

        }

        public ReportEntry()
            : base()
        {

        }



        [dbField("Id", true)]
        public int Id { get; set; }


        [dbField("EventType", false)]
        public int EventType { get; set; }

        [dbField("AllDay", false)]
        public bool AllDay { get; set; }

        [dbField("CustomerId", false)]
        public int CustomerId { get; set; }

        [dbField("ProjectId", false)]
        public int ProjectId { get; set; }

        [dbField("ResourceId", false)]
        public int ResourceId { get; set; }

        [dbField("OurReference", false)]
        public string OurReference { get; set; }

        [dbField("YourReference", false)]
        public int YourReference { get; set; }

        [dbField("EventTime", false)]
        public DateTime StartTime { get; set; }

        [dbField("EndTime", false)]
        public DateTime EndTime { get; set; }

        //[dbField("Duration", false)]
        //public int Duration { get; set; }

        [dbField("Title", false)]
        public string Title { get; set; }

        [dbField("EntryTitle", false)]
        public string EntryTitle { get; set; }

        private string desc;
        [dbField("Description", false)]
        public string Description
        {
            get
            {
                if (string.IsNullOrEmpty(desc))
                    return "Tomt";
                if (desc.Length > 250)
                    return desc.Substring(0, Math.Min(250, desc.Length));
                else
                    return desc;
            }
            set
            {
                desc = value;
            }
        }
        [dbField("Parent", false)]
        public int Parent { get; set; }
    }
}
