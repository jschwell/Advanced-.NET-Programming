using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    class Employee
    {
        // Fields
        private string _name;
        private int _id;
        private string _department;
        private string _position;

        // Constructor with 4 arguments
        public Employee(string name, int id, string department, string position)
        {
            _name = name;
            _id = id;
            _department = department;
            _position = position;
        }

        // Constructor with 2 arguments
        public Employee(string name, int id)
        {
            _name = name;
            _id = id;
            _department = "";
            _position = "";
        }

        // Constructor with no arguments
        public Employee()
        {
            _name = "";
            _id = 0;
            _department = "";
            _position = "";
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Id property
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        // Department property
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        // Position property
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
