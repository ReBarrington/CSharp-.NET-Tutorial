using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        // Main is a method with a parameter- type and name
        // static only available for the type name vs public
        static void Main(string[] args)
        {
            var book = new Book("Mr. Dickerson's Grade Book");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The letter grade is {stats.Letter}");


        }

        private static void EnterGrades (Book book)
        {
                   while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if(input =="q")
                {
                    break;
                }

                try {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(AgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex) {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**")
                }
            }
        }
    }
}
