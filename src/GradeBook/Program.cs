using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args){

            var book = new Book("Shamund's Grade Book");

            var done = false;

            while(!done){
                Console.WriteLine("Please enter a grade or 'q' to quit: ");
                var input = Console.ReadLine();

                if(input == "q"){
                    done = true;
                }

                try{
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                } catch(ArgumentException ex) {
                    Console.WriteLine(ex.Message);
                } catch(FormatException ex) {
                    Console.WriteLine(ex.Message);
                }
                finally{
                    Console.WriteLine("**");
                }
                
            }
            
            var stats = book.GetStatistics();    

            Console.WriteLine($"The average grade is {stats.Average:N1}");
            //N1 is a format specifier that prints the result through 1 place after the decimal
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
    
