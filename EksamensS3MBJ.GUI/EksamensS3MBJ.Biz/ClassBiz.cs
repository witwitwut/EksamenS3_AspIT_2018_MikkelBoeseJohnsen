using EksamensS3MBJ.Entities;
using EksamensS3MBJ.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EksamensS3MBJ.Biz
{
    public class ClassBiz
    {
        User user = new User();
        UserStatus userStatus = new UserStatus();
        DataAccessGrainTrade DAGT = new DataAccessGrainTrade(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GrainTradeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private List<Supplier> suppliers;
        GrainBarrelNotify GBNotify = new GrainBarrelNotify();
        
        public User UseVerifyUser(string un, string pw)
        {

            user = DAGT.VerifyUser(un, pw);
            return user;

        }
        public List<Supplier> UseGetAllSuppliers()
        {
            suppliers = DAGT.GetAllSuppliers();
            return suppliers;
        }
        public UserStatus UseGetUserStatus(int id)
        {
            userStatus = DAGT.GetUserStatus(id);
            return userStatus ;
        }
        public List<Supplier> Suppliers
        {
            get { return suppliers; }
            set
            {
                if (value != suppliers)
                {
                    suppliers = value;
                    GBNotify.Notify("suppliers");
                }
            } 
        }
       
    }
}
