using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class School
    {
        private string _name;
        private Plexus _plexusList;

        public School(string name, Plexus plexusList)
        {
            _name = name;
            _plexusList = plexusList;
        }
    }
}
