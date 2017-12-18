using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        class Student : Person
        {
            static void Main(string[] args)
            {
                Person p = new Person { firstName = "Ivan", lastName = "Nosenko" };
                string fullname = p.ToString();
                int age = GetAge();
                number = "1714044";
                string studentNumber = GetNumber();
                Address a = new Address { country = "Bulgaria,", city = "Varna,", street = "Oborishte", address = "13A" };
                string fullAddress = a.ToString();
                List<int> grades = Scores();
                double average = grades.Average();
                bool aboutstudent = true;
                while (aboutstudent)
                {
                    Console.WriteLine(new string(' ', 10));
                    Console.WriteLine("Press any key from 1 to 5 to select a specific action: ");
                    Console.WriteLine(new string(' ', 10));
                    Console.WriteLine("1 - Student's average score");
                    Console.WriteLine("2 - Student's city");
                    Console.WriteLine("3 - Student's full Address");
                    Console.WriteLine("4 - Student's full information");
                    Console.WriteLine("5 - Exit");
                    Console.WriteLine(new string(' ', 10));

                    try
                    {
                        int choice = int.Parse(Console.ReadLine());
                        Console.WriteLine(new string(' ', 10));
                        switch (choice)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Student {0} score: {1}", fullname, average);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Student {0} living in {1}", fullname, a.city);
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Student {0} Address: {1}", fullname, fullAddress);
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine(new string(' ', 10));
                                    Console.WriteLine("STUDENT PERSONAL DATA: ");
                                    Console.WriteLine(new string(' ', 10));
                                    Console.WriteLine("Student {0}, {1} years old", fullname, age);
                                    Console.WriteLine("His student number is {0}", studentNumber );
                                    Console.WriteLine(new string(' ', 10));
                                    Console.WriteLine("FULL ADDRESS: ");
                                    Console.WriteLine(new string(' ', 10));
                                    Console.WriteLine("{0}", fullAddress);
                                    Console.WriteLine(new string(' ', 10));
                                    Console.WriteLine("GRADING BY SUBJECTS: ");
                                    Console.WriteLine(new string(' ', 10));
                                    Console.WriteLine("Mathematic for Computing - 4;");
                                    Console.WriteLine("Computing and Society - 6;");
                                    Console.WriteLine("Computer Architecture - 5;");
                                    Console.WriteLine("Principle of Programming - 4;");
                                    Console.WriteLine("Data Structures and Algorithms - 4;");
                                    Console.WriteLine("English - 5;");
                                    Console.WriteLine(new string(' ', 10));
                                    Console.WriteLine("Average score for 6 subjects is: {0}", average);
                                    Console.WriteLine(new string(' ', 10));
                                    break;
                                }
                            case 5:
                                {
                                    aboutstudent = false;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Invalid action, please enter the CORRECT action (from 1 to 5)");
                                    break;
                                }
                        }
                    }
                    catch { }
                    Console.WriteLine(new string(' ', 10));
                    Console.WriteLine("To go back please press any Keys..");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            private static string number { get; set; }
            private static string GetNumber()
            {
                return string.Format("{0}", number);
            }
            
            private static int GetAge()
            {
                int age = 18;
                return age;
            }

            private static List<int> Scores()
            {
                List<int> scores = new List<int> { 4, 6, 5, 4, 4, 5 };
                return scores;
            }
        }


        class Address
        {
            public string address { get; set; }
            public string street { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public override string ToString()
            {
                return country + " " + city + " " + street + " " + address;
            }
        }

        class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public override string ToString()
            {
                return firstName + " " + lastName;
            }
        }
    }
}

