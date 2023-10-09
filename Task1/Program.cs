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
        }
        
    }
}