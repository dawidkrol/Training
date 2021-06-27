using extensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace extens.Tests
{
    public class Tests
    {
        [Theory]
        [InlineData("Dawid","D")]
        [InlineData("Anna","A")]
        [InlineData("Ola","O")]
        public static void FirstChar_SimpleTest(string value,string expected)
        {
            var actual = value.FirstChar();

            Assert.Equal(expected, actual);
        }
    }
}
