using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Class
    {
        private char _section;
        private int _year;
        private int _numStudents;

        public int Year
        {
            get { return _year; }
            private set 
            {
                if (_year != value) throw new ArgumentException("class gose from 1 to 5");
                _year = value; 
            }
        }
        public int NumStudents
        {
            get { return _numStudents; }
            private set 
            {
                if (_numStudents < 10 || _numStudents > 35) throw new ArgumentException("the class must have at 10 students and not over 35");
                _numStudents = value; 
            }
        }
        public Class(char section, int year, int nStudents)
        {
            _section = section;
            _year = year;
            _numStudents = nStudents;
        }
    }
}
