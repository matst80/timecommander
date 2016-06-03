using Core.DAL;
using System.Collections.Generic;
using System.Data;
using System;

namespace WebdocOrder
{

    [Serializable]
    [dbTable("NewEntryReport")]
    [dbIdField("Id")]
    public class NewEntryReport : dbBase
    {
        public NewEntryReport()
        {
        }
        public NewEntryReport(int id)
            : base(id)
        {
        }
        public NewEntryReport(string id)
            : base(id)
        {
        }
        public NewEntryReport(IDataRecord dr)
            : base(dr)
        {
        }


        private System.String _CustomerName;
        [dbField("CustomerName", false)]
        public virtual System.String CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        private System.String _Title;
        [dbField("Title", false)]
        public virtual System.String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private System.String _Description;
        [dbField("Description", false)]
        public virtual System.String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private System.DateTime _EventTime;
        [dbField("EventTime", false)]
        public virtual System.DateTime EventTime
        {
            get { return _EventTime; }
            set { _EventTime = value; }
        }

        private System.Int32 _DebTime;
        [dbField("DebTime", false)]
        public virtual System.Int32 DebTime
        {
            get { return _DebTime; }
            set { _DebTime = value; }
        }

        private System.DateTime _EndTime;
        [dbField("EndTime", false)]
        public virtual System.DateTime EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }

        private System.String _EntryTitle;
        [dbField("EntryTitle", false)]
        public virtual System.String EntryTitle
        {
            get { return _EntryTitle; }
            set { _EntryTitle = value; }
        }

        private System.Double _Time;
        [dbField("Time", false)]
        public virtual System.Double Time
        {
            get { return _Time; }
            set { _Time = value; }
        }

        private System.Int32 _HourCost;
        [dbField("HourCost", false)]
        public virtual System.Int32 HourCost
        {
            get { return _HourCost; }
            set { _HourCost = value; }
        }

        private System.String _ProjectName;
        [dbField("ProjectName", false)]
        public virtual System.String ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        private System.Int32 _Id;
        [dbField("Id", true)]
        public virtual System.Int32 Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private System.Int32 _InvoiceId;
        [dbField("InvoiceId", true)]
        public virtual System.Int32 InvoiceId
        {
            get { return _InvoiceId; }
            set { _InvoiceId = value; }
        }

        private System.String _Username;
        [dbField("Username", false)]
        public virtual System.String Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        private System.String _CustomerNr;
        [dbField("CustomerNr", false)]
        public virtual System.String CustomerNr
        {
            get { return _CustomerNr; }
            set { _CustomerNr = value; }
        }

        private System.String _Name;
        [dbField("Name", false)]
        public virtual System.String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private System.Boolean _Deliverd;
        [dbField("Deliverd", false)]
        public virtual System.Boolean Deliverd
        {
            get { return _Deliverd; }
            set { _Deliverd = value; }
        }
    }
}
