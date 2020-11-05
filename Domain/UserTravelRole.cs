using System.Collections.Generic;

namespace Domain
{
    public class UserTravelRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserTravelPlan> UserTravelPlans { get; set; }
    }
}