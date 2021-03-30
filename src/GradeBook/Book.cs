using System;
using System.Collections.Generic;

namespace GradeBook
{
    // everything that is a book base, to have a AddGrade method
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class NamedObject
    {
        public string Name
        {
            get;
            set;
        }
    }


    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }

    public class Book : NamedObject
    {
        public Book(string name) : base(name)
        // constructor
        {
            Name = name;
            // getting name from NamedObject inheritance 
            grades = new List<double>();
            // The double is a fundamental data type built 
            // into the compiler and used to define numeric 
            // variables holding numbers with decimal points. 
        }

        public void AddGrade(double grade)
        // void because it will not return anything
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var i = 0;
            do
            {
                result.High = Math.Max(grades[i], highestGrade);
                result.Low = Math.Min(grades[i], lowestGrade);
                result.Average += grades[i];
                i++;
            } while(i < grades.Count);
            result.Average /= grades.Count;
            
            return result;
        }

        // fields
        private string Name;
        private List<double> grades;
    }
}