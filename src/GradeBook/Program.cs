using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args){

            var book = new Book("Shamund's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStatistics();    

            Console.WriteLine($"The average grade is {stats.Average:N1}");
            //N1 is a format specifier that prints the result through 1 place after the decimal
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");

        }
    }
}
    
