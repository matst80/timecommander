using Core.DAL;
using System.Collections.Generic;
using System.Data;
using System;

namespace WebdocOrder
{

    [Serializable]
    [dbTable("ProjectOrder")]
    [dbIdField("Id")]
    public class ProjectOrder : dbBase
    {
        public ProjectOrder()
        {
        }
        public ProjectOrder(int id)
            : base(id)
        {
        }
        public ProjectOrder(string id)
            : base(id)
        {
        }
        public ProjectOrder(IDataRecord dr)
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

        private System.String _Title;
        [dbField("Title", false)]
        public virtual System.String Title
        {
            get { return _Title; }
            set { _Title = value; }
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

        private System.Double _Discount;
        [dbField("Discount", false)]
        public virtual System.Double Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }

        private System.Double _BaseCost;
        [dbField("BaseCost", false)]
        public virtual System.Double BaseCost
        {
            get { return _BaseCost; }
            set { _BaseCost = value; }
        }

        private System.String _Description;
        [dbField("Description", false)]
        public virtual System.String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private System.String _LinkGuid;
        [dbField("LinkGuid", false)]
        public virtual System.String LinkGuid
        {
            get { return _LinkGuid; }
            set { _LinkGuid = value; }
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

        private System.Int32 _TechnicalId;
        [dbField("TechnicalId", false)]
        public virtual System.Int32 TechnicalId
        {
            get { return _TechnicalId; }
            set { _TechnicalId = value; }
        }

        private System.Boolean _Approved;
        [dbField("Approved", false)]
        public virtual System.Boolean Approved
        {
            get { return _Approved; }
            set { _Approved = value; }
        }

        private System.Int32 _ParentId;
        [dbField("ParentId", false)]
        public virtual System.Int32 ParentId
        {
            get { return _ParentId; }
            set { _ParentId = value; }
        }

        private System.Int32 _Type;
        [dbField("Type", false)]
        public virtual System.Int32 Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public override string ToString()
        {
            return Title;
        }

        public static List<ProjectOrder> GetOrders()
        {
            return new List<ProjectOrder>(ProjectOrder.GetList<ProjectOrder>());
        }

        public static List<ProjectOrder> GetOrders(int p)
        {
            return new List<ProjectOrder>(ProjectOrder.GetCustomList<ProjectOrder>("SELECT * FROM ProjectOrder where CustomerId="+p));
        }
    }
}
