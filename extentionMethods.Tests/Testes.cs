using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace extentionMethods.Tests
{
    public static class Testes
    {
        [Theory]
        [InlineData("Dawid",'D')]
        [InlineData("Anna",'A')]
        [InlineData("Ola",'O')]
        public static void FirstChar_SimpleTest(string a,char expect)
        {

        }
    }
}
