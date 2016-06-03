using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DAL;
using System.Data;

namespace WebdocOrder.DAL
{
    public class InternalUser
    {
        public string Name { get; set; }
        public string Ext { get; set; }
        public string Pin { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public static InternalUser GetUser(int id)
        {
            DataSet ds = DataAdapter.sqlGetDS("SELECT Username,Ext,Pin from EntryUsers WHERE Id=" + id);
            DataRow dr = ds.Tables[0].Rows[0];
            InternalUser ret = new InternalUser()
            {
                Name = (string)dr[0],
                Ext = (string)dr[1],
                Pin = (string)dr[2],
                Id = id
            };
            return ret;
        }

        public static List<InternalUser> GetUsers()
        {
            List<InternalUser> ret = new List<InternalUser>();
            DataAdapter.GetData("SELECT Id,Username,Ext,Pin FROM EntryUsers", System.Data.CommandType.Text, null, delegate(IDataRecord dr) {
                ret.Add(new InternalUser() { Id = (int)dr[0], Name=(string)dr[1] });
            });
            return ret;
        }
    }
}
