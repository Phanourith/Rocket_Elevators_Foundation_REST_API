using System;

namespace RocketApi.Models
{
    public class Lead
    {
        public long id { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime created_at { get; set; }
   
    }
}
