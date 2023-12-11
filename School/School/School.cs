using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private string _name;
        private Plexus[] _plexusList;

        public School(string name, int plexusList)
        {
            _name = name;
            _plexusList = new Plexus[plexusList];
        }

        public int CalculateHowManyStudentsinPlexusX(int plexusX)
        {
            int students = 0;
            for(int i=0; i<_plexusList[plexusX].ClassList.Length ;i++)
            {
                students += _plexusList[plexusX].ClassList[i].NumStudents;
            }
            return students;
        }
        public int CalculateTotalNumClassrooms()
        {
            int clasrooms = 0;
            for(int i=0; i<_plexusList.Length;i++)
            {
                clasrooms += _plexusList[i].Classrooms;
            }
            return clasrooms;
        }

        public int TotalStudents()
        {
            int totalStudents = 0;
            for(int i=0; i<_plexusList.Length;i++)
            {
                for(int k=0; k<_plexusList[i].ClassList.Length; k++)
                {
                    totalStudents += _plexusList[i].ClassList[k].NumStudents;
                }
            }
            return totalStudents;
        }

        public int TotalStudentsInCourseX(char courseX)
        {
            int totalStudents = 0;
            for(int i=0; i<_plexusList.Length;i++)
            {
                for(int k=0; k<_plexusList[i].ClassList.Length; k++)
                {
                    if(_plexusList[i].ClassList[k].Section == courseX)
                    {
                        totalStudents += _plexusList[i].ClassList[k].NumStudents;
                    }
                }
            }
            return totalStudents;
        }

        public int TotalStudentsInYearX(char yearX)
        {
            int totalStudents = 0;
            for(int i=0; i<_plexusList.Length;i++)
            {
                for(int k=0; k<_plexusList[i].ClassList.Length; k++)
                {
                    if(_plexusList[i].ClassList[k].Year == yearX)
                    {
                        totalStudents += _plexusList[i].ClassList[k].NumStudents;
                    }
                }
            }
            return totalStudents;
        }
    }
}
