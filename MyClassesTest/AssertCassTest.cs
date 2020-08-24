using MyClasses;
using MyClasses.PersonClasses;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyClassesTest
{
    public class AssertCassTest
    {
        #region AreEqual - AreNotEqual

        [Fact]
        [Trait("Owner", "Juliano")]
        public void AreEqualTest()
        {
            string str1 = "Juliano";
            string str2 = "Juliano";

            Assert.Equal(str1, str2);
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        public void AreEqualTest_CaseSensitive()
        {
            string str1 = "juliano";
            string str2 = "JULIANO";

            Assert.Equal(str1, str2, ignoreCase: true);
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        public void AreNotEqualTest()
        {
            string str1 = "Juliano";
            string str2 = "juliano";

            Assert.NotEqual(str1, str2);
        }

        #endregion

        #region AreSame - AreNotSame

        [Fact]
        [Trait("Owner", "Juliano")]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;

            Assert.Same(x, y);
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = null;

            Assert.NotSame(x, y);
        }

        #endregion

        #region IsInstanceOfType Test

        [Fact]
        [Trait("Owner", "Juliano")]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("Juliano", "Alves", true);

            Assert.IsType<Supervisor>(per);
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        public void IsNullTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("", "Alves", true);

            Assert.Null(per);
        }

        #endregion
    }
}
