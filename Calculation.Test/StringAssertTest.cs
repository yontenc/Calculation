using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculation.Test
{
    public class FixtureString
    {
        public EmployeeName emp => new EmployeeName();
    }
    [Collection("Employee")]
    public  class StringAssertTest : IClassFixture<FixtureString>
    {
        private readonly FixtureString _fixtureString;

        public StringAssertTest(FixtureString fixtureString)
        {
            _fixtureString = fixtureString;
        }
        [Fact]
        [Trait("Employee","Employee Details")]
        public void GetName_GettingName_ReturnsString()
        {
            var emp = _fixtureString.emp;
            var result = emp.GetName("Yonten");
            Assert.Equal("yonten",result,true);
        }

        [Fact]
        [Trait("Employee", "Employee Details")]
        public void GetFullName_GettingFullName_ReturnsString()
        {
            var emp = _fixtureString.emp;
            var result = emp.GetFullName("Yonten","Choden");
            //using equals
            Assert.Equal("yonten Choden", result,true);
            //using contains
            Assert.Contains("Yonten", result,StringComparison.CurrentCultureIgnoreCase);
            //using regular expression
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+",result);
        }

        [Fact]
        [Trait("Employee", "Employee Details")]
        public void GetNickName_ReturnsNULL()
        {
            var emp = _fixtureString.emp;
           // emp.GetNickName = "Choden";
            Assert.Null(emp.GetNickName);
           // Assert.NotNull(emp.GetNickName);
        }

        [Fact]
        [Trait("Employee", "Employee Details")]
        public void GetFullName_AlwaysReturnValue()
        {
            var emp = _fixtureString.emp;
            var result = emp.GetFullName("Karma", "Choden");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]
        [Trait("Employee", "Employee Details")]
        public void CheckNullOrEmptyName()
        {
            var emp = _fixtureString.emp;
            Assert.False(string.IsNullOrEmpty(emp.Name));
        }

        [Fact]
        [Trait("Employee", "Employee Details")]
        public void CheckLegiForDiscount()
        {
            var emp = _fixtureString.emp;
            Assert.InRange(emp.Age,25,40);
        }

        [Fact]
        [Trait("Employee", "Employee Details")]
        public void GetOrderByNameNotNull()
        {
            var emp = _fixtureString.emp;
           var expectedMessage= Assert.Throws<ArgumentException>(() => emp.GetOrderByName(""));
           Assert.Equal("Name is Empty", expectedMessage.Message);
        }

        [Fact]
        [Trait("Employee", "Employee Details")]
        public void LoyalEmployeeForOderG100()
        {
            var emp = EmployeeFactory.CreateEmployeeInstance(107);
            Assert.IsType(typeof(LoyalEmployee),emp);
        }

        [Fact]
        [Trait("Employee", "Employee Details")]
        public void LoyalEmployeeHasDiscount()
        {
            var emp = EmployeeFactory.CreateEmployeeInstance(104);
            var loyalEmployee = Assert.IsType<LoyalEmployee>(emp);
            Assert.Equal(10,loyalEmployee.Discount);
        }

       
    }
}
