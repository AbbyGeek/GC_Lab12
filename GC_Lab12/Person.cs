using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab12
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
                //Console.WriteLine($"\nName: {Name}");
                //Console.WriteLine($"Address: {Address}");
            return $"Name: {Name}\nAddress: {Address}\n";
        }
        public int CompareTo(Person other)
        {
            return this.Name.CompareTo(other.Name);
        }

    }
}
