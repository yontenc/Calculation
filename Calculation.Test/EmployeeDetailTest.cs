using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculation.Test
{
    [Collection("Employee")]
    public class EmployeeDetailTest
    {
        private readonly FixtureString _fixtureString;

        public EmployeeDetailTest(FixtureString fixtureString)
        {
            _fixtureString = fixtureString;
        }

        [Fact]
        [Trait("Employee Detail", "Employee Details")]
        public void GetLastName()
        {
            var emp = _fixtureString.emp;
            Assert.Equal("Choden", emp.GetNickName = "Choden",true);
        }
    }
}
