using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab12
{
    class Student : Person, IComparable<Student>
    {
        //public string Name { get; set; }
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            //Name = name;
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            //base.ToString();
            //Console.WriteLine($"Program: {Program}");
            //Console.WriteLine($"Year: {Year}");
            //Console.WriteLine($"Fee: {Fee}");
            return base.ToString() + $"Program: {Program}\nYear: {Year}\nFee: {Fee}\n";
        }


        public int CompareTo(Student other)
        {
            // Alphabetic sort [A to Z]
            return this.Name.CompareTo(other.Name);
        }

    }

    class ArchivedStudent : Student, IComparable<ArchivedStudent>
    {
        public double FinalScore { set; get; }

        public ArchivedStudent(double finalScore, string name, string address, string program, int year, double fee) : base(name, address, program, year, fee)
        {
            FinalScore = finalScore;
        }

        public override string ToString()
        {
           // base.ToString();
            // Console.WriteLine($"Final Score: {FinalScore}");
            return base.ToString() + $"Final Score: {FinalScore}\n";
        }

        public int CompareTo(ArchivedStudent other)
        {
            return this.Name.CompareTo(other.Name);
        }

      

        //    // extend student class with the class Archived Student. Store FinalScore. (DONE)
        //    //ArchivedStudent implements the Comparable interface so students can be sorted by last name (DONE?)
        //    //OVerride the ToString(bad method name choice) method from the Object class. Each class will use ToString to print values of its properties. (DONE?)
        //    //use a List to store student objecs. Should sort and then print. 
        //    //allow user to add students and Archived students. Validate name and make sure score is between 0 and 100.
        //
    }
}
