using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args){

            var grades = new List<double>() {12.7, 12.7, 12.7};
            grades.Add(12.1);
            
            var result = 0.0;
            foreach(double number in grades){
                result += number;
            }

            result /= grades.Count;

            Console.WriteLine($"The average grade is {result:N1}");
            //N1 is a format specifier that prints the result through 1 place after the decimal

            if(args.Length > 0){
            Console.WriteLine($"Hello {args[0]} !");
            //string interpolation: using $ and {array[index]}
            }
            else{
            Console.WriteLine("Hello!");
        }
        }
        
        }
    }
    
