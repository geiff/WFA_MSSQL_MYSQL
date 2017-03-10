namespace RegisterOfImmunizedCows.Controller
{
    using System;
    using System.Linq;
    using Contract;

    /// <summary>
    /// Class contact database entries in the database, delete and update
    /// </summary>
    public class RegisterData : IRegisterData
    {
        private readonly RegisterOfImmunizedCowsEntities db;
        private readonly cow cowInput;
        private readonly immunization immunizationInput;
        private readonly register registerInput;

        public RegisterData()
        {
            db = new RegisterOfImmunizedCowsEntities();
            cowInput = new cow();
            immunizationInput = new immunization();
            registerInput = new register();
        }

        public string NumberRegister
        {
            get
            {
                return db.registers.Max(v => v.Id).ToString();
            }
        }

        //Save a cow database
        public void SaveCow(int numberOnCow, string location)
        {
            var cowSearch = db.cows.Any(c => c.NumberOnCow == numberOnCow &&
                                             c.PopulatedPlace == location);

            if (!cowSearch)
            {
                cowInput.NumberOnCow = numberOnCow;
                cowInput.PopulatedPlace = location;

                db.cows.Add(cowInput);
                db.SaveChanges();
            }
            else
            {
                cowInput.Id = db.cows.Where(c => c.NumberOnCow == numberOnCow &&
                                             c.PopulatedPlace == location).Select(c => c.Id).First();
            }
        }

        //Recording immunization in database
        public void SaveImmunization(string name, string description)
        {
            var immunizationSearch = db.immunizations.Any(i => i.Name == name);

            if (!immunizationSearch)
            {
                immunizationInput.Name = name;
                immunizationInput.Description = description;

                db.immunizations.Add(immunizationInput);
                db.SaveChanges();
            }
            else
            {
                immunizationInput.Id = db.immunizations.Where(i => i.Name == name).Select(i => i.Id).First();
            }
        }

        //Recording made registration for immunization
        public void RegisterSave(DateTime date)
        {
            registerInput.CowID = cowInput.Id;
            registerInput.ImmunisationID = immunizationInput.Id;
            registerInput.DateOnImmunization = date;

            db.registers.Add(registerInput);
            db.SaveChanges();
        }

        //Updating the data in the database
        public void UpdateData(int id, int numberCow, string location, string immunizationName, string description, DateTime date)
        {
            var registration = db.registers.Find(id);

            int idCow = (int)registration.CowID;
            var cow = db.cows.Find(idCow);
            cow.NumberOnCow = numberCow;
            cow.PopulatedPlace = location;

            int idImmunization = (int)registration.ImmunisationID;
            var immunizaton = db.immunizations.Find(idImmunization);
            immunizaton.Name = immunizationName;
            immunizaton.Description = description;

            registration.DateOnImmunization = date;

            db.SaveChanges();
        }

        //Delete data from database
        public void DeleteData(int id)
        {
            var registration = db.registers.Find(id);
            db.registers.Remove(registration);
            db.SaveChanges();
        }
    }
}