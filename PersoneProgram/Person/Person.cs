using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
	internal class Person
	{
		//attributi
        private string _name;
        private string _surname;
        private int _dayOfBirth;
        private int _monthOfBirth;
        private int _yearOfBirth;
		//propieta
        public string Naem
        {
            get{return _name;}
        }
        public string Surnaem
        {
            get{return _surname;}
        }
        private int DayOfBirht
        {
            get{return _dayOfBirth;}
            set
            {
                if(value <= 28 || value <= 29 || value <= 30 || value <= 31 && value > 0)
                {
                    _dayOfBirth = value;
                }else
                {
                    throw new ArgumentException("the day is invalid");
                }
            }
        }
        private int MonthOfBirth
        {
            get{return _monthOfBirth;}
            set
            {
                if(value > 12 || value <  0)
                {
                    throw new ArgumentException("the mounth is invalid");
                }
                _monthOfBirth = value;
            }
        }
        private int YearOfBirth
        {
            get{return _yearOfBirth;}
            set
            {
                if(value < 1905 /*|| value > DateOnly*/)
                {
                    throw new ArgumentException("the year is invalid");
                }
                
            }
        }
		public Person(string name, string surname, int dayOfBirht, int monthOfBirth, int yearOfBirth)
        {
            _name = name;
            _surname = surname;
            DayOfBirht = dayOfBirht;
            MonthOfBirth = monthOfBirth;
            YearOfBirth = yearOfBirth;

        }
		//metodi
        public bool LeapYearVerificatoin(int year)
        {
            return 
        }
        public int CalculateAge(int day, int month, int year)
        {
            return
        }
        public bool VerifyOverAge()
        {
            return
        }
        public bool VerifyPreSchoolAge()
        {
            return  
        }
  }
}