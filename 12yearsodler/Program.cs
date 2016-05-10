using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12yearsodler
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("jo","shmo",Convert.ToDateTime("11/10/1985"));
            Console.WriteLine(person.FirstName+" "+person.LastName+" is "+person.age+" right now!");
            person++;
            Console.WriteLine(person.FirstName + " " + person.LastName + " will be " + person.age + " 12 years from now!");
            Console.ReadKey();
            
        }
    }
}
