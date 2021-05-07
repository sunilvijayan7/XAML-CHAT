using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace LC
{
    public static class ContactsLoad
    {
        public static ArrayList _contacts = new ArrayList();
        public static void load(string id)
        {
            SqlConnection con = new SqlConnection("Data Source=SH3LLC0D3-PC; User ID=sa; Password=saihacks@321; Initial Catalog=LPE-Chat;");
            SqlCommand cmd = new SqlCommand("select * from _tblfrnds where _userid='" + id + "'", con);
            SqlCommand cmd1 = new SqlCommand("select * from _tblfrnds where _friendid='" + id + "'", con);
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
                        _contacts.Add((dr["_friendid"].ToString()));
                    }
                }
            }
            con.Open();
            SqlDataReader reder1 = cmd1.ExecuteReader();
            if (reder1.HasRows)
            {
                con.Close();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        _contacts.Add((dr["_userid"].ToString()));
                    }
                }
            }
        }

    }
}
