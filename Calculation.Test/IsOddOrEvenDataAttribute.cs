using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit.Sdk;

namespace Calculation.Test
{
    public class IsOddOrEvenDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 1, true };
          //  yield return new object[] { 3, false };

            //var readAllLines = System.IO.File.ReadAllLines("IsOddOrEvenTestData.txt");
            //return readAllLines.Select(x =>
            //{
            //    var splitLine = x.Split(',');
            //    return new object[] {int.Parse(splitLine[0]), bool.Parse(splitLine[1])};
            //});
        }
    }
}
