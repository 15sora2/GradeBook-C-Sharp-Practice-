using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        //An attribute
        public void BookCalculatesAverageGrade()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            
            //act
            
            
            //assert
           Assert.Equal("Book 1", book1.Name);
           Assert.Equal("Book 2", book2.Name);
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
