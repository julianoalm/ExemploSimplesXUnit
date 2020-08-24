using MyClasses.PersonClasses;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyClassesTest
{
    public class CollectionAssertClassTest
    {
        [Fact]
        [Trait("Owner", "Juliano")]
        public void AreCollectionEqualFailsBecauseNoComparerTest()
        {
            PersonManager per = new PersonManager();
            List<Person> listPeopleExpected = new List<Person>();
            List<Person> listPeopleActual = new List<Person>();

            listPeopleExpected.Add(new Person() { FirstName = "Juliano", LastName = "Alves" });
            listPeopleExpected.Add(new Person() { FirstName = "Davi", LastName = "Lemos" });
            listPeopleExpected.Add(new Person() { FirstName = "Regilene", LastName = "Aurinivia" });

            // You shall not pass!
            listPeopleActual = per.GetPeople();

            Assert.NotEqual(listPeopleActual, listPeopleExpected);
        }

        //[Fact]
        //[Trait("Owner", "Juliano")]
        //public void AreCollectionEqualComparerTest()
        //{
        //    PersonManager per = new PersonManager();
        //    List<Person> listPeopleExpected = new List<Person>();
        //    List<Person> listPeopleActual = new List<Person>();

        //    listPeopleExpected.Add(new Person() { FirstName = "Juliano", LastName = "Alves" });
        //    listPeopleExpected.Add(new Person() { FirstName = "Davi", LastName = "Lemos" });
        //    listPeopleExpected.Add(new Person() { FirstName = "Regilene", LastName = "Aurinivia" });

        //    // You shall not pass!
        //    listPeopleActual = per.GetPeople();

        //    Assert.Equal(listPeopleExpected, listPeopleActual,
        //        Comparer<Person>.Create((x,y) => 
        //            (x.FirstName == y.FirstName && x.LastName == y.LastName) ? 0 : 1));
        //}
    }
}
