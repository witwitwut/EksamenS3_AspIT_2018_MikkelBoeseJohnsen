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
            User user = null;
            string query = "Select * FROM VerifyUser" +
                $"Where CPRNR = {userName}" +
                $"AND Password = {password}";
            DataSet ds = ExecuteQuery(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                loginuser = new LogInUser(row.Field<int>("loginid"), row.Field<string>("CPRNR"), row.Field<string>("Password"), row.Field<int>("UserId"));
            }
            try
            {                
                string queryUser = "SELECT * FROM User" +
                                  $"WHERE id = {loginuser.UserId}";
                DataSet dats = ExecuteQuery(queryUser);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    user = new User(row.Field<int>("Id"),row.Field<string>("Name"),row.Field<UserStatus>("StatusId"),row.Field<string>("PhoneNr"),row.Field<Country>("CountryId")); 
                }
            }
            catch (Exception exe)
            {

                throw exe;
            }
            return user;
        }
        public UserStatus GetUserStatus(int id)
        {
            UserStatus us = null;
            string query = "SELECT * FROM UserStatus" +
                $"WHERE Id = {id}";
            DataSet ds = ExecuteQuery(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                us = new UserStatus(row.Field<int>("Id"), row.Field<string>("Status"));
            }
            return us;
        }
    }
    
}
