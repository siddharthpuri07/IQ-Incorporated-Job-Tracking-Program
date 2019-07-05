using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBaseSoftware
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string LandLine { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }

        public Person(string name, string address, string landLine, string mobilePhone, string email)
        {
            Name = name;
            Address = address;
            LandLine = landLine;
            MobilePhone = mobilePhone;
            Email = email;
        }
    }
}
