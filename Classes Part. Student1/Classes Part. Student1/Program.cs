//Alex McAllister
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Part.Student1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.FirstName = "James";
            S1.LastName = "Smith";
            S1.CourseNames = new List<string>();
            S1.CourseNames.Add("MIS3013");
            S1.CourseNames.Add("ECON1015");
            S1.CourseNames.Add("JAPN1115");
            S1.CourseGrades = new List<string>();
            S1.CourseGrades.Add("A");
            S1.CourseGrades.Add("B");
            S1.CourseGrades.Add("C");

            Student S2 = new Student();
            S2.FirstName = "Joey";
            S2.LastName = "Tiger";
            S2.CourseNames = new List<string>();
            S2.CourseNames.Add("MIS3013");
            S2.CourseNames.Add("BAD4015");
            S2.CourseNames.Add("HIST3115");
            S2.CourseGrades = new List<string>();
            S2.CourseGrades.Add("A");
            S2.CourseGrades.Add("C");
            S2.CourseGrades.Add("A");


            Console.WriteLine($"{S1.FirstName} {S1.LastName}'s GPA is {S1.CalculateGPA().ToString("N2")}");
            Console.WriteLine($"{S2.FirstName} {S2.LastName}'s GPA is {S2.CalculateGPA().ToString("N2")}");

            Console.ReadKey();
        }
    }
}
