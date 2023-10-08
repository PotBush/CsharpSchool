 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
	public class PersonClass
	{
		//attributi
        private string _name;
        private string _surname;
        private int _dayOfBirth;
        private int _monthOfBirth;
        private int _yearOfBirth;
		//propieta
        public string Name
        {
            get{return _name;}
        }
        public string Surname
        {
            get{return _surname;}
        }
        private int DayOfBirht
        {
            get{return _dayOfBirth;}
            set
            {
                if(MonthOfBirth == 2)
                {
                    if(LeapYearVerificatoin(YearOfBirth)){
                        if(value>29 && value <=0)
                        {
                            throw new ArgumentException("the day is invalid");
                        }
                    }else
                    {
                        if(value>28 && value <=0)
                        {
                            throw new ArgumentException("the day is invalid");
                        }
                    }
                }else
                {
                    if(MonthOfBirth == 4 || MonthOfBirth == 6 || MonthOfBirth == 9 || MonthOfBirth == 11)
                    {
                        if(value>30 && value <=0)
                        {
                            throw new ArgumentException("the day is invalid");
                        }
                    }else
                    {
                        if(value>31 && value <=0)
                        {
                            throw new ArgumentException("the day is invalid");
                        }else
                        {
                            _dayOfBirth = value;
                        }
                    }
                }

            }
        }
        private int MonthOfBirth
        {
            get{return _monthOfBirth;}
            set
            {
                if(value > 12 && value <=  0)
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
                if(value < 1905 )
                {
                    throw new ArgumentException("the year is invalid");
                }else
                {
                    _yearOfBirth = value;
                }

            }
        }
		public PersonClass(string name, string surname, int dayOfBirht, int monthOfBirth, int yearOfBirth)
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
            if(year<YearOfBirth)
            {
                throw new Exception("the actual year isn't valid");
            }
            bool leapYear = false;
            if(year%100 == 0)
            {
                if(year%400 == 0)
                {
                    leapYear = true;
                }
            }else
            {
                if(year%4 == 0)
                {
                    leapYear = true;
                }
            }
            return leapYear;
        }
        public int CalculateAge(int day, int month, int year)
        {
            if(year<YearOfBirth)
            {
                throw new Exception("the actual year isn't valid");
            }
            int age = 0;
            if(MonthOfBirth < month)
                {
                    age = year - YearOfBirth;
                }else
                {
                    if(month == MonthOfBirth)
                    {
                        if(DayOfBirht <= day)
                        {
                            age = year - YearOfBirth;
                        }else
                        {
                            age = year - YearOfBirth-1;
                        }
                    }else{
                        age = year - YearOfBirth-1;
                    }
                }
            return age;

        }
        public bool VerifyOverAge(int day, int month, int year)
        {
            bool overAge = false;
            if(CalculateAge(day, month, year)>=18)
            {
                overAge = true;
            }
            return overAge;
        }
        public bool VerifyPreSchoolAge(int day, int month, int year)
        {
            bool preSchoolAge = false;
            if(CalculateAge(day, month, year)<=5)
            {
                preSchoolAge = true;
            }
            return preSchoolAge;
        }
  }
}
