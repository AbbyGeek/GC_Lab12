using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GC_Lab12
{
    class AddStudent
    {
        public static void addStudent(List<Person> personList)
        {
            while (true)
            {
                try
                {
                    //Console.Clear(); 
                    Console.WriteLine("1) Add student that is currently enrolled\n2) Add a Student that is archived\n3) Quit to main menu");
                    string choice = Console.ReadLine();
                    if (choice == "3" || choice == "q") { break; }
                    if (choice == "1" || choice == "2")
                    {
                        Console.WriteLine("Please enter the following information.");
                        
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                            
                        

                        Console.Write("Address: ");
                        string address = Console.ReadLine();
                        Console.Write("Program: ");
                        string program = Console.ReadLine();
                        Console.Write("Year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Fee: ");
                        double fee = double.Parse(Console.ReadLine());
                        
                        if (choice == "2")
                        { while (true)
                            {
                                Console.Write("Final Score: ");
                                int score = int.Parse(Console.ReadLine());

                                if (score >= 0 && score <= 100)
                                {

                                    personList.Add(new ArchivedStudent(score, name, address, program, year, fee));
                                    Console.WriteLine($"{name} has been added to the list.");
                                    break;
                                }
                                else { Console.WriteLine("Score is not within normal limits. Try agian."); continue; }
                            }
                        }
                        else if (choice == "1")
                        {
                            
                                personList.Add(new Student(name, address, program, year, fee));
                                Console.WriteLine($"{name} has been added to the list");
                            
                        }
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Entry. Please try again");
                        continue; 
                    }

                }
                catch { Console.WriteLine("Invalid Entry. Please try again"); Thread.Sleep(2000); Console.Clear(); continue;  }
            }
        }
    }
}