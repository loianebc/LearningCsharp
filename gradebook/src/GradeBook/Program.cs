using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Loiane's Grade Book");
            book.AddGrade(56.7);
            book.AddGrade(64.2);
            book.AddGrade(77.2);
            var stats = book.GetStatistics();

            
            Console.WriteLine($"A maior nota é {stats.High}");
            Console.WriteLine($"A menor nota é {stats.Low}");
            Console.WriteLine($"A média é {stats.Average:N1}");

         
        }
    }
}
