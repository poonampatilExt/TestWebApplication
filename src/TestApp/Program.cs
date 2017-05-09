using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApplication.Controllers;
using Xunit;

namespace TestApp
{
    public class Program
    {
        [Fact]
        public void TestGetMethod()
        {
            ValuesController valuesController = new ValuesController();
            IEnumerable<string> result = valuesController.Get();

            Assert.Equal(result.Count(), 2);
        }
    }
}
