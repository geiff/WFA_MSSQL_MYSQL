using System;

namespace PersonDataMySql
{
    public partial class person
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}