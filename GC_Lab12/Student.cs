using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab12
{
    class Student : Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override void ToString()
        {
            base.ToString();
            Console.WriteLine($"Program: {Program}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Fee: {Fee}");
        }

    }
}
