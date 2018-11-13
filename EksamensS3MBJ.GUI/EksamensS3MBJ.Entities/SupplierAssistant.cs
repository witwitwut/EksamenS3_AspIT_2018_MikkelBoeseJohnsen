using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensS3MBJ.Entities
{
    public class SupplierAssistant : GrainBarrelNotify
    {
        private int id;
        private string name;
        private string mobilnr;
        private string directphone;
        private string directemail;
        private Supplier supplier;

        public Supplier _Supplier
        {
            get { return supplier; }
            set
            {
                if (value != supplier)
                {
                    supplier = value;
                    Notify("supplier");
                }

            }
        }


        public string DirectEmail
        {
            get { return directemail; }
            set
            {
                if (value != directemail)
                {
                    directemail = value;
                    Notify("directemal");
                }

            }
        }


        public string DirectPhone
        {
            get { return directphone; }
            set
            {
                if (value != directphone)
                {
                    directphone = value;
                    Notify("directphone");
                }

            }
        }


        public string MobilNr
        {
            get { return mobilnr; }
            set
            {
                if (value != mobilnr)
                {
                    mobilnr = value;
                    Notify("mobilnr");
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
