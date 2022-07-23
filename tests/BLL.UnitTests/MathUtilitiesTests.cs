using System;
using Xunit;

namespace BLL.UnitTests
{
    public class MathUtilitiesTests
    {
        private readonly MathUtilities _mathUtilities;
        public MathUtilitiesTests()
        {
            _mathUtilities = new MathUtilities();
        }
        [Fact]
        // ReSharper disable once IdentifierTypo
        public void Add_ShoulBe5_IfA2AndB3()
        {
            //Arrange
                const int a = 2;
                const int b = 3;
            //Act
            var result = _mathUtilities.Add(a,b);

            //Assert
            Assert.Equal(5,result);
        }

        [Fact]
        // ReSharper disable once IdentifierTypo
        public void Subtraction_ShoulBe2_IfA10AndB8()
        {
            //Arrange
            const int a = 10;
            const int b = 8;
            //Act
            var result = _mathUtilities.Subtraction(a, b);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        // ReSharper disable once IdentifierTypo
        public void Multiplication_ShoulBe40_IfA8AndB5()
        {
            //Arrange
            const int a = 8;
            const int b = 5;
            //Act
            var result = _mathUtilities.Multiplication(a, b);

            //Assert
            Assert.Equal(40, result);
        }

        [Fact]
        // ReSharper disable once IdentifierTypo
        public void Divide_ShoulBe2_IfA50AndB25()
        {
            //Arrange
            const int a = 50;
            const int b = 25;
            //Act
            var result = _mathUtilities.Divide(a, b);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        // ReSharper disable once IdentifierTypo
        public void Divide_ShoulBeDivideByZeroException_IfA50AndB0()
        {
            //Arrange
            const int a = 50;
            const int b = 0;
            //Act and Assert

            void Action()
            {
                _mathUtilities.Divide(a, b);
            }

            var divideByZeroException = Assert.Throws<DivideByZeroException>(Action);
            Assert.Equal("Attempted to divide by zero.", divideByZeroException.Message);
        }


        [Fact]
        // ReSharper disable once IdentifierTypo
        public void EvenNumber_ShouldBeTru_IfA2()
        {
            //Given
            const int a = 2;
            //When
            var result = _mathUtilities.EvenNumber(a);
            //Then
            Assert.True(result);
        }

        [Fact]
        // ReSharper disable once IdentifierTypo
        public void EvenNumber_ShouldBeTru_IfA1()
        {
            //Given
            const int a = 1;
            //When
            var result = _mathUtilities.EvenNumber(a);
            //Then
            Assert.False(result);
        }
    }
}
