using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Address_Book
{
    class PersonEntry
    {
        // Fields
        private string _name;
        private string _email;
        private string _phoneNumber;

        // Constructor with 4 arguments
        public PersonEntry(string name, string email, string phoneNumber)
        {
            _name = name;
            _email = email;
            _phoneNumber = phoneNumber;
        }

        // Constructor with no arguments
        public PersonEntry()
        {
            _name = "";
            _email = "";
            _phoneNumber = "";
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Email property
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Phone property
        public string Phone
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }
}
