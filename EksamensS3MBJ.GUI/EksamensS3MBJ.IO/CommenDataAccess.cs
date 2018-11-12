using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensS3MBJ.IO
{
    public class CommenDataAccess
    {
        private string conString;

        public CommenDataAccess(string conString)
        {
            ConString = conString;
        }

        public string ConString
        {
            get { return conString; }
            private set { conString = value; }
        }
        protected int ExecuteNonQuery(string q)
        {
            int rowsaffected;
            using (SqlConnection con = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand(q, con))
                {
                    con.Open();

                    rowsaffected = com.ExecuteNonQuery();
                }
            }
            return rowsaffected;
        }
        protected DataSet ExecuteQuery(string q)
        {
            DataSet info;
            using(SqlConnection con = new SqlConnection(conString))
            using(SqlCommand com = new SqlCommand(q,con))
            {
                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(com);

                da.Fill(ds);

                info = ds;
            }
            return info;
        }

    }
}
