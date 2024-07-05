using System;

namespace deposit_app.Entities
{
    public class Client
    {
        public Guid Id {  get; set; }
        public string Surname {  get; set; }
        public string FirstName { get; set; }
        public string Patronymic {  get; set; }
        public DateTime BirthDate {  get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PassportData { get; set; }
    }
}
