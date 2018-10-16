using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        // This program will recognize invalid inputs using regular expressions
        static void Main(string[] args)
        {
            // The four methods being validated
            ValidateName();
            ValidateEmail();
            ValidatePhonenumber();
            ValidateDate();
        }
        static void ValidateName()
        {
            Console.WriteLine("Please enter a valid Name:");
            string name = Console.ReadLine();
            // regular expression for validating a name beginning with a capital letter
            Match match = Regex.Match(name, @"^[A-Z]{1}[a-z]{2,30}$");

            if (match.Success)
            {
                Console.WriteLine("Name is valid! Hit enter to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I'm sorry, that name is not valid. Please enter a valid name. It must begin with a capital letter.");
                Console.ReadLine();
            }
        }

        static void ValidateEmail()
        {
            Console.WriteLine("Please enter a valid email address:");
            string email = Console.ReadLine();
            /* regular expression for validating an email address 
             * {combination of alphanumeric characters, with a length between 5-30, and there are no special characters}
             * @
             * {combination of alphanumeric characters, with a length between 5-10, and there are no special characters}
             * .
             * {domain can be combination of alphanumeric characters, with a length of 2 or 3}
             */
            Match match = Regex.Match(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                     @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                     RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

            if (match.Success)
            {
                Console.WriteLine("Email address is valid! Hit enter to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I'm sorry, that email address is not valid. Please enter a valid email address.");
                Console.ReadLine();
            }

        }
        static void ValidatePhonenumber()
        {
            Console.WriteLine("Please enter a valid phone number including your 3-digit area code (### - ### - ####):");
            string phonenumber = Console.ReadLine();
            // regular expression for validating a phone number {area code of 3 digits} - {3 digits} - {4 digits}
            Match match = Regex.Match(phonenumber, @"^(1-)?\d{3}-\d{3}-\d{4}$");

            if (match.Success)
            {
                Console.WriteLine("Phone number is valid! Hit enter to continue.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I'm sorry, that phone number is not valid. Please enter a valid phone number including your 3 digit area code (### - ### - ####).");
                Console.ReadLine();
            }

        }

        static void ValidateDate()
        {
            Console.WriteLine("Please enter a valid date (dd/mm/yyyy):");
            string date = Console.ReadLine();
            // regular expression for validating a date (dd/mm/yyyy)
            Match match = Regex.Match(date, @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");

            if (match.Success)
            {
                Console.WriteLine("Date is valid!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I'm sorry, that date is not valid. Please enter a valid date (dd/mm/yyyy).");
                Console.ReadLine();
            }
        }
    }
}