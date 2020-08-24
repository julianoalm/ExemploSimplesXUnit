using MyClasses.PersonClasses;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyClassesTest
{
    public class PersonManagerTest
    {
        [Fact]
        [Trait("Owner", "Juliano")]
        public void CreatePerson_OfTypeEmployeeTest()
        {
            PersonManager perMgr = new PersonManager();
            Person per;

            per = perMgr.CreatePerson("Juliano","Alves",false);

            Assert.IsType<Employee>(per);
        }

        [Fact]
        [Trait("Owner", "Juliano")]
        public void DoEmployeeExistsTest()
        {
            Supervisor super = new Supervisor();
            super.Employess = new List<Employee>();
            super.Employess.Add(new Employee()
            {
                FirstName = "Juliano",
                LastName = "Alves"
            });

            Assert.True(super.Employess.Count > 0);
        }
    }
}
