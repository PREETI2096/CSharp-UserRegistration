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
        public void ValidateEmail()
        {
            string EmailPattern = @"^[a-z]+([_.-]?[a - zA - Z0 - 9])*[@][a - zA - Z0 - 9]+([.][a - z]{2,3}){1,2}$";
            Regex regexObject = new Regex(EmailPattern);
            Console.WriteLine("enter email : ");
            string userInput = Console.ReadLine();
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("email is valid");
            else
                Console.WriteLine("invalid email");
        }
    }
}
