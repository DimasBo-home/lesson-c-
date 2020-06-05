using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPhoneBook
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string info() {
            string info = "";
            if (this.FirstName.Length > 0)
                info += this.FirstName + " ";
            if (this.LastName.Length > 0)
                info += this.LastName + " ";

            info += " | " + this.PhoneNumber;

            return info;
        }
    }
}
