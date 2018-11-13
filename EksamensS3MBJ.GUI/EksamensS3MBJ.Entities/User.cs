using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensS3MBJ.Entities
{
    public class User : GrainBarrelNotify
    {
        private int userid;
        private string name;
        private UserStatus status;
        private string phonenr;
        private Country country;
        
        public User()
        {

        }

        public User(int userId, string name, UserStatus status, string phoneNr, Country country)
        {
            UserId = userId;
            Name = name;
            Status = status;
            PhoneNr = phoneNr;
            Country = country;
        }

        public int UserId
        {
            get { return userid; }
            set
            {
                if (value != userid)
                {
                    userid = value;
                    Notify("userid");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    name = value;
                    Notify("name");
                }
            }
        }
        public UserStatus Status
        {
            get { return status; }
            set
            {
                if (value != status)
                {
                    status = value;
                    Notify("status");
                }
            }
        }
        public string PhoneNr
        {
            get { return phonenr; }
            set
            {
                if (value != phonenr)
                {
                    phonenr = value;
                    Notify("phonenr");
                }
            }
        }
        public Country Country
        {
            get { return country; }
            set
            {
                if (value != country)
                {
                    country = value;
                    Notify("country");
                }
            }
        }
    }
}
