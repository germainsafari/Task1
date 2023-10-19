using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    
    public class Person
    {
        public PostalAddress PostalAddress { get; set; }    
        public string FirstName { get; private set; }
        public string FamilyName { get; private set; }

        public void IntroduceYourself () 
        {
            Console.WriteLine("My name is"+ " " + FirstName + " " + FamilyName);
        }
        public void setData(string fName, string lName)
        {
            this.FirstName = fName; 
            this.FamilyName = lName;

        }
        public string FullPostalAdress;
        
    }
    
}
