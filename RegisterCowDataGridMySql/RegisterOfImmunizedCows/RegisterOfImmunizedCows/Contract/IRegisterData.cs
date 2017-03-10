namespace RegisterOfImmunizedCows.Contract
{
    using System;

    interface IRegisterData
    {
        string NumberRegister { get; }
        void SaveCow(int numberOnCow, string location);
        void SaveImmunization(string name, string description);
        void RegisterSave(DateTime date);
    }
}