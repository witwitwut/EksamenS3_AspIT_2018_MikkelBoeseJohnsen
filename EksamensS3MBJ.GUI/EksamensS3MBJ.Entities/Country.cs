using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensS3MBJ.Entities
{
    public class Country : GrainBarrelNotify
    {
        private string currencyname;
        private string name;
        private int id;

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

        public string MyProperty
        {
            get { return currencyname; }
            set
            {
                if (value != currencyname)
                {
                    currencyname = value;
                    Notify("currencyname");
                }
            }
        }

    }
}
