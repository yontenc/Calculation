using System.Collections.Generic;
using Xunit;

namespace Calculation.Test
{
    public class CalculatorTest
    {
        
        [Fact]
        public void Add_AddingTwoIntValues_ReturnsInt()
        {
            var cal = new Calculator();
            var result = cal.Add(2, 3);
            Assert.Equal(5,result);
        }

        [Fact]
        public void AddTwoDouble_AddingTwoDoubleValues_ReturnsDouble()
        {
            var cal = new Calculator();
            var result = cal.AddTwoDouble(3.4, 6.75);
            Assert.Equal(10.2,result,1);
        }

        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            var cal = new Calculator();
            Assert.DoesNotContain(0,cal.FiboNumbers);
            //Assert.All(cal.FiboNumbers,n=>Assert.NotEqual(0,n));
           
        }

        [Fact]
        public void FiboIncludes13()
        {
            var cal = new Calculator();
            var result = cal.FiboNumbers;
            Assert.Contains(13, result);
        }

        [Fact]
        public void FiboDoesNotIncludes4()
        {
            var cal = new Calculator();
            //Assert.DoesNotContain(4, cal.FiboNumbers);
            Assert.All(cal.FiboNumbers, n=>Assert.NotEqual(4,n));
        }

        [Fact]
        public void CheckCollection()
        {
            var cal = new Calculator();
            var expectedCollection = new List<int> {1,1,2,3,5,8,13};
            Assert.Equal(expectedCollection,cal.FiboNumbers);
            
        }
    }
}
