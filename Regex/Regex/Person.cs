using System;

namespace MatchPerson
{
   public class Person
    {
       public int IdentificationNumber { get; set; }
       public string PhoneNumber { get; set; }
       public string FullName { get; set; }
       public DateTime BirthDate { get; set; }
       public string Region { get; set; }
       public string City { get; set; }

       public override string ToString()
       {
           return
               $"ЕГН:{this.IdentificationNumber}, Телефонен номер:{this.PhoneNumber}," +
               $" Трите имена:{this.FullName}, Дата на раждане:{this.BirthDate}, Област:{this.Region}, Град:{this.City}";
       }
    }
}