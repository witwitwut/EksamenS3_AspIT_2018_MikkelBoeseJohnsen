using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensS3MBJ.Entities
{
    public class Supplier : GrainBarrelNotify
    {
        private int id;
        private string name;
        private int countryid;
        private string phonenr;
        private int statusid;
        private string email;
        private string zipcity;

        public Supplier()
        {
            ZipCity = "";
            Email = "";
            StatusId = 0;
            PhoneNr = "";
            CountryId = 0;
            Name = "";
            Id = 0;
        }

        public Supplier(string zipCity, string email, int statusId, string phoneNr, int countryId, string name, int id)
        {
            ZipCity = zipCity;
            Email = email;
            StatusId = statusId;
            PhoneNr = phoneNr;
            CountryId = countryId;
            Name = name;
            Id = id;
        }

        public string ZipCity
        {
            get { return zipcity; }
            set
            {
                if (value != zipcity)
                {
                    zipcity = value;
                    Notify("zipcity");
                }
            }
        }


        public string Email
        {
            get { return email; }
            set
            {
                if (value != email)
                {
                    email = value;
                    Notify("email");
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


        public int Id
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
    }
}
