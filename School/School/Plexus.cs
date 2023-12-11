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
        
        public Plexus(string name, int classrooms, int baths, int classList)
        {
            _name = name;
            _classrooms = classrooms;
            _baths = baths;
            if (classList > classrooms) throw new ArgumentException("the number of clasroom isn't corect");
        }
    }
}
