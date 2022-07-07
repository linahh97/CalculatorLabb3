using CalculatorLabb3;
using System;
using Xunit;

namespace CalculatorXUnitTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Get_Addition_return_positive()
        {
            CalculationMethods cm = new CalculationMethods();

            var actual = cm.Addition(80, 20);
            var expected = 100;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Get_Subtraction_return_negative()
        {
            CalculationMethods cm = new CalculationMethods();

            var actual = cm.Subtraction(25, 40);
            var expected = -15;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(7, 3, 21)]
        [InlineData(6, 6, 36)]
        [InlineData(9, 2, 18)]
        [InlineData(8, 1, 8)]
        public void Get_Multiplication(double num1, double num2, double result)
        {
            var multi = new CalculationMethods();

            var actual = multi.Multiplication(num1, num2);

            Assert.Equal(result, actual);
        }

        [Theory]
        [InlineData(16, 4, 4, true)]
        [InlineData(1, 2, 0.5, true)]
        [InlineData(0, 5, 0, true)]
        [InlineData(6, 0, 0, false)]
        [InlineData(8, 0, 8, false)]
        public void Get_Divition_Check_If_0_On_Num2_Works(double num1, double num2, double result, bool expected)
        {
            var div = new CalculationMethods();

            var actual = div.Division(num1, num2);

            Assert.Equal(expected, (result == actual));
        }

        [Theory]
        [InlineData("4+5=9", true)]
        [InlineData("5+5=10", true)]
        [InlineData("7+8=15", true)]
        [InlineData("8+12=20", true)]
        [InlineData("3+2=5", true)]
        public void Print_Calculations_Result(string expected, bool isValid)
        {
            CalculationMethods cm = new CalculationMethods();

            var isTrue = cm.PrintResult();
            var actual = isTrue == expected;

            Assert.Equal(isValid, actual);
        }
    }
}