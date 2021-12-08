using System;
using System.Collections.Generic;

#nullable disable

namespace RocketApi.Models
{
    public partial class FactIntervention
    {
        public long id { get; set; }
        public long employee_id { get; set; }
        public long building_id { get; set; }
        public long? battery_id { get; set; }
        public long? column_id { get; set; }
        public long? elevator_id { get; set; }
        public DateTime dateAndTimeInterventionStart { get; set; }
        public DateTime dateAndTimeInterventionEnd { get; set; }
        public string result { get; set; }
        public string report { get; set; }
        public string status { get; set; }
    }
}
