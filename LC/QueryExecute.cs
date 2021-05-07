namespace LC
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Data.SqlClient;
    using System.Data;
    using System.Web;
    using System.Configuration;
    using System.Collections;

    public static class QueryExecute
    {
        public enum QueryReturn
        {
            DataReader, DataTable, Scalar, NonQuerry
        }

        static SqlConnection Con = new SqlConnection("server=SH3LC0D3-PC;database= CHAT; uid=sa;pwd=*#saihacks@321;");
        public static string temp = "";
        public static string LastError = "";

        #region Private Members
        private static SqlCommand Cmd = new SqlCommand("", Con);
        private static SqlDataAdapter adp = new SqlDataAdapter();

        #endregion

        static void openConnection()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
        }
        static void closeConnection()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
        }
        public static object ExecuteDataSet(string sql)
        {
            openConnection();
            if (sql.ToUpper().StartsWith("SELECT"))
            {
                SqlDataAdapter adp = new SqlDataAdapter(sql, Con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                return ds;
            }
            else
                throw new Exception("Please pass Select,Insert,Update or Delete Statement!");
        }

        public static object Execute(string sql)
        {
            openConnection();
            int retValue = 0;

            if (sql.ToLower().StartsWith("insert") || sql.StartsWith("Update") || sql.StartsWith("Delete") || sql.StartsWith("update") || sql.StartsWith("delete"))
            {
                SqlTransaction tran = Con.BeginTransaction();
                sql = sql.Replace("\n", "");
                string[] Commands = sql.Split(new char[] { ';' });
                try
                {
                    foreach (string str in Commands)
                    {
                        if (str.Trim() != "")
                            retValue += (new SqlCommand(str, Con, tran)).ExecuteNonQuery();
                    }
                    tran.Commit();
                }
                catch (SqlException exc)
                {
                    tran.Rollback();
                    throw exc;
                }
                finally
                {
                    closeConnection();
                }
                return retValue;
            }
            else if (sql.ToLower().StartsWith("select"))
            {
                SqlDataAdapter adp = new SqlDataAdapter(sql, Con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            else
                throw new Exception("Please pass Select,Insert,Update or Delete Statement!");


        }

        public static object Execute(string sql, QueryReturn returns)
        {
            object retValue = new object();
            Cmd.CommandText = sql;
            openConnection();
            switch (returns)
            {
                case QueryReturn.Scalar:
                    {
                        retValue = Cmd.ExecuteScalar();
                        break;
                    }
                case QueryReturn.NonQuerry:
                    {
                        retValue = Cmd.ExecuteNonQuery();
                        break;
                    }
                case QueryReturn.DataTable:
                    {
                        DataTable dt = new DataTable();
                        SqlDataReader dr = Cmd.ExecuteReader();
                        dt.Load(dr);
                        dr.Close();
                        retValue = dt;
                        break;
                    }
                case QueryReturn.DataReader:
                    {
                        retValue = Cmd.ExecuteReader();
                        break;
                    }
                default:
                    {
                        throw new Exception("Invalid Return");
                    }
            }

            return retValue;

        }
        public static object ExecuteProc(string procedureName)
        {
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = procedureName;
            openConnection();
            SqlDataReader dr = Cmd.ExecuteReader();
            closeConnection();
            Cmd.CommandType = CommandType.Text;
            return "";
        }
        public static object ExecuteProc(string procedureName, List<SqlParameter> Params)
        {
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = procedureName;
            foreach (SqlParameter param in Params)
            {
                Cmd.Parameters.Add(param);
            }
            SqlParameter return_parameter = new SqlParameter();
            return_parameter.Direction = ParameterDirection.ReturnValue;
            Cmd.Parameters.Add(return_parameter);
            openConnection();
            SqlDataReader dr = Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            object retValue = return_parameter.Value;
            if (dr.HasRows)
            {
                dt.Load(dr);
                dr.Close();
                retValue = dt;
            }
            closeConnection();
            Cmd.CommandType = CommandType.Text;
            return retValue;
        }
        public static int deleteRow(string tableName, string condition)
        {
            int retValue;
            try
            {
                Cmd.Cancel();
                Cmd.Parameters.Clear();
                Cmd.CommandText = "delete " + tableName + " where " + condition;
                openConnection();
                retValue = Cmd.ExecuteNonQuery();
                return retValue;
            }
            catch (SqlException exception)
            {
                LastError = exception.Source + "\n " + exception.Message;
                return -1;
            }
            finally
            {
                closeConnection();
            }
        }
        public static int updateColumn(String tableName, String Column, object value, string Condition)
        {
            int retValue;
            try
            {
                Cmd.Cancel();
                Cmd.Parameters.Clear();
                Cmd.CommandText = "update " + tableName + " set " + Column + "=@Value where " + Condition;
                Cmd.Parameters.Add(new SqlParameter("@Value", value));
                openConnection();
                retValue = Cmd.ExecuteNonQuery();
                return retValue;
            }
            catch (SqlException exception)
            {
                LastError = exception.Source + "\n" + exception.Message;
                return -1;
            }
            finally
            {
                closeConnection();
            }
        }

        public static int updateColumn(String tableName, String[] columns, object[] values, string Condition)
        {
            int retValue;
            try
            {
                if (columns.Length != values.Length)
                {
                    LastError = "Columns and values were not matching";
                    return -2;
                }
                Cmd.Cancel();
                Cmd.Parameters.Clear();
                string column_Values = "";
                int i = columns.Length;
                for (int j = 0; j < i; j++)
                {
                    column_Values += columns[j] + "=@" + columns[j] + ",";
                    Cmd.Parameters.Add(new SqlParameter("@" + columns[j], values[j]));
                }
                column_Values = column_Values.TrimEnd(new char[] { ',' });
                Cmd.CommandText = "update " + tableName + " set " + column_Values + " where " + Condition;
                openConnection();
                retValue = Cmd.ExecuteNonQuery();
                return retValue;
            }
            catch (SqlException exception)
            {
                LastError = exception.Source + "\n" + exception.Message;
                return -1;
            }
            finally
            {
                closeConnection();
            }
        }
        public static bool InsertScalar(String table, String column, object value)
        {
            bool retValue = false;
            Cmd.Parameters.Clear();
            Cmd.CommandText = "insert " + table + "(" + column + ") values (@value)";
            try
            {
                Cmd.Parameters.Add(new SqlParameter("@value", value));
                openConnection();
                if (Cmd.ExecuteNonQuery() > 0)
                    retValue = true;
            }
            catch (SqlException exc)
            {
                LastError = exc.Source + "\n" + exc.Message;
                return false;
            }
            finally
            {
                closeConnection();
            }
            return retValue;
        }

        public static bool InsertRecord(string tableName, string[] columns, object[] values)
        {
            bool retValue = false;
            try
            {
                int i = 0;
                int len = 0;
                if (columns.Length == values.Length)
                    len = columns.Length;
                else
                {
                    LastError = "Number of columns and values supplied does not Match";
                    return false;
                }
                Cmd.Cancel();
                Cmd.Parameters.Clear();
                string qwery = "insert into " + tableName + " (";
                string qcolumns = "";
                string qvalues = "";
                for (; i < len; i++)
                {
                    qcolumns += columns[i] + ",";
                    qvalues += "@" + columns[i] + ",";
                    Cmd.Parameters.Add(new SqlParameter("@" + columns[i], values[i]));
                }
                qwery += qcolumns.Remove(qcolumns.LastIndexOf(','), 1) + ") values (" + qvalues.Remove(qvalues.LastIndexOf(','), 1) + ")";
                Cmd.CommandText = qwery;//"insert into " + table + "(" + column + ") values (@value)";

                //Cmd.Parameters.Add(new SqlParameter("@value", value)); 
                openConnection();
                if (Cmd.ExecuteNonQuery() == 1)
                    retValue = true;
            }
            catch (SqlException Exc)
            {
                LastError = Exc.Message + "\t Source:" + Exc.Source;
                return false;
            }
            finally
            {
                closeConnection();
            }
            return retValue;
        }
        public static DataTable GetList(string tableName, String[] columns, string condition)
        {
            DataTable retValue = new DataTable();
            retValue.Clear();
            Cmd.Cancel();
            Cmd.Parameters.Clear();
            string columnNames = "";
            foreach (string column in columns)
            {
                columnNames += column + ",";
            }
            columnNames = columnNames.TrimEnd(new char[] { ',' });
            if (condition == "")
                Cmd.CommandText = "select " + columnNames + " from " + tableName;
            else
            {
                Cmd.CommandText = "select " + columnNames + " from " + tableName + " where " + condition;
            }
            adp.SelectCommand = Cmd;
            adp.Fill(retValue);
            return retValue;
        }
        public static String getScalar(String tableName, String column, string condition)
        {
            string retValue = "";
            Cmd.Cancel();
            Cmd.Parameters.Clear();
            if (condition != "")
                Cmd.CommandText = "select " + column + " from " + tableName + " where " + condition;
            else
                Cmd.CommandText = "select " + column + " from " + tableName;
            openConnection();
            retValue = (Cmd.ExecuteScalar() ?? "").ToString();
            closeConnection();
            return retValue;
        }

        public static string LastNo(string table, string column, string initial, double lenth)
        {
            string LastCode = getScalar(table, "max(" + column + ")", string.Empty);
            double newNum;
            if (LastCode != "")
                newNum = Convert.ToDouble(LastCode.TrimStart(initial.ToCharArray())) + 1;
            else
                newNum = 1;
            double zeros = lenth - newNum.ToString().Length;
            string newcode = initial;
            for (double i = 0; i < zeros; i++)
            {
                newcode += "0";
            }
            newcode += newNum.ToString();
            return newcode;
        }

        public static string ConnectionString
        {
            get
            {
                return Con.ConnectionString;
            }
        }
    }

    public enum QueryReturn
    {
        DataReader, DataTable, Scalar, NonQuerry
    }
}