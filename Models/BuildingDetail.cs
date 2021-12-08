using System;
using System.Collections.Generic;

#nullable disable

namespace RocketApi.Models
{
    public partial class BuildingDetail
    {
        public long id { get; set; }
        public long building_id { get; set; }
        public string informationKey { get; set; }
        public string value { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public virtual Building Building { get; set; }
    }
}
