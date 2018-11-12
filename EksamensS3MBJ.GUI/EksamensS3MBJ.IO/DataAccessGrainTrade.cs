using EksamensS3MBJ.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensS3MBJ.IO
{
    public class DataAccessGrainTrade : CommenDataAccess
    {
        public DataAccessGrainTrade(string conString) : base(conString)
        {

        }
        public User VerifyUser(string userName, string password)
        {
            LogInUser loginuser = null;
            string query = "Select * FROM VerifyUser" +
                $"Where CPRNR = {userName}" +
                $"AND Password = {password}";
            DataSet ds = ExecuteQuery(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                loginuser = new LogInUser(row.Field<int>("loginid"), row.Field<string>("CPRNR"), row.Field<string>("Password"), row.Field<int>("UserId"));
            }
            if (loginuser != null)
            {
                string queryUser = "SELECT * FROM User" +
                $"WHERE id = {loginuser.UserId}";
            }

        }
    }
    
}
