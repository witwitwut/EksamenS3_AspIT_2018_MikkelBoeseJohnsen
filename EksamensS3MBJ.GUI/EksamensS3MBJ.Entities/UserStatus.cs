using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensS3MBJ.Entities
{
    public class UserStatus : GrainBarrelNotify
    {
        private int id;
        private string status;

        public UserStatus(int id, string status)
        {
            Status = status;
            Id = id;
        }

        public string Status
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
