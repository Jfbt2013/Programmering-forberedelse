using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDBSetup
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Welcome, choose option 1 or 2");
            int userInput = int.Parse(Console.ReadLine());

            if(userInput == 1)
            {
                List<PersonModel> list = SqliteDataAccess.LoadPeople();

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i].name);
                }
            }

            if (userInput == 2)
            {
                Console.WriteLine("Enter name: ");
                string userName = Console.ReadLine();

                Console.WriteLine("Enter age: ");
                int userAge = int.Parse(Console.ReadLine());

                PersonModel person = new PersonModel();//userName, userAge);

                person.name = userName;
                person.age = userAge;

                SqliteDataAccess.SavePerson(person);
            }
            Console.ReadKey();
        }
    }
}
