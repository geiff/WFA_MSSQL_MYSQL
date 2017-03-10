namespace RegisterOfImmunizedCows.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class contact database to search for data in the database
    /// </summary>
    public class SearchData
    {
        private readonly RegisterOfImmunizedCowsEntities db;

        public SearchData()
        {
            db = new RegisterOfImmunizedCowsEntities();
        }

        //Method of data search by date of registration
        public string SearchingDataOnDate(DateTime date)
        {
            string resultData = null;

            var register = db.registers.Where(r => r.DateOnImmunization == date).Select(r => new
            {
                r.immunization.Name,
                r.immunization.Description,
                r.cow.NumberOnCow,
                r.cow.PopulatedPlace
            });

            int count = 1;
            foreach (var registration in register)
            {
                resultData += $"{count}. Име на имунизция: {registration.Name} Описание: {registration.Description} " +
                                    $"Номер на крава: {registration.NumberOnCow} Местонахождение: {registration.PopulatedPlace}\r\n";
                count++;
            }

            return resultData;
        }

        //Search method of data registration number
        public List<string> SearchingDataOnNumberRegistur(int number)
        {
            List<string> resulData = new List<string>();

            var register = db.registers.Where(r => r.Id == number).Select(r => new
            {
                r.cow.NumberOnCow,
                r.cow.PopulatedPlace,
                r.immunization.Name,
                r.immunization.Description,
                r.DateOnImmunization
            });

            resulData.Add(register.First().NumberOnCow.ToString());
            resulData.Add(register.First().PopulatedPlace);
            resulData.Add(register.First().Name);
            resulData.Add(register.First().Description);
            resulData.Add(register.First().DateOnImmunization.Day + "." + register.First().DateOnImmunization.Month + "." +
                         register.First().DateOnImmunization.Year);

            return resulData;
        }

        //Method of search data Marking number of cow
        public List<string> SearchingDataByNumberOnCow(int number)
        {
            List<string> resultData = new List<string>();
            var cow = db.cows.Where(c => c.NumberOnCow == number).Select(c => new
            {
                c.NumberOnCow,
                c.PopulatedPlace,
                c.Id
            });

            resultData.Add(cow.First().NumberOnCow.ToString());
            resultData.Add(cow.First().PopulatedPlace);
            resultData.Add(cow.First().Id.ToString());
            return resultData;
        }
    }
}