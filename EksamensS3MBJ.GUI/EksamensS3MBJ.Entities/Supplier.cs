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
        private Country country;
        private string phonenr;
        private SupplierStatus status;
        private string email;
        private string zipcity;

        public string ZipCity
        {
            get { return zipcity; }
            set { zipcity = value; }
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


        public SupplierStatus Status
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


        public Country _Country
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
