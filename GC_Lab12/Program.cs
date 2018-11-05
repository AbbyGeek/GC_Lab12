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
            List<Person> People = new List<Person>();
            //Student student = new Student("Zteve", "123 home rd", "Pig wrestling", 3, 15000);
         

            People.Add(new Student("Steve", "123 home rd", "Pig wrestling", 3, 15000));
            People.Add(new Student("Claudia", "123 Road st.", "Basket Weaving", 4, 20000));
            People.Add(new Student("Samuel", "1919 Grizzly Lane", "Manufacturing", 1, 10000));
            People.Add(new Student("Anne", "Unknown", "Unknown", 0, 0));
            People.Add(new ArchivedStudent(98, "Jack", "Unknown", "Unknown", 0, 0));
            People.Add(new ArchivedStudent(67, "Jill", "Unknown", "Unknown", 0, 0));
            People.Add(new ArchivedStudent(83, "Arthur", "Unknown", "Unknown", 0, 0));
            People.Add(new ArchivedStudent(91, "Jose", "Unknown", "Unknown", 0, 0));
            People.Add(new ArchivedStudent(72, "Barry", "Unknown", "Unknown", 0, 0));

            while (true)
            {
                Console.WriteLine("1) List students sorted by name");
                Console.WriteLine("2) Add student to list");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    People.Sort();

                    for (int i = 0; i < People.Count; i++)
                    {
                        Console.WriteLine(People[i].ToString());
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == "2")
                {
                    AddStudent.addStudent(People);
                }
                else { Console.Clear(); Console.WriteLine("Invalid entry");  continue; }
            }
            
        }
    }
}
