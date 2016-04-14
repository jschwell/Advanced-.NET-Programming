using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class TeamLeader : ProductionWorker
    {
        // Fields
        decimal _bonus;
        int _requiredHours;
        int _attendedHours;

        // Constructor
        public TeamLeader()
        {
            _bonus = 0m;
            _requiredHours = 0;
            _attendedHours = 0;
        }

        // Bonus property
        public decimal Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

        // RequiredHours property
        public int RequiredHours
        {
            get { return _requiredHours; }
            set { _requiredHours = value; }
        }

        //AttendedHours property
        public int AttendedHours
        {
            get { return _attendedHours; }
            set { _attendedHours = value; }
        }
    }
}
