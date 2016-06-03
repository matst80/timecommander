using Core.DAL;
using System.Collections.Generic;
using System.Data;
using System;

namespace TimeCommander2.Support
{

    [Serializable]
    [dbTable("SupportEntry")]
    [dbIdField("Id")]
    public class SupportEntry : dbBase
    {
        public SupportEntry()
        {
        }
        public SupportEntry(int id)
            : base(id)
        {
        }
        public SupportEntry(string id)
            : base(id)
        {
        }
        public SupportEntry(IDataRecord dr)
            : base(dr)
        {
        }


        private System.Int32 _Id;
        [dbField("Id", true)]
        public virtual System.Int32 Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private System.String _Title;
        [dbField("Title", false)]
        public virtual System.String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private System.String _Entry;
        [dbField("Entry", false)]
        public virtual System.String Entry
        {
            get { return _Entry; }
            set { _Entry = value; }
        }

        private System.Int32 _Status;
        [dbField("Status", false)]
        public virtual System.Int32 Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private System.String _Site;
        [dbField("Site", false)]
        public virtual System.String Site
        {
            get { return _Site; }
            set { _Site = value; }
        }

        private System.String _UserName;
        [dbField("UserName", false)]
        public virtual System.String UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        private System.DateTime _Added;
        [dbField("Added", false)]
        public virtual System.DateTime Added
        {
            get { return _Added; }
            set { _Added = value; }
        }

        private System.DateTime _Finished;
        [dbField("Finished", false)]
        public virtual System.DateTime Finished
        {
            get { return _Finished; }
            set { _Finished = value; }
        }

        private System.DateTime _Started;
        [dbField("Started", false)]
        public virtual System.DateTime Started
        {
            get { return _Started; }
            set { _Started = value; }
        }

        private System.String _AssignTo;
        [dbField("AssignTo", false)]
        public virtual System.String AssignTo
        {
            get { return _AssignTo; }
            set { _AssignTo = value; }
        }

        private System.String _UserEmail;
        [dbField("UserEmail", false)]
        public virtual System.String UserEmail
        {
            get { return _UserEmail; }
            set { _UserEmail = value; }
        }

        private System.String _AssignedToEmail;
        [dbField("AssignedToEmail", false)]
        public virtual System.String AssignedToEmail
        {
            get { return _AssignedToEmail; }
            set { _AssignedToEmail = value; }
        }

        private System.String _Version;
        [dbField("Version", false)]
        public virtual System.String Version
        {
            get { return _Version; }
            set { _Version = value; }
        }

        private System.Int32 _EntryType;
        [dbField("EntryType", false)]
        public virtual System.Int32 EntryType
        {
            get { return _EntryType; }
            set { _EntryType = value; }
        }

        public static IEnumerable<string> ListAllSites()
        {
            DataSet ds = DataAdapter.sqlGetDS("SELECT Distinct Site from SupportEntry");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (!(dr[0] is DBNull) && dr[0] != null)
                    yield return (string)dr[0];
            }
        }

        public static IEnumerable<string> ListAllEmailsOnSite(string site)
        {
            DataSet ds = DataAdapter.sqlGetDS("SELECT Distinct UserEmail from SupportEntry WHERE Site='"+site+"'");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (!(dr[0] is DBNull) && dr[0]!=null)
                    yield return (string)dr[0];
            }
        }
    }
}
