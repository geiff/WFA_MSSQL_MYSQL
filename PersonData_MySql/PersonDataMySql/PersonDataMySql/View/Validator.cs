using System;
using System.Text.RegularExpressions;
/// <summary>
/// Validation of input data
/// </summary>
namespace PersonDataMySql.View
{
    public class Validator
    {
        //If there is an empty field invokes the method to return the message in the box
        //If all fields are filled verify that are filled with true input.
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

                if (!PhonelValidation(phoneNumber))
                {
                    return "Invalid phone number";
                }

                if (!NameValidation(name))
                {
                    return "Invalid name";
                }
            }

            return "true";
        }

        //Checks if there are empty fields
        public static bool ValidationEmptyForm(string name, string date, string email, string phoneNumber)
        {

            if (name == String.Empty || date == String.Empty || email == String.Empty || phoneNumber == String.Empty)
            {
                return true;
            }

            return false;
        }

        //Returns text message to fill the empty field.
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

        //Checks if the email field contains a valid email address
        public static bool EmailValidation(string email)
        {
            var pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";
            var mathces = Regex.Matches(email, pattern);
            if (mathces.Count == 0)
            {
                return false;
            }

            return true;
        }

        //Checks that the phone number field contains only numbers and can start with a + or without +.
        public static bool PhonelValidation(string phoneNumber)
        {
            var pattern = @"^\+?[0-9]+$";
            var mathces = Regex.Matches(phoneNumber, pattern);
            if (mathces.Count == 0)
            {
                return false;
            }

            return true;
        }

        //Check whether the name field contains only letters and consist of two words separated by a space
        public static bool NameValidation(string name)
        {
            var pattern = @"^[A-Za-z]+\s[A-Za-z]+$";
            var mathces = Regex.Matches(name, pattern);
            if (mathces.Count == 0)
            {
                return false;
            }

            return true;
        }
    }
}