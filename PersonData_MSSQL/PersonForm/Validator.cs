using System;
using System.Text.RegularExpressions;

namespace PersonForm
{
    public class Validator
    {
        public static string Validation(string name, string date, string email, string phoneNumber)
        {
            if (ValidationEmptyForm(name, date, email, phoneNumber))
            {
               return ValidationString(name, date, email, phoneNumber);
            }
            else
            {
                if (!EmailValidation(email))
                {
                    return "Invalid email address";
                }               
            }

            return "true";
        }

        public static bool ValidationEmptyForm(string name, string date, string email, string phoneNumber)
        {

            if (name == String.Empty || date == String.Empty || email == String.Empty || phoneNumber == String.Empty)
            {
                return true;
            }

            return false;
        }

        public static string ValidationString(string name, string date, string email, string phoneNumber)
        {
            if (name == String.Empty)
            {
                return "Please input name";
            }
            else if (date == String.Empty)
            {
                return "Please input date";
            }
            else if (email == String.Empty)
            {
                return "Please input email";
            }

            return "Please input phone number";
        }

        public static bool EmailValidation(string email)
        {
            var text = email;

            var pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
            var mathces = Regex.Matches(text, pattern);
            if (mathces.Count == 0)
            {
                return false;
            }

            return true;
        }
    }
}