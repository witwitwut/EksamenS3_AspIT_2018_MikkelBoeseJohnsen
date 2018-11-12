using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensS3MBJ.Entities
{
    public class LogInUser : GrainBarrelNotify
    {
        User user;
        private int loginid;
        private string cprnr;
        private string password;

        public LogInUser(User user, int loginid, string cprnr, string password)
        {                
            Password = password;
            CPRNR = cprnr;
            LogInId = loginid;           

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


    }
}
