using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab12
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public virtual void ToString()
        {
                Console.WriteLine($"\nName: {Name}");
                Console.WriteLine($"Address: {Address}");
        }

    }
}
