using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


namespace LC
{
    public static class FriendSearch
    {
        public static string _0051;
        public static string _0052;
        public static string _0053;
        public static string _0054;
        public static string _0055;
        public static string _0056;
        public static string usrid;
        public static bool t = false;
        public static ArrayList root = new ArrayList();
        public static ArrayList the = new ArrayList();

        public static void Search(string _0050, string lsn)
        {
            if (string.IsNullOrEmpty(lsn)==false)
            {
                SqlConnection con = new SqlConnection("Data Source=SH3LLC0D3-PC; User ID=sa; Password=saihacks@321; Initial Catalog=LPE-Chat;");
                SqlCommand cmd = new SqlCommand("select * from tblRegisterLogin where username like '%" + _0050 + "%' OR firstname like '%" + _0050 + "%' OR emailadd like '%" + _0050 + "%' OR lastname like '%" + lsn + "%'", con);
                con.Open();
                SqlDataReader reder = cmd.ExecuteReader();
                if (reder.HasRows)
                {
                    con.Close();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            if (!the.Contains(dr["user_id"].ToString()))
                            {
                                the.Add(dr["user_id"].ToString());
                                t = true;
                            }
                            else
                            {
                                root.Add(dr["user_id"].ToString());
                                t = false;
                            }
                        }
                    }
                }
            }
            else
            {
                string _srch = _0050.Trim();
                SqlConnection con = new SqlConnection("Data Source=SH3LLC0D3-PC; User ID=sa; Password=saihacks@321; Initial Catalog=LPE-Chat;");
                SqlCommand cmd = new SqlCommand("select * from tblRegisterLogin where username like '%" + _srch + "%' OR firstname like '%" + _srch + "%' OR emailadd like '%" + _srch + "%' ", con);
                con.Open();
                SqlDataReader reder = cmd.ExecuteReader();
                if (reder.HasRows)
                {
                    con.Close();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            if (!the.Contains(dr["user_id"].ToString()))
                            {
                                the.Add(dr["user_id"].ToString());
                                t = true;
                            }
                            else
                            {
                                root.Add(dr["user_id"].ToString());
                                t = false;
                            }
                        }
                    }
                }
            }
        }
        public static void SearchResult(string _0057)
        {
            DataTable dt = (DataTable)QueryExecute.Execute("select * from tblRegisterLogin where user_id='" + _0057 + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _0053 = dt.Rows[0]["firstname"].ToString();
                _0054 = dt.Rows[0]["lastname"].ToString();
                _0055 = dt.Rows[0]["username"].ToString();
                _0056 = dt.Rows[0]["emailadd"].ToString();
                usrid = dt.Rows[0]["user_id"].ToString();
            }
        }

        public static string _0058
        {
            get { return _0053; }
            set { _0053 = value; }
        }

        public static string _0059
        {
            get { return _0054; }
            set { _0054 = value; }
        }

        public static string _0060
        {
            get { return _0055; }
            set { _0055 = value; }
        }

        public static string _0061
        {
            get { return _0056; }
            set { _0056 = value; }
        }

        public static string id
        {
            get { return usrid; }
            set { usrid = value; }
        }
    }
}