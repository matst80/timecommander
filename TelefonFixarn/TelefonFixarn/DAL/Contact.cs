using Core.DAL;
using System.Collections.Generic;
using System.Data;
using System;

namespace WebdocOrder
{

    [Serializable]
    [dbTable("Contact")]
    [dbIdField("Id")]
    public class Contact : dbBase
    {
        public Contact()
        {
        }
        public Contact(int id)
            : base(id)
        {
        }
        public Contact(string id)
            : base(id)
        {
        }
        public Contact(IDataRecord dr)
            : base(dr)
        {
        }
      

        private Customer _ParentCustomer;
        public virtual Customer ParentCustomer
        {
            get
            {
                if (_ParentCustomer == null)
                {
                    _ParentCustomer = new Customer(this.CustomerId);
                }
                return _ParentCustomer;
            }
            set { _ParentCustomer = value; }
        }



        private System.Int32 _Id;
        [dbField("Id", true)]
        public virtual System.Int32 Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private System.Int32 _CustomerId;
        [dbField("CustomerId", false)]
        public virtual System.Int32 CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }

        private System.Int32 _ContactId;
        [dbField("ContactId", false)]
        public virtual System.Int32 ContactId
        {
            get { return _ContactId; }
            set { _ContactId = value; }
        }

        private System.String _Note;
        [dbField("Note", false)]
        public virtual System.String Note
        {
            get { return _Note; }
            set { _Note = value; }
        }

        private System.DateTime _EventTime;
        [dbField("EventTime", false)]
        public virtual System.DateTime EventTime
        {
            get { return _EventTime; }
            set { _EventTime = value; }
        }

        private System.Boolean _IsDone;
        [dbField("IsDone", false)]
        public virtual System.Boolean IsDone
        {
            get { return _IsDone; }
            set { _IsDone = value; }
        }

        private System.Int32 _FollowUp;
        [dbField("FollowUp", false)]
        public virtual System.Int32 FollowUp
        {
            get { return _FollowUp; }
            set { _FollowUp = value; }
        }

        private System.DateTime _EndTime;
        [dbField("EndTime", false)]
        public virtual System.DateTime EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }

        private System.Int32 _ProjectId;
        [dbField("ProjectId", false)]
        public virtual System.Int32 ProjectId
        {
            get { return _ProjectId; }
            set { _ProjectId = value; }
        }
    }
}
