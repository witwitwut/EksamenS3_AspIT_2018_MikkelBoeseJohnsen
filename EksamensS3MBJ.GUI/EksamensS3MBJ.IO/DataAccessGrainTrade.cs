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
            LogInUser loginuser = new LogInUser();
            User user = new User();
            string query = "Select * FROM VerifyUser " +
                $"Where (CPRNR = '{userName}' AND Password = '{password}') ";
            DataSet ds = ExecuteQuery(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                loginuser = new LogInUser(row.Field<int>("id"), row.Field<string>("CPRNR"), row.Field<string>("Password"), row.Field<int>("UserId"));
            }
            if (loginuser == null)
            {
                user.ID = 0;
                return user;
            }
            try
            {                
                string queryUser = "SELECT * FROM [User] " +
                                  $"WHERE Id = '{loginuser.UserId}' ";
                DataSet dats = ExecuteQuery(queryUser);
                foreach (DataRow row in dats.Tables[0].Rows)
                {
                    user = new User(row.Field<int>("Id"), row.Field<string>("Name"), row.Field<int>("StatusId"), row.Field<string>("PhoneNr"), row.Field<int>("CountryId")); 
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

            UserStatus us = new UserStatus();
            us.Id = 0;
            us.Status = "";
            string query = "SELECT * FROM UserStatus " +
                $"WHERE Id = '{id}'";
            DataSet ds = ExecuteQuery(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                us = new UserStatus(row.Field<int>("Id"), row.Field<string>("Status"));
            }
            return us;
        }
        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            string query = "SELECT * FROM Supplier";
            DataSet ds = ExecuteQuery(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                suppliers.Add(new Supplier(row.Field<string>("ZipCity"), row.Field<string>("email"), row.Field<int>("SupplierStatusId"), row.Field<string>("PhonrNr"), row.Field<int>("CountryId"), row.Field<string>("Name"), row.Field<int>("Id")));
            }
            return suppliers;
        }
    }
    
}
