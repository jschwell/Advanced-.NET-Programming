using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class ProductionWorker : Employee
    {
        // Fields
        private int _shiftNumber;
        private decimal _hourlyPayRate;

        // Constructor
        public ProductionWorker()
        {
            _shiftNumber = 0;
            _hourlyPayRate = 0m;
        }

        // ShiftNumber property
        public int ShiftNumber
        {
            get { return _shiftNumber; }
            set { _shiftNumber = value; }
        }

        // HourlyPayRate property
        public decimal HourlyPayRate
        {
            get { return _hourlyPayRate; }
            set { _hourlyPayRate = value; }
        }
    }
}
