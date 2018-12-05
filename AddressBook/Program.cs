using System;
using System.Collections.Generic;

namespace AddressBook
{
    partial class Program
    {
    
        static List<Person> people = new List<Person>();
        static IPersonRepository repository = new PersonRepository();
        static  IPersonValidator validator = new PersonValidator();
        static IPersonService personService = new PersonService(repository,validator);

        static void Main(string[] args)
        {
          

            while (true)
            {
                try
                {
                    PrintMenu();
                    var command = Console.ReadLine();

                    switch (command)
                    {
                        case "1":
                            PrintAll();
                            break;
                        case "2":
                            AddPerson();
                            break;
                        case "3":
                            Search();

                            break;
                        case "0":
                            ExitApp();
                            break;
                        default:
                            break;
                    }
                }
                catch(Exception exc)
                {
                    PrintException(exc);
                }
            }
        }

        private static void ExitApp()
        {
            Console.WriteLine("Exiting....");
            Environment.Exit(0);
        }

        private static void Search()
        {
            Console.Write("Search pattern: ");
            string pattern = Console.ReadLine();
            Console.WriteLine("Searching");

            
            foreach (var p in personService.Search(pattern))
                Console.WriteLine($"{p}");
        }

        private static void PrintAll()
        {
            Console.WriteLine("Whole book");

            foreach (var p in personService.GetAll())
                Console.WriteLine($"{p}");
        }

        private static void AddPerson()
        {
            Person person =  new Person();
        
            Console.WriteLine("Adding....");
            Console.Write("First name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Middle name: ");
            person.MiddleName = Console.ReadLine();
            Console.Write("Last name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Phone: ");
            person.Phone= Console.ReadLine();

            personService.Add(person);
        }

        private static void PrintException(Exception exc)
        {
            var c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ERROR!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ERROR!");
            Console.ForegroundColor = c;
        }


        private static void PrintMenu()
        {
            Console.WriteLine("======================");
            Console.WriteLine("*********MENU*********");
            Console.WriteLine("1. Show ALL");
            Console.WriteLine("2. Add");
            Console.WriteLine("3. Search By Name");
            Console.WriteLine("0. Exit");
            Console.WriteLine("!!!!TODO Edit and Delete");
            Console.WriteLine("======================");
        }
    }
}
