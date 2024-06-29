using System;

namespace deposit_app.Entities
{
    internal class Client
    {
        public Guid id {  get; set; }
        public string surname {  get; set; }
        public string first_name { get; set; }
        public string patronymic {  get; set; }
        public DateTime birth_date {  get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string passport_data { get; set; }
    }
}
