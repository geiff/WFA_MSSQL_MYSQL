namespace RegisterOfImmunizedCows.View
{
    using System;

    /// <summary>
    /// Check whether they are correct data
    /// </summary>
    public class ValidatorData
    {
        //Checks whether there are empty blanks in the input form
        public static bool IsEmptyForm(string numberOnCow, string location, string immunization,
            string description, string date)
        {

            if (numberOnCow == String.Empty || location == String.Empty || immunization == String.Empty ||
                description == String.Empty || date == String.Empty)
            {
                return true;
            }

            return false;
        }

        //Returns text message to complete the relevant empty field.
        public static string MessageString(string numberOnCow, string location, string immunization,
            string description, string date)
        {
            if (numberOnCow == String.Empty)
            {
                return "Моля, попълнете маркировъчен номер на крава!";
            }
            else if (location == String.Empty)
            {
                return "Моля въведете населено място на крава";
            }
            else if (immunization == String.Empty)
            {
                return "Моля въведете имунизация";
            }
            else if (description == String.Empty)
            {
                return "Моля въведете описание за имунизацията";
            }

            return "Моля въведете дата";
        }
    }
}