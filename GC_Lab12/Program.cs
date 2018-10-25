using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>
            {
                new Student("Charlie", "123 East Road", "Basket Weaving", 3, 5000),
                new Staff("Dolores", "Chicken Street", "Ministry of Silly Walks", 50000)
            };

            for (int i = 0; i < People.Count; i++)
            {
                People[i].ToString();
            }
            Console.ReadLine();
        }
    }
}
