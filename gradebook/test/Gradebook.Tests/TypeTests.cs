using GradeBook;
using System;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void StringBehaveLikeValueType()
        {
            string name = "Loiane";
            var upper = MakeUpperCase(name);

            Assert.Equal("Loiane", name);
            Assert.Equal("LOIANE", upper);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void ValueTypesAlsoPassByValue()
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

        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameRef(out book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }
        //ref ou out vão se comportar igual exceto que para out eu preciso inicializar a variável.
        private void GetBookSetNameRef(out Book book, string name)
        {
            book = new Book(name);
        }


        [Fact]

        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }


        [Fact]

        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");


         //   Assert.Equal("Book 1", book1.Name);
            Assert.Equal("New Name", book1.Name);


        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);

        }
        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(object.ReferenceEquals(book1, book2));


        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
