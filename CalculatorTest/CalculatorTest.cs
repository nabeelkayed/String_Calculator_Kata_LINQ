using Xunit;
using String_Calculator_Kata;
using System;

namespace Calculator_Test
{
    public class CalculatorShould
    {
        [Fact]
        public void AddNumbersInStringWithEmptyString()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("");

            Assert.Equal(0, x);
        }
        [Fact]
        public void AddNumbersInStringWithOneNumber()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("2");

            Assert.Equal(2, x);
        }
        [Fact]
        public void AddNumbersInStringWithTwoNumbers()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("1,2");
             
            Assert.Equal(3, x);
        }
        [Fact]
        public void AddNumbersInStringWithDifferentDelimiter()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("1\n2");

            Assert.Equal(3, x);
        }
        [Fact]
        public void AddNumbersInStringWithDifferentDelimiter1()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("1\n2,3");

            Assert.Equal(6, x);
        }
        [Fact]
        public void AddNumbersInStringWithDifferentDelimiter22()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("//;\n1;2;8");

            Assert.Equal(11, x);
        }
        [Fact]
        public void AddNumbersInStringWithDifferentDelimiter23()
        {
            Calculator newcalculator = new Calculator();

            var ex = Assert.Throws<Exception>(() => newcalculator.add("1,2,-1"));
            Assert.Equal("Negatives Not Allowed: -1", ex.Message);

        }
        [Fact]
        public void AddNumbersInStringWithDifferentDelimiter24()
        {
            Calculator newcalculator = new Calculator();

            var ex = Assert.Throws<Exception>(() => newcalculator.add("1,2,-1,-3,-4"));
            Assert.Equal("Negatives Not Allowed: -1, -3, -4", ex.Message);

        }
        [Fact]
        public void AddNumbersInStringWithDifferentDelimiter25()
        {
            Calculator newcalculator = new Calculator();

            int x = newcalculator.add("1,2,100,1001");

            Assert.Equal(103, x);

        }
    }
}
