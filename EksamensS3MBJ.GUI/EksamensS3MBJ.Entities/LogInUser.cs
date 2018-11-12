using EksamensS3MBJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensS3MBJ.Entities
{
    public class LogInUser : GrainBarrelNotify
    {
        private int loginid;
        private string cprnr;
        private string password;
        private int userId;




        public LogInUser(int loginid, string cprnr, string password, int userid)
        {                
            Password = password;
            CPRNR = cprnr;
            LogInId = loginid;
            UserId = userid;
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value != password)
                {
                    password = value;
                    Notify("password");
                }
            }
        }


        public string CPRNR
        {
            get { return cprnr; }
            set
            {
                if (value != cprnr)
                {
                    cprnr = value;
                    Notify("cprnr");
                }
            }
        }


        public int LogInId
        {
            get { return loginid; }
            set
            {
                if (value != loginid)
                {
                    loginid = value;
                    Notify("loginid");
                }
            }
        }
        public int UserId
        {
            get { return userId; }
            set
            {
                if (value != userId)
                {
                    userId = value;
                    Notify("userId");
                }                
            }
        }


    }
}
