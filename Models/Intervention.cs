using System;

namespace RocketApi.Models
{
    public class Intervention
    {
        public long id { get; set; }
        public long author {get; set; }
        public long customer_id { get; set; }
        public long building_id { get; set; }
        public long battery_id { get; set; }
        public int? column_id { get; set; }
        public int? elevator_id { get; set; }
        public int? employee_id { get; set; }
        public DateTime? start_intervention { get; set; }
        public DateTime? end_intervention { get; set; }
        public string result { get; set; }
        public string report { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public DateTime getNullSafety() 
        {
            // System.Diagnostics.Debug.WriteLine("-------------------------------------------- "  + StartDateAndTime + "--------------------------------------------------------");
            return DateTime.Now;
        }
    }
}

