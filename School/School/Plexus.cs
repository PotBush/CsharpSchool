using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Plexus
    {
        private string _name;
        private int _classrooms;
        private int _baths;
        private Class[] _classList;
        
        public int Classrooms
        {
            get{ return _classrooms; }
            private set
            {
                if(value <= 0) throw new ArgumentException("the number of clasrooms isn't corect");
                _classrooms = value;
            }
        }

        public Class[] ClassList
        {
            get{ return _classList; }
        }

        public int Baths
        {
            get{ return _baths; }
            private set
            {
                if(value <= 0) throw new ArgumentException("the number of clasrooms isn't corect");
                _baths = value;
            }
        }

        public Plexus(string name, int classrooms, int baths, int classList)
        {
            _name = name;
            Classrooms = classrooms;
            Baths = baths;
            if (classList > classrooms) throw new ArgumentException("the number of clasroom isn't corect");
            _classList = new Class[classList];
            SortClasses();
            
        }

        public void SortClasses()
        {
            int temp;
            for (int i = 1; i<_classList.Length; i++)
            {
                for(int k = 1; k<_classList.Length; k++)
                {
                    if(_classList[k].Year < _classList[k-1].Year)
                    {
                        temp = _classList[k-1].Year;
                        _classList[k-1].Year = _classList[k].Year;
                        _classList[k].Year = temp;
                    }
                }
            }
        }
        public void AddClass(Class newClass)
        {
            Class[] temp = new Class[_classList.Length+1];
            
            for(int i=0; i<_classList.Length;i++)
            {
                temp[i]=_classList[i];
            }
            
            temp[_classList.Length] = newClass;
            _classList = temp;
            SortClasses();
        }


    }
}
