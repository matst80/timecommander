using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DAL;

namespace TimeCommander2.Helpers
{
    [dbTable("Entry")]
    [dbIdField("Id")]
    public class ReportEntry : dbBase
    {
        public ReportEntry(System.Data.IDataRecord dr)
            : base(dr)
        {

        }

        [dbField("Id", true)]
        public int Id { get; set; }


        [dbField("Type", false)]
        public string Project { get; set; }

        [dbField("Customer", false)]
        public string Customer { get; set; }

        [dbField("OurReference", false)]
        public string OurReference { get; set; }

        [dbField("YourReference", false)]
        public string YourReference { get; set; }

        [dbField("EventTime", false)]
        public DateTime Started { get; set; }

        [dbField("EndTime", false)]
        public DateTime Finished { get; set; }

        [dbField("Duration", false)]
        public int Duration { get; set; }

        [dbField("Title", false)]
        public string Title { get; set; }

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

        public static IEnumerable<ReportEntry> GetList(DateTime start, DateTime end)
        {
            return ReportEntry.GetCustom<ReportEntry>("SELECT Id,Type,Title,Customer,OurReference,YourReference,EventTime,EndTime,Description, DateDiff(mi,EventTime,EndTime) as Duration FROM Entry WHERE EventTime BETWEEN '" + start.ToShortDateString() + "' AND '" + end.ToShortDateString() + "'");
        }
    }
}
