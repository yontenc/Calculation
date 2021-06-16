using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculation.Test
{
    [CollectionDefinition("Employee")]
    public class FixtureStringCollection : ICollectionFixture<FixtureString>
    {
    }
}
