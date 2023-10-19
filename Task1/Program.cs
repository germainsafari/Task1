using System;
using Task1;

namespace Task1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.setData("German", "safari");
            person.IntroduceYourself();
            // Console.WriteLine(person.FirstName);
            PostalAddress address = new PostalAddress
            {
                StreetName = "SomeStreet",
                HouseNumber = 11,
                ApartmentNumber = 1,
                City = "SomeCity",
                PostCode = "12345",
                Country = "SomeCountry"
            };

            List<Person> addressBook = new List<Person>();
            Console.WriteLine("Enter the number of contacts");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter first name");
                string fName = Console.ReadLine();

                Console.WriteLine("Enter last name");
                string lName = Console.ReadLine();
            }

            for (int i = 0; i < adressBook.Count;i++)
            {
                Console.WriteLine($"{i + 1}. {addressBook[i].FirstName} {addressBook[i].LastName}");
            }

        }
        
    }
}