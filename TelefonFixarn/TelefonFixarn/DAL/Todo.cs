using Core.DAL;
using System.Collections.Generic;
using System.Data;
using System;

namespace WebdocOrder
{

    [Serializable]
    [dbTable("Todo")]
    [dbIdField("Id")]
    public class Todo : dbBase
    {
        public Todo()
        {
        }
        public Todo(int id)
            : base(id)
        {
        }
        public Todo(string id)
            : base(id)
        {
        }
        public Todo(IDataRecord dr)
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

        private System.Int32 _CustomerId;
        [dbField("CustomerId", false)]
        public virtual System.Int32 CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }

        private System.Int32 _ProjectId;
        [dbField("ProjectId", false)]
        public virtual System.Int32 ProjectId
        {
            get { return _ProjectId; }
            set { _ProjectId = value; }
        }

        private System.Int32 _UserId;
        [dbField("UserId", false)]
        public virtual System.Int32 UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        private System.String _Comment;
        [dbField("Comment", false)]
        public virtual System.String Comment
        {
            get { return _Comment; }
            set { _Comment = value; }
        }

        private System.String _TextComment;
        [dbField("TextComment", false)]
        public virtual System.String TextComment
        {
            get { return _TextComment; }
            set { _TextComment = value; }
        }

        private System.String _Title;
        [dbField("Title", false)]
        public virtual System.String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private System.Int32 _Prio;
        [dbField("Prio", false)]
        public virtual System.Int32 Prio
        {
            get { return _Prio; }
            set { _Prio = value; }
        }

        [dbField("Done", false)]
        public bool Done { get; set; }

        private System.DateTime _DueDate;
        [dbField("DueDate", false)]
        public virtual System.DateTime DueDate
        {
            get { return _DueDate; }
            set { _DueDate = value; }
        }

        private System.DateTime _SendDate;
        [dbField("SendDate", false)]
        public virtual System.DateTime SendDate
        {
            get { return _SendDate; }
            set { _SendDate = value; }
        }

        private System.Int32 _CreatorId;
        [dbField("CreatorId", false)]
        public virtual System.Int32 CreatorId
        {
            get { return _CreatorId; }
            set { _CreatorId = value; }
        }
        private string projName;
        public string ProjectName
        {
            get
            {
                if (projName == null)
                {
                    if (ProjectId != 0)
                        projName = new ProjectOrder(ProjectId).Title;
                }
                return projName;
            }
        }

        private string custName;
        public string CustomerName
        {
            get
            {
                if (custName == null)
                {
                    if (CustomerId != 0)
                        custName = new Customer(CustomerId).CustomerName;
                }
                return custName;
            }
        }

        public static List<Todo> GetByCustomerId(int custId)
        {
            return Todo.GetCustomList<Todo>("SELECT * FROM Todo WHERE ProjectId=0 AND CustomerId="+custId);
        }

        public static List<Todo> GetByProjectId(int projId)
        {
            return Todo.GetCustomList<Todo>("SELECT * FROM Todo WHERE ProjectId=" + projId);
        }

        public static List<Todo> GetByUser(int p)
        {
            return Todo.GetCustomList<Todo>("SELECT * FROM Todo WHERE Done=0 AND UserId=0 OR UserId=" + p);
        }
    }
}
