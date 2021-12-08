using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class BuildingDTO{

        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? AddressId { get; set; }
        public List<FactIntervention> ListIntervention { get; set; }
        public List<BuildingDetail> ListBuildingDetails { get; set; }

        public BuildingDTO(long id, long? customerId, long? addressId){
            this.Id = id;
            this.CustomerId = customerId;
            this.AddressId = addressId;
            this.ListIntervention = new List<FactIntervention>();
            this.ListBuildingDetails = new List<BuildingDetail>();
        }

    }
}