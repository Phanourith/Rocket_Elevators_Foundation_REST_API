using System;
using System.Collections.Generic;

#nullable disable

namespace RocketApi.Models
{
    public partial class Employee
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string function { get; set; }
        public string email { get; set; }
        public int user_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
