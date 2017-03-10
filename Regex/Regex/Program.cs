using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchPerson
{
    class Program
    {
        static void Main()
        {
            List<string> result = File.Read("../../../InputData.txt");
            List<Person> validList = new List<Person>();
            List<string> invalidList = new List<string>();
            foreach (var res in result)
            {
                if (ParsePerson(res))
                {
                    string[] str = res.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    Person person = new Person();
                    person.IdentificationNumber = int.Parse(str[0]);
                    person.PhoneNumber = str[1];
                    person.FullName = str[2];
                    person.BirthDate = DateTime.Parse(str[3]);
                    person.Region = str[4];
                    person.City = str[5];


                    validList.Add(person);
                }
                else
                {
                    invalidList.Add(res);

                }
            }

            File.SavePerson(validList, @"../../../OutputPersonValid.txt");
            File.SaveString(invalidList, @"../../../OutputPersonInvalid.txt");

            var validData = validList.Select(x => x).OrderBy(x => x.Region).ThenBy(x => x.City).GroupBy(x => x.Region);
            Console.WriteLine("Valid data are:");
            foreach (var data in validData)
            {
                data.ToList().ForEach(vd => Console.WriteLine(vd.ToString()));
            }
        }

        public static bool ParsePerson(string str)
        {
            string[] spl = str.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (Validator.NameValidation(spl[2]) && Validator.PhonelValidation(spl[1]) && Validator.Region(spl[4]) && Validator.City(spl[5]))
            {
                return true;
            }

            return false;

        }
    }
}