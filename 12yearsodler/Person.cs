using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12yearsodler
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int age;

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.age = getAge(dateOfBirth);

        }
        public int getAge(DateTime dob)
        {
            int age = 0;
            DateTime today = DateTime.Today;

            age = today.Year - dob.Year;
            if (dob.AddYears(age) > today)
            {
                age--;
            }
            return age;
        }
        public static Person operator ++(Person person )
            {
            person.age = person.age + 12;
            return person;
            }
    }
}
