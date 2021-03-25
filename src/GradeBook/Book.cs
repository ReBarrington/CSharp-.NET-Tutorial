using System;
using System.Collections.Generic;

namespace GradeBook
{

    public class NamedObject
    {
        public string Name {
            get;
            set;
        }
    }

    public class Book : NamedObject
    {
        public Book(string teacher) 
        // constructor
        {
            name = Name;
            // getting name from NamedObject inheritance 
            this.teacher = teacher;
            grades = new List<double>();
            // The double is a fundamental data type built 
            // into the compiler and used to define numeric 
            // variables holding numbers with decimal points. 
        }

        public void AddGrade(double grade)
        // void because it will not return anything
        {
            grades.Add(grade);
        }

        public void ShowStatistics() {
            var average = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach(var number in grades)
            {   
                highestGrade = Math.Max(number, highestGrade);
                lowestGrade = Math.Min(number, lowestGrade);
                average += number;
            }
            average /= grades.Count;
            // N1 is number with one decimal
            Console.WriteLine($"{this.teacher}'s class:");
            Console.WriteLine($"The lowest grade is {lowestGrade}");
            Console.WriteLine($"The highest grade is {highestGrade}");
            Console.WriteLine($"The average grade is {average:N1}");
        }

        // fields
        private string name;
        private string teacher;
        private List<double> grades;
    }
}