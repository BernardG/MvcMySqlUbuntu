using System;
using System.Collections.Generic;

namespace MvcMySqlUbuntu.Models
{
    public class SeedSomeData
    {
        public static void InsertPersons()
        {
            var person_0 = new Person
                {
                    FirstName = "Alfred",
                    LastName = "Schmoll",
                    BirthDate = Convert.ToDateTime("12/03/1960")
                };

            person_0.Phones = new List<Phone>();
            var phone0 = new Phone {Type = "Home", Number = " 917 33 8745"};
            person_0.Phones.Add(phone0);
            var phone1 = new Phone {Type = "Work", Number = "315 67 8954"};
            person_0.Phones.Add(phone1);

            var person_1 = new Person
                {
                    FirstName = "Billy",
                    LastName = "The Kid",
                    BirthDate = Convert.ToDateTime("27/02/1865")
                };

            var person_2 = new Person
                {
                    FirstName = "Bob",
                    LastName = "Hoover",
                    BirthDate = Convert.ToDateTime("10/08/1925")
                };

            person_2.Phones = new List<Phone>();
            var phone2 = new Phone {Type = "Mobile", Number = " 888 33 8745"};
            person_2.Phones.Add(phone2);
            var phone3 = new Phone {Type = "Office", Number = "615 97 8954"};
            person_2.Phones.Add(phone3);

            using (var context = new MyContext())
            {
                try
                {
                    context.Persons.Add(person_0);
                    context.Persons.Add(person_1);
                    context.Persons.Add(person_2);
                    context.SaveChanges();
                    Console.WriteLine("Persons Saved!");
                    Console.WriteLine("");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.InnerException);
                }
            }
        }
    }
}