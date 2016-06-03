using Core.DAL;
using System.Collections.Generic;
using System.Data;
using System;

namespace WebdocOrder
{

    [Serializable]
    [dbTable("Customer")]
    [dbIdField("Id")]
    public class Customer : dbBase
    {
        public Customer()
        {
        }
        public Customer(int id)
            : base(id)
        {
        }
        public Customer(string id)
            : base(id)
        {
        }
        public Customer(IDataRecord dr)
            : base(dr)
        {
        }
        //public static void Store(Customer obj)
        //{
        //    if (obj.Id != 0)
        //        obj.ObjectState = eObjectState.Existing;
        //    obj.Save();
        //}
        //public static void Delete(Customer obj)
        //{
        //    obj.IdValue = obj.Id;
        //    obj.Delete();
        //}

        private IEnumerable<CustomerContact> _customercontact;
        public virtual IEnumerable<CustomerContact> customercontact
        {
            get
            {
                if (_customercontact == null)
                    _customercontact = CustomerContact.GetCustom<CustomerContact>("SELECT * FROM CustomerContact where CompanyId=" + this.Id);
                return _customercontact;
            }
            set { _customercontact = value; }
        }

        private IEnumerable<Contact> _FK_Contact_Customer;
        public virtual IEnumerable<Contact> FK_Contact_Customer
        {
            get
            {
                if (_FK_Contact_Customer == null)
                    _FK_Contact_Customer = Contact.GetCustom<Contact>("SELECT * FROM Contact where CustomerId=" + this.Id);
                return _FK_Contact_Customer;
            }
            set { _FK_Contact_Customer = value; }
        }

        private IEnumerable<ProjectOrder> _FK_Order_Customer;
        public virtual IEnumerable<ProjectOrder> FK_Order_Customer
        {
            get
            {
                if (_FK_Order_Customer == null)
                    _FK_Order_Customer = ProjectOrder.GetCustom<ProjectOrder>("SELECT * FROM ProjectOrder where CustomerId=" + this.Id);
                return _FK_Order_Customer;
            }
            set { _FK_Order_Customer = value; }
        }



        private System.Int32 _Id;
        [dbField("Id", true)]
        public virtual System.Int32 Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private System.String _CustomerName;
        [dbField("CustomerName", false)]
        public virtual System.String CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        public override string ToString()
        {
            return CustomerName;
        }

        public static List<Customer> GetCustomers()
        {
            return Customer.GetCustomList<WebdocOrder.Customer>("SELECT * FROM Customer ORDER BY CustomerName");
        }

        private System.String _OrgNr;
        [dbField("OrgNr", false)]
        public virtual System.String OrgNr
        {
            get { return _OrgNr; }
            set { _OrgNr = value; }
        }

        private System.String _Adress;
        [dbField("Adress", false)]
        public virtual System.String Adress
        {
            get { return _Adress; }
            set { _Adress = value; }
        }

        private System.String _Notes;
        [dbField("Notes", false)]
        public virtual System.String Notes
        {
            get { return _Notes; }
            set { _Notes = value; }
        }

        private System.String _ServerPath;
        [dbField("ServerPath", false)]
        public virtual System.String ServerPath
        {
            get { return _ServerPath; }
            set { _ServerPath = value; }
        }

        private System.Int32 _Status;
        [dbField("Status", false)]
        public virtual System.Int32 Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private System.Int32 _DefaultContact;
        [dbField("DefaultContact", false)]
        public virtual System.Int32 DefaultContact
        {
            get { return _DefaultContact; }
            set { _DefaultContact = value; }
        }

        private System.String _CustomerNr;
        [dbField("CustomerNr", false)]
        public virtual System.String CustomerNr
        {
            get { return _CustomerNr; }
            set { _CustomerNr = value; }
        }

        private System.Int32 _CustomerType;
        [dbField("CustomerType", false)]
        public virtual System.Int32 CustomerType
        {
            get { return _CustomerType; }
            set { _CustomerType = value; }
        }

        public List<ContactPerson> GetContacts()
        {
            return ContactPerson.GetCustomList<ContactPerson>("SELECT * FROM ContactPerson WHERE CompanyId=" + Id);
        }
    }
}
