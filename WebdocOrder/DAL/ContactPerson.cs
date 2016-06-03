using Core.DAL;
using System.Collections.Generic;
using System.Data;
using System;

namespace WebdocOrder
{

    [Serializable]
    [dbTable("ContactPerson")]
    [dbIdField("Id")]
    public class ContactPerson : dbBase
    {
        public ContactPerson()
        {
        }
        public ContactPerson(int id)
            : base(id)
        {
        }
        public ContactPerson(string id)
            : base(id)
        {
        }
        public ContactPerson(IDataRecord dr)
            : base(dr)
        {
        }
        public static void Store(ContactPerson obj)
        {
            if (obj.Id != 0)
                obj.ObjectState = eObjectState.Existing;
            obj.Save();
        }
        public static void Delete(ContactPerson obj)
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

        private System.String _Name;
        [dbField("Name", false)]
        public virtual System.String Name
        {
            get { return _Name; }
            set { _Name = value; }
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

        private System.Int32 _CompanyId;
        [dbField("CompanyId", false)]
        public virtual System.Int32 CompanyId
        {
            get { return _CompanyId; }
            set { _CompanyId = value; }
        }

        private System.String _Description;
        [dbField("Description", false)]
        public virtual System.String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private System.String _Notes;
        [dbField("Notes", false)]
        public virtual System.String Notes
        {
            get { return _Notes; }
            set { _Notes = value; }
        }

        private System.String _Title;
        [dbField("Title", false)]
        public virtual System.String Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private System.String _MobilePhone;
        [dbField("MobilePhone", false)]
        public virtual System.String MobilePhone
        {
            get { return _MobilePhone; }
            set { _MobilePhone = value; }
        }

        public static List<ContactPerson> GetContactsByCustomer(int Id)
        {
            return ContactPerson.GetCustomList<ContactPerson>("SELECT * FROM ContactPerson WHERE CompanyId=" + Id);
        }

        public static List<ContactPerson> FindByText(string p)
        {
            return ContactPerson.GetCustomList<ContactPerson>("SELECT * FROM ContactPerson WHERE Name like '%" + p + "%' or Email like '%" + p + "%' or MobilePhone like '%" + p + "%' or Phone like '%" + p + "%'");
        }
    }
}
