using System;

namespace Domain
{
    public class UserTravelPlan
    {
        public Guid Id { get; set; }
        public bool IsHost { get; set; }
        public DateTime DateJoined { get; set; }

        public string UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public Guid TravelPlanId { get; set; }
        public virtual TravelPlan TravelPlan { get; set; }
        public int UserTravelRoleId { get; set; }
        public UserTravelRole UserTravelRole { get; set; }

    }
}