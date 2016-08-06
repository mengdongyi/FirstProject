using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class SqlHelper
    {
        private static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            }
        }


        public static int ExecuteNonQuery(string sql, params SqlParameter[] values)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand comm = new SqlCommand(sql,conn))
                {
                    comm.Parameters.AddRange(values);
                    conn.Open();
                    result = comm.ExecuteNonQuery();
                }
            }
            return result;
        }

        public static DataTable ExecuteQuery(string sql, params SqlParameter[] values)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand comm = new SqlCommand(sql,conn))
                {
                    comm.Parameters.AddRange(values);
                    using (SqlDataAdapter sda = new SqlDataAdapter(comm))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] values)
        {
            object obj = null;
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                using (SqlCommand comm = new SqlCommand(sql,conn))
                {
                    comm.Parameters.AddRange(values);
                    conn.Open();
                    obj = comm.ExecuteScalar();
                }
            }
            return obj;
        }
    }
}
