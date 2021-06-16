using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Calculation.Test
{
    public class CalculatorFixture
    {
        public Calculator cal => new Calculator();
    }
    public class CalculatorTest : IClassFixture<CalculatorFixture>,IDisposable
    {
        private readonly CalculatorFixture _calculatorFicFixture;
        private readonly ITestOutputHelper _outputHelper;

        public CalculatorTest(CalculatorFixture calculatorFixture,ITestOutputHelper outputHelper)
        {
            _calculatorFicFixture = calculatorFixture;
            _outputHelper = outputHelper;
           _outputHelper.WriteLine("CalculatorTest constructor");
        }
        
        [Fact]
        [Trait("Calculator", "Addition")]
        public void Add_AddingTwoIntValues_ReturnsSum()
        {
            var cal = _calculatorFicFixture.cal;
            var result = cal.Add(2, 3);
            Assert.Equal(5,result);
        }

        [Fact]
        [Trait("Calculator", "Addition")]
        public void AddTwoDouble_AddingTwoDoubleValues_ReturnsSum()
        {
            var cal = _calculatorFicFixture.cal;
            var result = cal.AddTwoDouble(3.4, 6.75);
            Assert.Equal(10.2,result,1);
        }

        [Fact]
        [Trait("Catagory","Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            var cal =_calculatorFicFixture.cal;
            Assert.DoesNotContain(0,cal.FiboNumbers);
            //Assert.All(cal.FiboNumbers,n=>Assert.NotEqual(0,n));
           
        }

        [Fact]
        [Trait("Catagory", "Fibo")]
        public void FiboIncludes13()
        {
            var cal = _calculatorFicFixture.cal;
            var result = cal.FiboNumbers;
            Assert.Contains(13, result);
        }

        [Fact]
        [Trait("Catagory", "Fibo")]
        public void FiboDoesNotIncludes4()
        {
            var cal = _calculatorFicFixture.cal;
            //Assert.DoesNotContain(4, cal.FiboNumbers);
            Assert.All(cal.FiboNumbers, n=>Assert.NotEqual(4,n));
        }

        [Fact]
        [Trait("Catagory", "Fibo")]
        public void CheckCollection()
        {
            var cal = _calculatorFicFixture.cal;
            var expectedCollection = new List<int> {1,1,2,3,5,8,13};
            Assert.Equal(expectedCollection,cal.FiboNumbers);
            
        }

        [Theory]
        //inline data test which is not sharable with other test classes
        //[InlineData(1,true)]
        //[InlineData(200,false)]
        //sharable test method
        //[MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
        //From external data driven test method
        //[MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
        //Custom Attribute test method
        [IsOddOrEvenData]
        public void IsOdd_ReturnTrue(int value, bool expected)
        {
            var cal = _calculatorFicFixture.cal;
            var result = cal.IsOdd(value);
            Assert.True(expected);
        }

        public void Dispose()
        {
        
        }
    }
}
