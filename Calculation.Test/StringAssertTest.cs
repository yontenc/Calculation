using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculation.Test
{
    public  class StringAssertTest
    {
        [Fact]
        public void GetName_GettingName_ReturnsString()
        {
            var emp = new EmployeeName();
            var result = emp.GetName("Yonten");
            Assert.Equal("yonten",result,true);
        }

        [Fact]
        public void GetFullName_GettingFullName_ReturnsString()
        {
            var emp = new EmployeeName();
            var result = emp.GetFullName("Yonten","Choden");
            //using equals
            Assert.Equal("yonten Choden", result,true);
            //using contains
            Assert.Contains("Yonten", result,StringComparison.CurrentCultureIgnoreCase);
            //using regular expression
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+",result);
        }

        [Fact]
        public void GetNickName_ReturnsNULL()
        {
            var emp = new EmployeeName();
           // emp.GetNickName = "Choden";
            Assert.Null(emp.GetNickName);
           // Assert.NotNull(emp.GetNickName);
        }

        [Fact]
        public void GetFullName_AlwaysReturnValue()
        {
            var emp = new EmployeeName();
            var result = emp.GetFullName("Karma", "Choden");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void CheckNullOrEmptyName()
        {
            var emp = new EmployeeName();
            Assert.False(string.IsNullOrEmpty(emp.Name));
        }

        [Fact]
        public void CheckLegiForDiscount()
        {
            var emp = new EmployeeName();
            Assert.InRange(emp.Age,25,40);
        }
    }
}
