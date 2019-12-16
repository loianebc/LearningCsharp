using GradeBook;
using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BooksTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.GetStatistics();
            
            //assert
            Assert.Equal(85.6, result.Average, 1
                );
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);



        }

        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(105.1); //Este não entra por estar acima de 100
            book.AddGrade(-77.3); //Este não entra por estar abaixo de 0
            book.AddGrade(0);
            book.AddGrade(100);
            book.AddGrade(77.3);

            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(59.1, result.Average, 1);
            Assert.Equal(100, result.High, 1);
            Assert.Equal(0, result.Low, 1);



        }



    }
}
