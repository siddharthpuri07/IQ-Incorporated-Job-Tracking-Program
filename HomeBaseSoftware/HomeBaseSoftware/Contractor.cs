using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBaseSoftware
{
    public class Contractor : Person
    {
        public string EmployeeID { get; set; }

        public Contractor(string name, string address, string landLine, string mobilePhone, string email, string employeeID)
            : base(name, address, landLine, mobilePhone, email)
        {
            EmployeeID = employeeID;
        }
    }
}
