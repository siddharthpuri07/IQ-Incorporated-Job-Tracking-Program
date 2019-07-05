using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBaseSoftware
{
    public class Client : Person
    {
        public string BusinessName { get; set; }

        public Client(string name, string address, string landLine, string mobilePhone, string email, string businessName)
            : base(name, address, landLine, mobilePhone, email)
        {
            BusinessName = businessName;
        }
    }
}
