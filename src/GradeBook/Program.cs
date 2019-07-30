using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            //var book = new InMemoryBook("Shamund's Grade Book");
            var book = new DiskBook("Shamund's Grade Book");
            book.GradeAdded += OnGradeAdded;


            var done = false;
            done = EnterGrades(book, done);

            var stats = book.GetStatistics();
            //book.Name = "";

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            //N1 is a format specifier that prints the result through 1 place after the decimal
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        private static bool EnterGrades(IBook book, bool done)
        {
            while (!done)
            {
                Console.WriteLine("Please enter a grade or 'q' to quit: ");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    done = true;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                    //..
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }

            }

            return done;
        }

        static void OnGradeAdded(object sender, EventArgs e){
            Console.WriteLine("A grade was added!");
        }
    }
}
    
