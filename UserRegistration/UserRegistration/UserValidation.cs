using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class UserValidation
    {
        public void ValidateFirstName()
        {
            string FirstNamePattern = @"^[A-Z][a-z]{2,}$";
            Regex regexObject = new Regex(FirstNamePattern);
            Console.WriteLine("Enter First Name: ");
            string  firstName = Console.ReadLine();
            if (regexObject.IsMatch(firstName))
                Console.WriteLine("First name is valid");
            else
                Console.WriteLine("Invalid FirstName");
        }
        public void ValidateLastName()
        {
            string LastNamePattern = @"^[A-Z][a-z]{2,}$";
            Regex regexObject = new Regex(LastNamePattern);
            Console.WriteLine("Enter Last Name:  ");
            string userInput = Console.ReadLine();
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("Last name is valid");
            else
                Console.WriteLine("Invalid last name");
        }
    }
}
