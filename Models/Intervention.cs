using System;

namespace RocketApi.Models
{
    public class Intervention
    {
        public long Id { get; set; }
        public long Author {get; set; }
        public long CustomerID { get; set; }
        public long BuildingID { get; set; }
        public long BatteryID { get; set; }
        public long? ColumnID { get; set; }
        public long? ElevatorID { get; set; }
        public long? EmployeeID { get; set; }
        public DateTime? StartDateAndTime { get; set; }
        public DateTime? EndDateAndTime { get; set; }
        public string Result { get; set; }
        public string Report { get; set; }
        public string Status { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        public DateTime getNullSafety() 
        {
            // System.Diagnostics.Debug.WriteLine("-------------------------------------------- "  + StartDateAndTime + "--------------------------------------------------------");
            return DateTime.Now;
        }
    }
}

