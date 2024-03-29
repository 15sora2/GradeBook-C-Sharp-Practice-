using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        //An attribute
        public void BookCalculatesAverageGrade()
        {
            //arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.GetStatistics();
            
            //assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void RejectsInvalidGradeValue(){
            var book = new InMemoryBook("This Book");
            book.AddGrade(90);
            book.AddGrade(73.7);
            //book.AddGrade(102);

            var result = book.GetStatistics();
            
            Assert.Equal(90, result.High);
        }
    }
}
