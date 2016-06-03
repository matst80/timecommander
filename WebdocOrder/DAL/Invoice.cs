using Core.DAL;
using System.Collections.Generic;
using System.Data;
using System;

namespace WebdocOrder
{

    [Serializable]
    [dbTable("Invoice")]
    [dbIdField("Id")]
    public class Invoice : dbBase
    {
        public Invoice()
        {
        }
        public Invoice(int id)
            : base(id)
        {
        }
        public Invoice(string id)
            : base(id)
        {
        }
        public Invoice(IDataRecord dr)
            : base(dr)
        {
        }
        public static void Store(Invoice obj)
        {
            if (obj.Id != 0)
                obj.ObjectState = eObjectState.Existing;
            obj.Save();
        }
        public static void Delete(Invoice obj)
        {
            obj.IdValue = obj.Id;
            obj.Delete();
        }



        private System.Int32 _Id;
        [dbField("Id", true)]
        public virtual System.Int32 Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private System.DateTime _StartTime;
        [dbField("StartTime", false)]
        public virtual System.DateTime StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }

        private System.DateTime _EndTime;
        [dbField("EndTime", false)]
        public virtual System.DateTime EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }

        private System.DateTime _SendDate;
        [dbField("SendDate", false)]
        public virtual System.DateTime SendDate
        {
            get { return _SendDate; }
            set { _SendDate = value; }
        }

        private System.String _Note;
        [dbField("Note", false)]
        public virtual System.String Note
        {
            get { return _Note; }
            set { _Note = value; }
        }
    }
}
