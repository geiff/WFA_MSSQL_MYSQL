using System.Text.RegularExpressions;

namespace MatchPerson
{
    public class Validator
    {
        //Validating the phone number
        public static bool PhonelValidation(string phoneNumber)
        {
            var pattern = @"\b\+?[0-9]{5,10}\b";
            var mathces = Regex.Matches(phoneNumber, pattern);
            if (mathces.Count == 0)
            {
                return false;
            }

            return true;
        }

        //Validation of three names
        public static bool NameValidation(string name)
        {
            var pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\s[A-Z][a-z]+\b";
            var mathces = Regex.Matches(name, pattern);
            if (mathces.Count == 0)
            {
                return false;
            }

            return true;
        }

        //Validating province
        public static bool Region(string region)
        {
            var pattern = @"\b[A-Z][a-z]+\b";
            var mathces = Regex.Matches(region, pattern);
            if (mathces.Count == 0)
            {
                return false;
            }

            return true;
        }

        //Validation of town
        public static bool City(string city)
        {
            var pattern = @"\b[A-Z][a-z]+\b";
            var mathces = Regex.Matches(city, pattern);
            if (mathces.Count == 0)
            {
                return false;
            }

            return true;
        }
    }
}