using System;
using Xunit;

namespace GradeBook.Tests
{

    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod(){
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello");
            Assert.Equal(3, count);
            //Assert.Equal("Hello", result);
        }

        string IncrementCount(string message){
            count++;
            return message.ToLower();
        }

        string ReturnMessage(string message){
            count++;
            return message;
        }

        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpIsPassByRef()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            
            //act
        
            //assert
           Assert.Equal("New Name", book1.Name);
           
        }

        private void GetBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

         [Fact]
        public void CSharpIsPassByValue()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            
            //act
        
            //assert
           Assert.Equal("Book 1", book1.Name);
           
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Shamund";
            var upper = MakeUppercase(name);

            Assert.Equal("Shamund", name);
            Assert.Equal("SHAMUND", upper);
        }

        private string MakeUppercase(string parameter){
           return parameter.ToUpper();
        }

        [Fact]
        //An attribute
        public void GetBookReturnDifferntObjects()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            
            //act
            
            
            //assert
           Assert.Equal("Book 1", book1.Name);
           Assert.Equal("Book 2", book2.Name);
           Assert.NotEqual(book1, book2);
        }

          [Fact]
        public void TwoVarsCanREferenceSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            //This isn't a copy of a book object. It takes the value of book1 and copies it into book2
            
            //act

            //assert
           Assert.Same(book1,  book2);
           Assert.True(Object.ReferenceEquals(book1, book2));
        }

          [Fact]
        public void CanSetNameFromReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            setName(book1, "New Name");
            
            //act
            
            
            //assert
           Assert.Equal("New Name", book1.Name);
           
        }

        private void setName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        private InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
