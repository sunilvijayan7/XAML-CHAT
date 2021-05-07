using System.Data.SqlClient;
using System.Data;
using LC;

namespace LC
{
    public class Login
    {
        public static string _usrID;
        public static string _usrname;
        public static string _fstname;
        public static string _lstname;
        public static string _email;
        public static string _secureques;
        public static string _secureans;
        public static int _chkStatus;
        public static bool chk;

        public static bool _chklogin(string _username, string _password)
        {
            if ((_username != null) && (_password != null))
            {
                DataTable dt = (DataTable)QueryExecute.Execute("select * from _tblUsersInfo where _UserEmail='" + _username + "'");
                if (dt.Rows.Count > 0)
                {
                    if (_password == dt.Rows[0]["_UserPassword"].ToString())
                    {
                        _usrID = dt.Rows[0]["_UserID"].ToString();
                        _fstname = dt.Rows[0]["_UserFstName"].ToString();
                        _lstname = dt.Rows[0]["_UserLstName"].ToString();
                        _email = dt.Rows[0]["_UserEmail"].ToString();
                        _secureques = dt.Rows[0]["_UserSecurityQues"].ToString();
                        _secureans = dt.Rows[0]["_UserAnswer"].ToString();
                        _chkStatus = 1;
                        chk = true;
                    }
                    else
                    {
                        _chkStatus = 2;
                    }
                }
                else
                {
                    _chkStatus = 3;
                }
            }
            else
            {
                _chkStatus = 4;
            }
            return chk;
        }
    }
}
