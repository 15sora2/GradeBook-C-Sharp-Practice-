using System;
using System.Collections.Generic;

namespace GradeBook{

    class Book{
        private List<double> grades;
        private string name;
        //These are fields, not a variables

        public Book(string name){
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade){
            grades.Add(grade);
        }

        public void showStatistics()
        {
            var averageGrade = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach(double number in grades){
                if(number > highestGrade){
                    highestGrade = Math.Max(number, highestGrade);
                }
                if(number < lowestGrade){
                    lowestGrade = Math.Min(number, lowestGrade);
                }
                averageGrade += number;
            }

            averageGrade /= grades.Count;

            Console.WriteLine($"The average grade is {averageGrade:N1}");
            //N1 is a format specifier that prints the result through 1 place after the decimal
            Console.WriteLine($"The lowest grade is {lowestGrade:N1}");
            Console.WriteLine($"The highest grade is {highestGrade:N1}");
        }
    }
}