using System;

namespace RocketApi.Models
{
    public class Customer
    {
        public long id { get; set; }
        public string company_contact_phone { get; set; }
        public string email_of_the_company_contact { get; set; }
        public DateTime created_at { get; set; }
    }
}