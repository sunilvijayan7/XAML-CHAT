namespace LC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Executers
    {
        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        public static void Insert(string tablename, string field0)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        public static void Insert(string tablename, string field0, string field1)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        /// <param name="field3">Fourth field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2, string field3)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "', '" 
                                                + field3 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        /// <param name="field3">Fourth field to insert.</param>
        /// <param name="field3">Fifth field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2, string field3, string field4)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "', '" 
                                                + field3 + "', '" + field4 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        /// <param name="field3">Fourth field to insert.</param>
        /// <param name="field3">Fifth field to insert.</param>
        /// <param name="field3">Sixth field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2, string field3, string field4, 
                                    string field5)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "', '"
                                                + field3 + "', '" + field4 + "', '" + field5 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        /// <param name="field3">Fourth field to insert.</param>
        /// <param name="field3">Fifth field to insert.</param>
        /// <param name="field3">Sixth field to insert.</param>
        /// <param name="field3">Seventh field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2, string field3, string field4, 
                                    string field5, string field6)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "', '"
                                                + field3 + "', '" + field4 + "', '" + field5 + "', '" + field6 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        /// <param name="field3">Fourth field to insert.</param>
        /// <param name="field3">Fifth field to insert.</param>
        /// <param name="field3">Sixth field to insert.</param>
        /// <param name="field3">Seventh field to insert.</param>
        /// <param name="field3">Eighth field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2, string field3, string field4, 
                                    string field5, string field6, string field7)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "', '"
                                                + field3 + "', '" + field4 + "', '" + field5 + "', '" + field6 + "', '" 
                                                + field7 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        /// <param name="field3">Fourth field to insert.</param>
        /// <param name="field3">Fifth field to insert.</param>
        /// <param name="field3">Sixth field to insert.</param>
        /// <param name="field3">Seventh field to insert.</param>
        /// <param name="field3">Eighth field to insert.</param>
        /// <param name="field3">Ninth field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2, string field3, string field4,
                                    string field5, string field6, string field7, string field8)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "', '"
                                                + field3 + "', '" + field4 + "', '" + field5 + "', '" + field6 + "', '"
                                                + field7 + "', '" + field8 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        /// <param name="field3">Fourth field to insert.</param>
        /// <param name="field3">Fifth field to insert.</param>
        /// <param name="field3">Sixth field to insert.</param>
        /// <param name="field3">Seventh field to insert.</param>
        /// <param name="field3">Eighth field to insert.</param>
        /// <param name="field3">Ninth field to insert.</param>
        /// <param name="field3">Tenth field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2, string field3, string field4,
                                    string field5, string field6, string field7, string field8, string field9)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "', '"
                                                + field3 + "', '" + field4 + "', '" + field5 + "', '" + field6 + "', '"
                                                + field7 + "', '" + field8 + "', '" + field9 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        /// <param name="field3">Fourth field to insert.</param>
        /// <param name="field3">Fifth field to insert.</param>
        /// <param name="field3">Sixth field to insert.</param>
        /// <param name="field3">Seventh field to insert.</param>
        /// <param name="field3">Eighth field to insert.</param>
        /// <param name="field3">Ninth field to insert.</param>
        /// <param name="field3">Tenth field to insert.</param>
        /// <param name="field3">Eleventh field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2, string field3, string field4,
                                    string field5, string field6, string field7, string field8, string field9, string field10)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "', '"
                                                + field3 + "', '" + field4 + "', '" + field5 + "', '" + field6 + "', '"
                                                + field7 + "', '" + field8 + "', '" + field9 + "', '" + field10 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        /// <param name="field3">Fourth field to insert.</param>
        /// <param name="field3">Fifth field to insert.</param>
        /// <param name="field3">Sixth field to insert.</param>
        /// <param name="field3">Seventh field to insert.</param>
        /// <param name="field3">Eighth field to insert.</param>
        /// <param name="field3">Ninth field to insert.</param>
        /// <param name="field3">Tenth field to insert.</param>
        /// <param name="field3">Eleventh field to insert.</param>
        /// <param name="field3">Twelvth field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2, string field3, string field4,
                                    string field5, string field6, string field7, string field8, string field9, string field10,
                                    string field11)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "', '"
                                                + field3 + "', '" + field4 + "', '" + field5 + "', '" + field6 + "', '"
                                                + field7 + "', '" + field8 + "', '" + field9 + "', '" + field10 + "', '" 
                                                + field11 + "')");
        }

        /// <summary>
        /// Executes the insert query.
        /// </summary>
        /// <param name="tablename">Table name to insert values into.</param>
        /// <param name="field0">First field to insert.</param>
        /// <param name="field1">Second field to insert.</param>
        /// <param name="field2">Third field to insert.</param>
        /// <param name="field3">Fourth field to insert.</param>
        /// <param name="field3">Fifth field to insert.</param>
        /// <param name="field3">Sixth field to insert.</param>
        /// <param name="field3">Seventh field to insert.</param>
        /// <param name="field3">Eighth field to insert.</param>
        /// <param name="field3">Ninth field to insert.</param>
        /// <param name="field3">Tenth field to insert.</param>
        /// <param name="field3">Eleventh field to insert.</param>
        /// <param name="field3">Twelvth field to insert.</param>
        /// <param name="field3">Thirteenth field to insert.</param>
        public static void Insert(string tablename, string field0, string field1, string field2, string field3, string field4,
                                    string field5, string field6, string field7, string field8, string field9, string field10,
                                    string field11, string field12)
        {
            QueryExecute.Execute("insert into " + tablename + " values('" + field0 + "', '" + field1 + "', '" + field2 + "', '"
                                                + field3 + "', '" + field4 + "', '" + field5 + "', '" + field6 + "', '"
                                                + field7 + "', '" + field8 + "', '" + field9 + "', '" + field10 + "', '"
                                                + field11 + "', '" + field12 + "')");
        }

        /// </summary>
        /// <param name="tablename">Table name to delete values into.</param>
        /// <param name="field0">First field to delete.</param>
        /// <param name="field1">Second field to delete.</param>
        public static void Delete(string tablename, string field0, string field1)
        {
            QueryExecute.Execute("delete from" + tablename + " where _userid=" + "'" + field0 + "'" + "AND _friendid=" + "'" + field1 + "'");
        }
    }
}