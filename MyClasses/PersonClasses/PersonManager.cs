using System;
using System.Collections.Generic;
using System.Text;

namespace MyClasses.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {
            Person ret = null;

            if (!string.IsNullOrEmpty(first))
            {
                if (isSupervisor)
                {
                    ret = new Supervisor();
                }
                else
                {
                    ret = new Employee();
                }

                ret.FirstName = first;
                ret.LastName = last;
            }

            return ret;
        }

        public List<Person> GetPeople()
        {
            List<Person> listPeople = new List<Person>();

            listPeople.Add(new Person() { FirstName = "Juliano", LastName = "Alves" });
            listPeople.Add(new Person() { FirstName = "Davi", LastName = "Lemos" });
            listPeople.Add(new Person() { FirstName = "Regilene", LastName = "Aurinivia" });

            return listPeople;
        }
    }
}
