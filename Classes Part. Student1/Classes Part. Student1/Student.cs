//Alex McAllister
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Part.Student1
{
    class Student
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<string> CourseNames { get; set; }

        public List<string> CourseGrades { get; set; }


        public Student()
        {
            FirstName = "";
            LastName = "";
            CourseNames = new List<string>()  ;
            CourseGrades = new List<string>() ;
            
        }


        public Student(string first, string second)
        {
            FirstName = first;
            LastName = second;
            CourseNames = new List<string>();
            CourseGrades = new List<string>();
        }



        public double CalculateGPA()
        {
            double grade = 0;
            double running = 0;
            for (int i = 0; i < CourseGrades.Count; i++)
            {
                
                if (CourseGrades[i].ToUpper() == "A")
                {
                    grade = 4;
                }
                else if (CourseGrades[i].ToUpper() == "B")
                {
                    grade = 3;
                }
                else if (CourseGrades[i].ToUpper() == "C")
                {
                    grade = 2;
                }
                else if (CourseGrades[i].ToUpper() == "D")
                {
                    grade = 1;
                }
                else
                {
                    grade = 0;
                }
                 running = running + grade;
            }
                
                double GPA = running / CourseGrades.Count;
                return GPA;
            }


    }
}
