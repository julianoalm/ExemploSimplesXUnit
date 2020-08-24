using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace MyClassesTest
{
    public class StringAssertClassTest
    {
        [Fact]
        [Trait("Owner", "Juliano")]
        public void ContainsTest()
        {
            string str1 = "Juliano Alves";
            string str2 = "Alves";

            Assert.Contains(str2, str1);
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        public void StartsWithTest()
        {
            string str1 = "Todos Caixa Alta";
            string str2 = "Todos Caixa";

            Assert.Contains(str2, str1);
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        public void IsAllLowerCaseTest()
        {
            Regex reg = new Regex(@"^([^A-Z])+$");

            Assert.Matches(reg, "todos caixa");
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        public void IsNotAllLowerCaseTest()
        {
            Regex reg = new Regex(@"^([^A-Z])+$");

            Assert.DoesNotMatch(reg, "Todos caixa");
        }
    }
}
