using System;

namespace GradeBook
{
    class Program
    {
        // Main is a method with a parameter- type and name
        // static only available for the type name vs public
        static void Main(string[] args)
        {
            var book = new Book("Mr. Dickerson");
            book.AddGrade(91);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStatistics();
        }
    }
}
