using System;
using System.Collections.Generic;

namespace Domain
{
    public class TravelPlan
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public virtual ICollection<UserTravelPlan> UserTravelPlans { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        
        
    }
}