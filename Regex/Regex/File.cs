using System.Collections.Generic;
using System.IO;

namespace MatchPerson
{
    public class File
    {
        /// <summary>
        /// Reading the data from the file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static List<string> Read(string filePath)
        {
            List<string> lines = new List<string>();

            using (StreamReader fileRead = new StreamReader(filePath))
            {
                while (!fileRead.EndOfStream)
                {
                    lines.Add(fileRead.ReadLine());
                }
            }

            return lines;
        }

        public static void SavePerson(List<Person> person, string pathFile)
        {
            using (StreamWriter file = new StreamWriter(pathFile))
            {
                foreach (var p in person)
                {

                    file.WriteLine(p.ToString());
                }
            }
        }

        public static void SaveString(List<string> str, string pathFile)
        {
            using (StreamWriter file = new StreamWriter(pathFile))
            {
                foreach (var p in str)
                {
                    file.WriteLine(p);
                }
            }
        }
    }
}