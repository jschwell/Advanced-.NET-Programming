using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    class Car
    {
        // Fields
        private string _make;
        private int _year;
        private int _speed;

        // Constructor
        public Car(string make, int year)
        {
            _make = make;
            _year = year;
            _speed = 0;
        }

        // Make property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        // Year property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Speed property (read-only)
        public int Speed
        {
            get { return _speed; }
        }

        // Accelerate method
        public void Accelerate()
        {
            _speed += 5;
        }

        // Brake method
        public void Brake()
        {
            _speed -= 5;
        }
    }
}
