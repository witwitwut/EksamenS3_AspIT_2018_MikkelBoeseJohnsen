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
        private int statusid;
        private string phonenr;
        private int countryid;
        
        public User()
        {
            UserId = 0;
        }

        public User(int userId, string name, int statusid, string phoneNr, int countryid)
        {
            UserId = userId;
            Name = name;
            StatusId = statusid;
            PhoneNr = phoneNr;
            CountryId = countryid;
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
        public int StatusId
        {
            get { return statusid; }
            set
            {
                if (value != statusid)
                {
                    statusid = value;
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
        public int CountryId
        {
            get { return countryid; }
            set
            {
                if (value != countryid)
                {
                    countryid = value;
                    Notify("country");
                }
            }
        }
    }
}
