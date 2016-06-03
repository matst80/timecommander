using Core.DAL;
using System.Collections.Generic;
using System.Data;
using System;

namespace TimeCommander2.Support
{

    [Serializable]
    [dbTable("SupportComment")]
    [dbIdField("Id")]
    public class SupportComment : dbBase
    {
        public SupportComment()
        {
        }
        public SupportComment(int id)
            : base(id)
        {
        }
        public SupportComment(string id)
            : base(id)
        {
        }
        public SupportComment(IDataRecord dr)
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

        private System.String _Entry;
        [dbField("Entry", false)]
        public virtual System.String Entry
        {
            get { return _Entry; }
            set { _Entry = value; }
        }

        private System.Int32 _SupportId;
        [dbField("SupportId", false)]
        public virtual System.Int32 SupportId
        {
            get { return _SupportId; }
            set { _SupportId = value; }
        }

        private System.DateTime _Date;
        [dbField("Date", false)]
        public virtual System.DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private System.String _UserName;
        [dbField("UserName", false)]
        public virtual System.String UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
    }
}
