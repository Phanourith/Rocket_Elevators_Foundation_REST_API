// using System.Collections.Generic;

// namespace RocketApi.Models
// {
//     public partial class BuildingDataTransfer{

//         public long id { get; set; }
//         public long? customer_id { get; set; }
//         public long? address_id { get; set; }
//         public List<FactIntervention> ListIntervention { get; set; }
//         public List<BuildingDetail> ListBuildingDetails { get; set; }

//         public BuildingDataTransfer(long id, long? customerId, long? addressId){
//             this.id = id;
//             this.customer_id = customerId;
//             this.address_id = addressId;
//             this.ListIntervention = new List<FactIntervention>();
//             this.ListBuildingDetails = new List<BuildingDetail>();
//         }

//     }
// }