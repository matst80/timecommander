using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeCommander2.Support
{
    public class Helper
    {
        public static List<SupportComment> GetCommentsByEntry(int eid)
        {
            return SupportComment.GetCustomList<SupportComment>("SELECT * FROM SupportComment WHERE SupportId="+eid);
        }
    }
}
