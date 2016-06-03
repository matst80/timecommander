using Core.DAL;
using System.Collections.Generic;
using System.Data;
using System;

namespace WebdocOrder
{

    [Serializable]
    [dbTable("CustomerContact")]
    [dbIdField("Id")]
    public class CustomerContact : dbBase
    {
        public CustomerContact()
        {
        }
        public CustomerContact(int id)
            : base(id)
        {
        }
        public CustomerContact(string id)
            : base(id)
        {
        }
        public CustomerContact(IDataRecord dr)
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
                    _ParentCustomer = new Customer(this.CompanyId);
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

        private System.String _Name;
        [dbField("Name", false)]
        public virtual System.String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private System.String _Title;
        [dbField("Title", false)]
        public virtual System.String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private System.String _Email;
        [dbField("Email", false)]
        public virtual System.String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private System.String _Phone;
        [dbField("Phone", false)]
        public virtual System.String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        private System.DateTime _LastContact;
        [dbField("LastContact", false)]
        public virtual System.DateTime LastContact
        {
            get { return _LastContact; }
            set { _LastContact = value; }
        }

        private System.Int32 _CompanyId;
        [dbField("CompanyId", false)]
        public virtual System.Int32 CompanyId
        {
            get { return _CompanyId; }
            set { _CompanyId = value; }
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
