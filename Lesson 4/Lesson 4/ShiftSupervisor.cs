using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class ShiftSupervisor : Employee
    {
        // Fields
        decimal _annualSalary;
        decimal _bonus;

        // Constructor
        public ShiftSupervisor()
        {
            _annualSalary = 0m;
            _bonus = 0m;
        }

        // AnnualSalary property
        public decimal AnnualSalary
        {
            get { return _annualSalary; }
            set { _annualSalary = value; }
        }

        // Bonus property
        public decimal Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
    }
}
