using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensS3MBJ.Entities
{
    public class User : GrainBarrelNotify
    {
        private int id;
        private string name;
        private int statusid;
        private string phonenr;
        private int countryid;
        
        public User()
        {
            ID = 0;
        }

        public User(int Id, string name, int statusid, string phoneNr, int countryid)
        {
            ID = Id;
            Name = name;
            StatusId = statusid;
            PhoneNr = phoneNr;
            CountryId = countryid;
        }

        public int ID
        {
            get { return id; }
            set
            {
                if (value != id)
                {
                    id = value;
                    Notify("id");
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
