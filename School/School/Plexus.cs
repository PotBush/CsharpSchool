using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Plexus
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
            _classList = new Class[classrooms];
        }
    }
}
