using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LC
{
    public static class AcceptRequest
    {
        public static void Accept(string _id,bool flag)
        {
            //Executers.Insert("_tblfrnds", RandomGen.GetUniqueKey(), Login._0043, _id, DateTime.Now.ToString(), flag.ToString());
            //QueryExecute.Execute("delete from _tblfrndReq where _reqtoid='" + Login._0043 + "' AND _requestfromid='" + _id + "'");
        }

        public static void Deny(string _id, bool flag)
        {
            //Executers.Insert("_tblfrnds", RandomGen.GetUniqueKey(), Login._0043, _id, DateTime.Now.ToString(), flag.ToString());
            //QueryExecute.Execute("delete from _tblfrndReq where _reqtoid='" + Login._0043 + "' AND _requestfromid='" + _id + "'");
        }
    }
}
